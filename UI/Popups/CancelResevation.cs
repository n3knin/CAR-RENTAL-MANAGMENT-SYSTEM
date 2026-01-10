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
    public partial class CancelResevation : Form
    {
        private Reservation _reservation;
        private VehicleManager _vehicleManager;
        private ReservationManager _reservationManager;
        public CancelResevation(Reservation reservation)
        {
            InitializeComponent();
            ConfigureDatePickers();

            rsvtnID.Text = reservation.Id.ToString();
            txtcstmr.Text = reservation.CustomerName;
            vehicletxt.Text = reservation.VehicleInfo;
            pickupdt.Value = reservation.StartDate;
            expectreturndt.Value = reservation.EndDate;
            _reservation = reservation;
            _reservationManager = new ReservationManager();
            _vehicleManager = new VehicleManager();
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

        private void cancelbt_Click(object sender, EventArgs e)
        {
            _vehicleManager.UpdateVehicleStatus(_reservation.VehicleId, VehicleStatus.Available);
            _reservationManager.DeleteReservation(_reservation.Id);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rsvtnID_Click(object sender, EventArgs e)
        {

        }

        private void pickupdt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcstmr_Click(object sender, EventArgs e)
        {

        }

        private void expectreturndt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void vehicletxt_Click(object sender, EventArgs e)
        {

        }
    }
}
