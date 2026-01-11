using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalApp.Models.Core;
using RentalApp.Data.Repositories;
using RentalApp.Models.Vehicles;
using RentalApp.Models.Services;

namespace RentalApp.UI.Popups
{
    public partial class AddMaitenance : Form
    {
        private RentalApp.Models.Vehicles.Vehicle vehicle;
        private MaintenanceManager maintenanceManager;
        private VehicleManager vehicleManager;
        public AddMaitenance(RentalApp.Models.Vehicles.Vehicle vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;
            vehicletxt.Text = $"{vehicle.Make} {vehicle.Model}";
            maintenanceManager = new MaintenanceManager();
            vehicleManager = new VehicleManager();
            maintenanceTypeComboBox.DataSource = Enum.GetValues(typeof(MaintenanceRecord.MaintenanceType));
            maintenanceTypeComboBox.SelectedItem = MaintenanceRecord.MaintenanceType.OilChange;
        }

        private void cnclbttn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void strtbtn_Click(object sender, EventArgs e)
        {
            try
            {
                MaintenanceRecord.MaintenanceType serviceType = (MaintenanceRecord.MaintenanceType)maintenanceTypeComboBox.SelectedItem;

                MaintenanceRecord record = new MaintenanceRecord
                {
                    VehicleId = vehicle.VehicleId,
                    StartDate = dateTimePicker1.Value,
                    Type = serviceType,
                    Cost = Convert.ToDecimal(costTextBox.Text),
                    IsCompleted = false
                };

                maintenanceManager.ScheduleMaintenance(record);
                vehicleManager.UpdateVehicleStatus(vehicle.VehicleId, VehicleStatus.Maintenance);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding maintenance: " + ex.Message);
            }
        }
    }
}
