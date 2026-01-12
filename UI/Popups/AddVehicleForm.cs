using RentalApp.Models.Services;
using RentalApp.Models.Vehicles;
using RentalApp.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalApp.UI.Popups
{
    public partial class AddVehicleForm : Form
    {
        private VehicleManager _vehiclemanager;
        private FeatureRepository _featureRepository;
        public AddVehicleForm()
        {
            InitializeComponent();
            _vehiclemanager = new VehicleManager();
            _featureRepository = new FeatureRepository();
            LoadVehicleTypes();
            LoadFeatures();
            BTNAUTOMATIC.Checked = true;

        }

        private void LoadVehicleTypes()
        {
            comboBox1.DataSource = Enum.GetValues(typeof(FuelType));
            CATEGORYCMB.Items.Add("Sedan");
            CATEGORYCMB.Items.Add("SUV");
            CATEGORYCMB.Items.Add("Truck");
            CATEGORYCMB.Items.Add("Pickup");
            CATEGORYCMB.Items.Add("Hatchback");
            CATEGORYCMB.Items.Add("Van");
            CATEGORYCMB.SelectedIndex = 0;
        }

        private void LoadFeatures()
        {
            try
            {
                var features = _featureRepository.GetAllFeatures();
                foreach (var feature in features)
                {
                    FEATURES.Items.Add(feature);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading features: " + ex.Message);
            }
        }
        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void BTNAUTOMATIC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnvhcl_Click(object sender, EventArgs e)
        {
            TransmissionType transmission;

            if (BTNAUTOMATIC.Checked)
                transmission = TransmissionType.Automatic;
            else if (BTNMANUAL.Checked)  // Assuming you have a BTNMANUAL radio button
                transmission = TransmissionType.Manual;
            else
            {
                MessageBox.Show("Please select a transmission type.");
                return; // Stop if nothing selected
            }

            Vehicle newVehicle;
            string type =CATEGORYCMB.SelectedItem.ToString();
            

            if(type == "Sedan")
            {
                newVehicle = new Sedan();
            }
            else if(type == "SUV")
            {
                newVehicle = new SUV();
            }
            else if(type == "Pickup")
            {
                newVehicle = new Pickup();
            }
            else if(type == "Hatchback")
            {
                newVehicle = new Hatchback();
            }
            else
            {
                newVehicle = new Van();
            }

            newVehicle.Make = txtmake.Text;
            newVehicle.Model = txtmodel.Text;
            newVehicle.Year = Convert.ToInt32(txtyear.Text);
            newVehicle.Color = txtcolor.Text;
            newVehicle.Fuel = (FuelType)comboBox1.SelectedItem;
            newVehicle.Transmission = transmission;
            newVehicle.VIN = txtvin.Text;
            newVehicle.Mileage = Convert.ToInt32(txtmileage.Text);
            newVehicle.Status = VehicleStatus.Available;
            newVehicle.LicensePlate = txtlicense.Text;
            newVehicle.SeatingCapacity = (int)seat.Value;
            
            // Map vehicle type to CategoryId
            int categoryId;
            switch (type)
            {
                case "Sedan":
                    categoryId = 1;
                    break;
                case "SUV":
                    categoryId = 2;
                    break;
                case "Truck":
                    categoryId = 3;
                    break;
                case "Pickup":
                    categoryId = 4;
                    break;
                case "Hatchback":
                    categoryId = 5;
                    break;
                case "Van":
                    categoryId = 6;
                    break;
                default:
                    categoryId = 1; 
                    break;
            }
            newVehicle.CategoryId = categoryId;
            
            
            int newVehicleId = _vehiclemanager.Add(newVehicle);
            
            
            foreach (var item in FEATURES.CheckedItems)
            {   
                string featureName = item.ToString();
                int featureId = _featureRepository.GetFeatureIdByName(featureName);
                if (featureId > 0)
                {
                    _featureRepository.AddFeatureToVehicle(newVehicleId, featureId);
                }
            }
            
            MessageBox.Show("Vehicle added successfully.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txtlicense_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddVehicleForm_Load(object sender, EventArgs e)
        {

        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
