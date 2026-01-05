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
            public STARTrentalform(Reservation selectedReservation)
            {
                InitializeComponent();
                reservation = selectedReservation;
                _rentalmanager = new RentalManager();
                _vehiclemanager = new VehicleManager();
                _reservationmanager = new ReservationManager();
                loadcustemerdata(); 
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

                try
                {
                    _reservationmanager.UpdateReservationStatus(reservation.Id, ReservationStatus.Confirmed);
                    _rentalmanager.StartRental(startrental);
                    _vehiclemanager.UpdateVehicleStatus(reservation.VehicleId, VehicleStatus.Rented);
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

            private void loadcustemerdata ()
            {
                this.Text = "Customer Details";
                rsvtnID.Text = reservation.Id.ToString();

                txtcstmr.Text = reservation.CustomerName;
                vehicletxt.Text = reservation.VehicleInfo;

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

        }
    }
    }
