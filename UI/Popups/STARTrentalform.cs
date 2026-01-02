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

    namespace RentalApp.UI.Popups
    {
        
        public partial class STARTrentalform : Form
        {
            private Reservation reservation;
            private RentalManager _rentalmanager;
            private VehicleManager _vehiclemanager;
            public STARTrentalform(Reservation selectedReservation)
            {
                InitializeComponent();
                reservation = selectedReservation;
                _rentalmanager = new RentalManager();
                _vehiclemanager = new VehicleManager();
                loadcustemerdata(); 
            }

            private void strtbtn_Click(object sender, EventArgs e)
            {
                var startrental = new Rental

                {
                    ReservationId = reservation.Id,
                    CustomerId = reservation.CustomerId,
                    VehicleId = reservation.VehicleId,
                    Status = RentalStatus.Active,
                    StartMileage = int.Parse(lblmileage.Text),
                    EndMileage = null,
                    ActualPickupDate = pickupdt.Value,
                    RentalAgentId = Session.CurrentUserId
                };

                try
                {
                    _rentalmanager.StartRental(startrental);
                    _vehiclemanager.UpdateVehicleStatus(reservation.VehicleId, VehicleStatus.Reserved);
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
        }
    }
