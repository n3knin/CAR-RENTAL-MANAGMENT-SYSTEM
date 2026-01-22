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
            LoadMakes();
            ConfigureYearPicker();
            LoadFeatures();
            BTNAUTOMATIC.Checked = true;
            
            txtvin.CharacterCasing = CharacterCasing.Upper;
            txtlicense.CharacterCasing = CharacterCasing.Upper;
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
            comboBox1.SelectedIndex = 0;
        }

        private void LoadMakes()
        {
            string[] commonMakes = { "Toyota", "Mitsubishi", "Ford", "Honda", "Nissan", "Hyundai", "Kia", "Isuzu", "Suzuki", "Chevrolet", "Mazda" };
            cmbmake.Items.AddRange(commonMakes);
            cmbmake.SelectedIndex = 0;
        }

        private void ConfigureYearPicker()
        {
            dtpyear.Format = DateTimePickerFormat.Custom;
            dtpyear.CustomFormat = "yyyy";
            dtpyear.ShowUpDown = true;
            dtpyear.MaxDate = DateTime.Now;
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
           
            
            // Validate all required fields before proceeding
            if (string.IsNullOrWhiteSpace(cmbmake.Text))
            {
                MessageBox.Show("Please enter or select the vehicle make.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtmodel.Text))
            {
                MessageBox.Show("Please enter the vehicle model.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int year = dtpyear.Value.Year;
            if (year < 1900 || year > DateTime.Now.Year)
            {
                MessageBox.Show("Please select a valid year.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtcolor.Text))
            {
                MessageBox.Show("Please enter the vehicle color.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vin = txtvin.Text.Trim().ToUpper();
            if (!System.Text.RegularExpressions.Regex.IsMatch(vin, @"^[A-HJ-NPR-Z0-9]{17}$"))
            {
                MessageBox.Show("Please enter a valid 17-character VIN (Alphanumeric, excluding I, O, and Q).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             if(txtvin.Text == "EX. 4Y1SL65848Z411439" || txtvin.Text == "4Y1SL65848Z411439" || txtvin.Text == "")
            {
                MessageBox.Show("Please enter a valid VIN.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtmileage.Text) || !int.TryParse(txtmileage.Text, out int mileage))
            {
                MessageBox.Show("Please enter a valid mileage.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string license = txtlicense.Text.Trim().ToUpper();
            if (!System.Text.RegularExpressions.Regex.IsMatch(license, @"^[A-Z]{3}[0-9]{4}$"))
            {
                MessageBox.Show("License Plate must be in the format 'ABC1234' (3 letters followed by 4 numbers).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtlicense.Text == "EX. ABC1234" || txtlicense.Text == "ABC1234" || txtlicense.Text == "")
            {
                MessageBox.Show("Please enter a valid license plate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            license = license.ToUpper(); // Ensure it's uppercase

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a fuel type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            newVehicle.Make = cmbmake.Text;
            newVehicle.Model = txtmodel.Text;
            newVehicle.Year = year;
            newVehicle.Color = txtcolor.Text;
            newVehicle.Fuel = (FuelType)comboBox1.SelectedItem;
            newVehicle.Transmission = transmission;
            newVehicle.VIN = vin;
            newVehicle.Mileage = mileage;
            newVehicle.Status = VehicleStatus.Available;
            newVehicle.LicensePlate = license;
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
            
            
            try
            {
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
                
                MessageBox.Show("Vehicle added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException ex)
            {
                // Handle validation errors (duplicate VIN, license plate, etc.)
                MessageBox.Show(ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Don't close the form - let user correct the error
            }
            catch (Exception ex)
            {
                // Handle any other unexpected errors
                MessageBox.Show($"An error occurred while adding the vehicle:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Don't close the form - let user try again
            }
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

        private void cmbmake_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel13_Click(object sender, EventArgs e)
        {

        }

        private void FEATURES_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void seat_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel11_Click(object sender, EventArgs e)
        {

        }

        private void txtmileage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {

        }

        private void CATEGORYCMB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void BTNMANUAL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpyear_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
