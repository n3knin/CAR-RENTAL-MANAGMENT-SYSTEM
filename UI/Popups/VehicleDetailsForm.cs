using System;
using System.Windows.Forms;
using RentalApp.Models.Vehicles;

using RentalApp.Data.Repositories; 

namespace RentalApp.UI.Popups
{
    public partial class VehicleDetailsForm : Form
    {
        private Vehicle _vehicle; 
        private FeatureRepository _featureRepo;

        // Constructor REQUIRES a vehicle object
        public VehicleDetailsForm(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;
            _featureRepo = new FeatureRepository();

            
            _vehicle.Features = _featureRepo.GetFeaturesByVehicleId(_vehicle.VehicleId);
            
            LoadData(); 
        }

        private void LoadData()
        {
            this.Text = $"{_vehicle.Year} {_vehicle.Make} {_vehicle.Model}"; 
            
            lblMakeModel.Text = $"{_vehicle.Make} {_vehicle.Model}";
            lblLicense.Text = _vehicle.LicensePlate;
            lblStatus.Text = _vehicle.Status.ToString();
            
            lblType.Text = _vehicle.GetVehicleType(); 
            
            lstFeatures.Items.Clear();
            if (_vehicle.Features != null && _vehicle.Features.Count > 0)
            {
                foreach (var feature in _vehicle.Features)
                {
                    lstFeatures.Items.Add(feature);
                }
            }
            else
            {
                lstFeatures.Items.Add("(No features listed)");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
