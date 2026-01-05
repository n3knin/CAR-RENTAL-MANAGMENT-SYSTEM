using RentalApp.Models.Services;
using RentalApp.Models.Core; // Add this for Customer and Reservation
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
    public partial class PickupForm : Form
    {
        private ReservationManager _reservationManager;
        
        public PickupForm()
        {
            InitializeComponent();
            _reservationManager = new ReservationManager();
            LoadAllReservation(); // Load data when form opens
        }
        private void LoadAllReservation()
        {
            try
            {
                var reservationlist = _reservationManager.GetAllPending();

                var bindingSource = new BindingSource();
                bindingSource.DataSource = reservationlist;

                pickupgrid.AutoGenerateColumns = true;
                pickupgrid.DataSource = bindingSource;
                pickupgrid.ReadOnly = true;

                // Hide unnecessary columns
                if (pickupgrid.Columns["Id"] != null) pickupgrid.Columns["Id"].Visible = false;
                if (pickupgrid.Columns["VehicleId"] != null) pickupgrid.Columns["VehicleId"].Visible = false;
                if(pickupgrid.Columns["CreatedAt"] != null) pickupgrid.Columns["CreatedAt"].Visible = false;
                if (pickupgrid.Columns["CustomerId"] != null) pickupgrid.Columns["CustomerId"].Visible = false;
                if (pickupgrid.Columns["Customer"] != null) pickupgrid.Columns["Customer"].Visible = false;
                if (pickupgrid.Columns["Vehicle"] != null) pickupgrid.Columns["Vehicle"].Visible = false;

                // Rename headers for display properties
                if (pickupgrid.Columns["CustomerName"] != null) 
                {
                    pickupgrid.Columns["CustomerName"].HeaderText = "Customer";
                    pickupgrid.Columns["CustomerName"].DisplayIndex = 0;
                }
                if (pickupgrid.Columns["VehicleInfo"] != null)
                {
                    pickupgrid.Columns["VehicleInfo"].HeaderText = "Vehicle";
                    pickupgrid.Columns["VehicleInfo"].DisplayIndex = 1;
                }
                if (pickupgrid.Columns["ActualPickupDate"] != null) pickupgrid.Columns["ActualPickupDate"].HeaderText = "Pickup Date";
                if (pickupgrid.Columns["ActualReturnDate"] != null) pickupgrid.Columns["ActualReturnDate"].HeaderText = "Return Date";
                if (pickupgrid.Columns["StartMileage"] != null) pickupgrid.Columns["StartMileage"].HeaderText = "Start Mileage";

                pickupgrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading reservations: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             if (e.RowIndex < 0) return;


            var selectedReservation = (Reservation)pickupgrid.Rows[e.RowIndex].DataBoundItem;
            
           

            using (var form = new STARTrentalform(selectedReservation))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }

        }
    }
}
