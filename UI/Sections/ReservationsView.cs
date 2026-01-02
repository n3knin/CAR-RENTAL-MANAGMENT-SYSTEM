using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Services;
using RentalApp.Models.Core;
namespace RentalApp.UI.Sections
{
    public partial class ReservationsView : UserControl
    {
        private ReservationManager _reservationManager;
        public ReservationsView()
        {
            InitializeComponent();
            _reservationManager = new ReservationManager();
            
            // Fix 1: Load data on startup
            LoadReservations();
            
            InitializeDragAndDrop();
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
            try{
                var reservations = _reservationManager.GetAllReservations();
                var bindingSource = new BindingSource();
                bindingSource.DataSource = reservations;

                reservationsGrid.AutoGenerateColumns = true;
                reservationsGrid.DataSource = bindingSource;

                // Configure Columns Programmatically
                if (reservationsGrid.Columns["Id"] != null) reservationsGrid.Columns["Id"].Visible = false;
                if (reservationsGrid.Columns["CustomerId"] != null) reservationsGrid.Columns["CustomerId"].Visible = false;
                if (reservationsGrid.Columns["VehicleId"] != null) reservationsGrid.Columns["VehicleId"].Visible = false;
                if (reservationsGrid.Columns["CreatedAt"] != null) reservationsGrid.Columns["CreatedAt"].Visible = false;
                if (reservationsGrid.Columns["Customer"] != null) reservationsGrid.Columns["Customer"].Visible = false;
                if (reservationsGrid.Columns["Vehicle"] != null) reservationsGrid.Columns["Vehicle"].Visible = false;

                // Rename Headers for Display Properties
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
                if (reservationsGrid.Columns["StartDate"] != null) reservationsGrid.Columns["StartDate"].HeaderText = "From";
                if (reservationsGrid.Columns["EndDate"] != null) reservationsGrid.Columns["EndDate"].HeaderText = "To";

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
    }
}



