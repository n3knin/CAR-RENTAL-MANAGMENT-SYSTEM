using System;
using System.Windows.Forms;
using RentalApp.Models.Services;
using RentalApp.Models.Core;
using RentalApp.Models.Vehicles;
using System.Collections.Generic;

namespace RentalApp.UI.Popups
{
    public partial class ReservationForm : Form
    {
        private CustomerManager _customerManager;
        private VehicleManager _vehicleManager;
        private ReservationManager _reservationManager;

        public ReservationForm()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
            _vehicleManager = new VehicleManager();
            _reservationManager = new ReservationManager();
            
            // Configure DateTimePickers for 12-hour format
            ConfigureDateTimePickers();
            
            LoadFormData();
        }

        private void ConfigureDateTimePickers()
        {
            // Start Date picker
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpStartDate.ShowUpDown = true;

            // End Date picker
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpEndDate.ShowUpDown = true;
        }

        private void LoadFormData()
        {
            try
            {
                // 1. Load Customers
                var customers = _customerManager.GetAllCustomers();
                cmbCustomers.DataSource = customers;
                cmbCustomers.DisplayMember = "GetFullName"; 
                var allVehicles = _vehicleManager.GetAllVehicles();
                var availableVehicles = new List<Vehicle>();
                
                foreach (var v in allVehicles)
                {
                    if (v.IsAvailable())
                    {
                        availableVehicles.Add(v);
                    }
                }
                
                cmbVehicles.DataSource = availableVehicles;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading form data: " + ex.Message);
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var form = new AddnewCustomer()) { 
                if (form.ShowDialog() == DialogResult.OK) { LoadFormData(); } 
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // 1. Validate Selection
            if (cmbCustomers.SelectedItem == null || cmbVehicles.SelectedItem == null)
            {
                MessageBox.Show("Please select both a Customer and a Vehicle.");
                return;
            }

            if (dtpEndDate.Value <= dtpStartDate.Value)
            {
                MessageBox.Show("End Date must be after Start Date.");
                return;
            }

            // 2. Extract Data
            // 2. Create Reservation Object
            var selectedCustomer = (Customer)cmbCustomers.SelectedItem;
            var selectedVehicle = (Vehicle)cmbVehicles.SelectedItem;
            
            // Check if vehicle is available
            if (selectedVehicle.Status != VehicleStatus.Available)
            {
                MessageBox.Show($"This vehicle is currently {selectedVehicle.Status}. Please select an available vehicle.", 
                    "Vehicle Not Available", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }
            
            var newReservation = new Reservation
            {
                Customer = selectedCustomer,
                CustomerId = selectedCustomer.Id,
                Vehicle = selectedVehicle,
                VehicleId = selectedVehicle.VehicleId,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                Status = ReservationStatus.Pending
            };

            MessageBox.Show($"Ready to Reserve:\nCar: {selectedVehicle}\nFor: {selectedCustomer}\nFrom: {dtpStartDate.Value}\nTo: {dtpEndDate.Value}", 
                            "Confirm");

            try 
            {
                 _reservationManager.CreateReservation(newReservation);
                _vehicleManager.UpdateVehicleStatus(selectedVehicle.VehicleId, VehicleStatus.Reserved);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                 MessageBox.Show("Error creating reservation: " + ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
