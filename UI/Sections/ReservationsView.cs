using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Services;
using RentalApp.Models.Core;
using RentalApp.UI.Popups;
namespace RentalApp.UI.Sections
{
    public partial class ReservationsView : UserControl
    {
        private ReservationManager _reservationManager;
        public ReservationsView()
        {
            InitializeComponent();
            
            // Make columns stretch to fill width
            reservationsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            _reservationManager = new ReservationManager();
            
            // Fix 1: Load data on startup
            LoadReservations();
            
            InitializeDragAndDrop();
            
            // Hook up date range filters
            dtpFROM.ValueChanged += (s, e) => LoadReservations();
            dtpTO.ValueChanged += (s, e) => LoadReservations();
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += ReservationsView_DragEnter;
            this.DragDrop += ReservationsView_DragDrop;
        }

        private void ReservationsView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void ReservationsView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                HandleDroppedFiles(files);
            }
        }

        private void HandleDroppedFiles(string[] files)
        {
            string fileList = string.Join("\n", files);
            MessageBox.Show($"Files dropped on Reservations View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void LoadReservations()
        {
            try {
                DateTime fromDate = dtpFROM.Value;
                DateTime toDate = dtpTO.Value;

                if (fromDate.Date > toDate.Date)
                {
                    MessageBox.Show("Error: From Date cannot be greater than To Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; 
                }

                var reservations = _reservationManager.GetByDateRange(fromDate, toDate);
                
                var bindingSource = new BindingSource();
                bindingSource.DataSource = reservations;

                reservationsGrid.AutoGenerateColumns = true;
                reservationsGrid.DataSource = null;
                reservationsGrid.DataSource = bindingSource;

                if (reservationsGrid.Columns["Id"] != null) reservationsGrid.Columns["Id"].Visible = false;
                if (reservationsGrid.Columns["CustomerId"] != null) reservationsGrid.Columns["CustomerId"].Visible = false;
                if (reservationsGrid.Columns["VehicleId"] != null) reservationsGrid.Columns["VehicleId"].Visible = false;
                if (reservationsGrid.Columns["CreatedAt"] != null) reservationsGrid.Columns["CreatedAt"].Visible = false;
                if (reservationsGrid.Columns["Customer"] != null) reservationsGrid.Columns["Customer"].Visible = false;
                if (reservationsGrid.Columns["Vehicle"] != null) reservationsGrid.Columns["Vehicle"].Visible = false;

            
                if (reservationsGrid.Columns["CustomerName"] != null) 
                {
                    reservationsGrid.Columns["CustomerName"].HeaderText = "Customer";
                    reservationsGrid.Columns["CustomerName"].DisplayIndex = 0;
                }
                if (reservationsGrid.Columns["VehicleInfo"] != null) 
                {
                    reservationsGrid.Columns["VehicleInfo"].HeaderText = "Vehicle";
                    reservationsGrid.Columns["VehicleInfo"].DisplayIndex = 1;
                }
                if (reservationsGrid.Columns["StartDate"] != null) reservationsGrid.Columns["StartDate"].HeaderText = "From Date";
                if (reservationsGrid.Columns["EndDate"] != null) reservationsGrid.Columns["EndDate"].HeaderText = "To Date";
                if (reservationsGrid.Columns["Status"] != null) reservationsGrid.Columns["Status"].HeaderText = "Status";

                reservationsGrid.Refresh();
                
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fix 2: Added missing event handler
        private void reservationsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void newReservationButton_Click(object sender, EventArgs e)
        {
            using (var form = new Popups.ReservationForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadReservations(); // Refresh grid after adding
                }
            }
        }

        private void cancelbt_Click(object sender, EventArgs e)
        {
            if(reservationsGrid.CurrentCell != null && reservationsGrid.CurrentCell.RowIndex >= 0)
            {
                var reservation = (Reservation)reservationsGrid.CurrentRow.DataBoundItem;

                if (reservation.Status != ReservationStatus.Pending)
                {
                    MessageBox.Show($"This reservation is {reservation.Status} and cannot be cancelled.",
                        "Action Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var form = new Popups.CancelResevation(reservation))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadReservations();
                    }
                }
            }
        }
    }
}



