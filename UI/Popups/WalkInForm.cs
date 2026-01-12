using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalApp.Models.Services;
using RentalApp.Models.Core;
using RentalApp.Models.Vehicles;
namespace RentalApp.UI.Popups
{
    public partial class WalkInForm : Form
    {
        CustomerManager _customerManager;
        RentalManager _rentalManager;
        VehicleManager _vehicleManager;
        ReservationManager _reservationManager;
        DepositManager _depositManager;
        public WalkInForm()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
            _rentalManager = new RentalManager();
            _vehicleManager = new VehicleManager();
            _reservationManager = new ReservationManager();
            _depositManager = new DepositManager();
            ConfigureDatePickers();
            loadcustomerdata();
            cmbrenttype.Items.Add("Daily");
            cmbrenttype.Items.Add("Weekly");
            cmbrenttype.Items.Add("Monthly");
            cmbrenttype.Items.Add("Hourly");
            cmbrenttype.SelectedIndex = 0;
        }

        private void ConfigureDatePickers()
        {
            dtpPD.Format = DateTimePickerFormat.Custom;
            dtpPD.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpPD.Value = DateTime.Now;

            dtpERD.Format = DateTimePickerFormat.Custom;
            dtpERD.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpERD.Value = DateTime.Now.AddDays(1);
        }

        private void txtSM_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            using (var form = new AddnewCustomer())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    loadcustomerdata();     
                }
            }
        }

        private void startbt_Click(object sender, EventArgs e)
        {
            if (cmbcstmr.SelectedValue == null || cmbvhcl.SelectedValue == null)
            {
                MessageBox.Show("Please select both a Customer and a Vehicle.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerId = (int)cmbcstmr.SelectedValue;
            int vehicleId = (int)cmbvhcl.SelectedValue;

            if (_rentalManager.HasActiveRental(customerId))
            {
                MessageBox.Show("This customer already has an active rental. Please refresh or check their status.", "Active Rental Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadcustomerdata(); 
                return;
            }

            if (_reservationManager.HasActiveReservation(customerId))
            {
                MessageBox.Show("This customer already has a pending or confirmed reservation.", "Existing Reservation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadcustomerdata(); 
                return;
            }

            var startrental = new Rental
            {
                CustomerId = customerId,
                VehicleId = vehicleId,
                ActualPickupDate = dtpPD.Value,
                ExpectedReturnDate = dtpERD.Value,
                StartMileage = int.Parse(txtSM.Text),
                EndMileage = null,
                RentalAgentId = Session.CurrentUserId,
                Status = RentalStatus.Active
            };

            // Parse deposit
            if (!decimal.TryParse(txtdeposit.Text, out decimal depositAmount))
            {
                MessageBox.Show("Please enter a valid deposit amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validation Logic
            // Daily = index 0, Weekly = index 1, Monthly = index 2
            // Limits: Daily <= 1000, Weekly <= 7000, Monthly <= 20000
            
            if (cmbrenttype.SelectedIndex == 0) // Daily
            {
                if (depositAmount > 1000)
                {
                    MessageBox.Show("Deposit for Daily rental cannot exceed 1000.", "Deposit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (cmbrenttype.SelectedIndex == 1) // Weekly
            {
                 if (depositAmount > 7000)
                {
                    MessageBox.Show("Deposit for Weekly rental cannot exceed 7000.", "Deposit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if (cmbrenttype.SelectedIndex == 2) // Monthly
            {
                 if (depositAmount > 20000)
                {
                    MessageBox.Show("Deposit for Monthly rental cannot exceed 20000.", "Deposit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else if(cmbrenttype.SelectedIndex == 3) // Hourly
            {
                if (depositAmount > 70)
                {
                    MessageBox.Show("Deposit for Hourly rental cannot exceed 70.", "Deposit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                _rentalManager.StartRental(startrental);
                _vehicleManager.UpdateVehicleStatus((int)cmbvhcl.SelectedValue, VehicleStatus.Rented);
                _depositManager.ProcessDeposit(startrental.Id, decimal.Parse(txtdeposit.Text));
                MessageBox.Show("Rental started successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error starting rental: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }
        private void loadcustomerdata()
        {
            try
            {
                var customers = _customerManager.GetAvailableCustomers();
                
                cmbcstmr.DataSource = null; 
                cmbcstmr.DataSource = customers;
                cmbcstmr.DisplayMember ="FullName"; 
                cmbcstmr.ValueMember = "Id"; 

                var vehicles = _vehicleManager.GetAvailableVehicles();
                cmbvhcl.DataSource = null; 
                cmbvhcl.DataSource = vehicles;
                cmbvhcl.DisplayMember = "VehicleName"; 
                cmbvhcl.ValueMember = "VehicleId"; 

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void cmbcstmr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbvhcl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedVehicle = cmbvhcl.SelectedItem as Vehicle;
            if (selectedVehicle != null)
            {
                cmbVT.Text = selectedVehicle.GetVehicleType();
                txtSM.Text = selectedVehicle.Mileage.ToString();
                txtSM.ReadOnly = true;
            }
        }

        private void cmbVT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpPD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpERD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cancelbt_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbrenttype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdeposit_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
