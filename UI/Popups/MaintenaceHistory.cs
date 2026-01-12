using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalApp.Models.Vehicles;
using RentalApp.Models.Services;
using RentalApp.Models.Core;
namespace RentalApp.UI.Popups

{
    public partial class MaintenaceHistory : Form
    {
        Vehicle vehicle;
        VehicleManager vehicleManager;
        MaintenanceManager maintenanceManager;
        public MaintenaceHistory(Vehicle vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;
            vehicleManager = new VehicleManager();
            maintenanceManager = new MaintenanceManager();
            vehicletxt.Text = vehicle.Make + " " + vehicle.Model;
            maintenanceGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            loadMaintenanceHistory();
        }
        private void loadMaintenanceHistory()
        {
            try
            {
                var maintenanceHistory = maintenanceManager.GetHistory(vehicle.VehicleId);
                var bindingSource = new BindingSource();
                bindingSource.DataSource = maintenanceHistory;
                maintenanceGrid.DataSource = bindingSource;
                maintenanceGrid.ReadOnly = true;
                if (maintenanceGrid.Columns["Id"] != null) maintenanceGrid.Columns["Id"].Visible = false;
                if(maintenanceGrid.Columns["Vehicle"] != null) maintenanceGrid.Columns["Vehicle"].Visible = false;
                if (maintenanceGrid.Columns["VehicleId"] != null) maintenanceGrid.Columns["VehicleId"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading maintenance history: " + ex.Message);
            }
        }
        private void newrecordbt_Click(object sender, EventArgs e)
        {
            int count = maintenanceManager.CountMaintenanceRecords(vehicle.VehicleId);
            string status = vehicleManager.GetVehicleStatus(vehicle.VehicleId);

            if (status == "Retired" || status == "Rented"|| status == "Out of Service")
            {
                MessageBox.Show("Vehicle is retired and cannot be scheduled for maintenance.");
                return;
            }
           
            if (count > 1 )
            {
                MessageBox.Show("Vehicle has already been scheduled for maintenance.");
                return; 
            }
            using (var maintenanceForm = new Popups.AddMaitenance(vehicle))
            {
               if (maintenanceForm.ShowDialog() == DialogResult.OK)
               {
                   loadMaintenanceHistory();
                   this.DialogResult = DialogResult.OK; 
               }
            }
        }

        private void maintenanceGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var record = (MaintenanceRecord)maintenanceGrid.Rows[e.RowIndex].DataBoundItem;

            if (record.IsCompleted)
            {
                MessageBox.Show("This maintenance task is already completed.", "Task Finished", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string message = $"Mark {record.Type} (Started: {record.StartDate.ToShortDateString()}) as complete?";
            
            if (MessageBox.Show(message, "Confirm Completion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                maintenanceManager.CompleteMaintenance(record.Id, record.VehicleId);
                loadMaintenanceHistory();
                this.DialogResult = DialogResult.OK; 
            }
        }
    }
}
