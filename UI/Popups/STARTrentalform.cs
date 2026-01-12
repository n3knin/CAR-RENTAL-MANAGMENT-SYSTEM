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
    using RentalApp.Models.Services;
    using RentalApp.Models.Vehicles;  
    using RentalApp.Data.Repositories;

    namespace RentalApp.UI.Popups
    {
        
        public partial class STARTrentalform : Form
        {
            private Reservation reservation;
            private ReservationManager _reservationmanager;
            private RentalManager _rentalmanager;
            private VehicleManager _vehiclemanager;
            private DepositManager _depositManager; 
            public STARTrentalform(Reservation selectedReservation)
            {
                InitializeComponent();
                reservation = selectedReservation;
                _rentalmanager = new RentalManager();
                _vehiclemanager = new VehicleManager();
                _reservationmanager = new ReservationManager();
                _depositManager = new DepositManager();
                loadcustemerdata(); 
                ConfigureDatePickers();
                
                cmbrenttype.Items.Add("Daily");
                cmbrenttype.Items.Add("Weekly");
                cmbrenttype.Items.Add("Monthly");
                cmbrenttype.Items.Add("Hourly");
                cmbrenttype.SelectedIndex = 0;

            }
            private void ConfigureDatePickers()
        {
            pickupdt.Format = DateTimePickerFormat.Custom;
            pickupdt.CustomFormat = "MM/dd/yyyy hh:mm tt";
            pickupdt.Value = DateTime.Now;

            expectreturndt.Format = DateTimePickerFormat.Custom;
            expectreturndt.CustomFormat = "MM/dd/yyyy hh:mm tt";
            expectreturndt.Value = DateTime.Now.AddDays(1);
        }

            private void strtbtn_Click(object sender, EventArgs e)
            {
                var startrental = new Rental

                {
                    ReservationId = reservation.Id,
                    CustomerId = reservation.CustomerId,
                    VehicleId = reservation.VehicleId,
                    ActualPickupDate = pickupdt.Value,
                    
                    StartMileage = int.Parse(lblmileage.Text),
                    EndMileage = null,
                    ExpectedReturnDate = reservation.EndDate,
                    ActualReturnDate = null,
                    RentalAgentId = Session.CurrentUserId,
                    Status = RentalStatus.Active
                };
                // Parse deposit
                if (!decimal.TryParse(txtdeposit.Text, out decimal depositAmount))
                {
                    MessageBox.Show("Please enter a valid deposit amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if(cmbrenttype.SelectedIndex == 0) // Daily
                {
                    if (depositAmount > 1000)
                    {
                        MessageBox.Show("Deposit for Daily rental cannot exceed 1000.", "Deposit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if(cmbrenttype.SelectedIndex == 1) // Weekly
                {
                     if (depositAmount > 7000)
                    {
                        MessageBox.Show("Deposit for Weekly rental cannot exceed 7000.", "Deposit Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if(cmbrenttype.SelectedIndex == 2) // Monthly
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
                if (expectreturndt.Value <= pickupdt.Value)
                {
                    MessageBox.Show("Expected Return Date must be after the Pickup Date.", "Invalid Dates", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (_rentalmanager.HasActiveRental(reservation.CustomerId))
                {
                    MessageBox.Show("This customer already has an active rental in the system. Please complete the existing rental before starting a new one.", 
                        "Active Rental Detected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _reservationmanager.UpdateReservationStatus(reservation.Id, ReservationStatus.Confirmed);
                    _rentalmanager.StartRental(startrental);
                    _vehiclemanager.UpdateVehicleStatus(reservation.VehicleId, VehicleStatus.Rented);
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

            private void materialLabel3_Click(object sender, EventArgs e)
            {

            }

            private void materialSingleLineTextField1_Click(object sender, EventArgs e)
            {

            }

            private void materialLabel8_Click(object sender, EventArgs e)
            {

            }

            private void rsvtnID_Click(object sender, EventArgs e)
            {

            }

            private void vehicletxt_Click(object sender, EventArgs e)
            {

            }

            private void loadcustemerdata()
            {
                this.Text = "Customer Details";
                rsvtnID.Text = reservation.Id.ToString();
                
                txtcstmr.Text = reservation.CustomerName;
                vehicletxt.Text = reservation.VehicleInfo;
                expectreturndt.Value = reservation.EndDate;

                var vehicle = _vehiclemanager.GetVehicleById(reservation.VehicleId);
                if (vehicle != null)
                {
                    lblmileage.Text = vehicle.Mileage.ToString(); 
                    lblmileage.ReadOnly = true;
                }
            }

           

            private void pickupdt_ValueChanged(object sender, EventArgs e)
            {

            }

            private void lblmileage_TextChanged(object sender, EventArgs e)
            {

            }

        private void cnclbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void expectreturndt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void grpReservationInfo_Enter(object sender, EventArgs e)
        {

        }

        private void cmbrenttype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
