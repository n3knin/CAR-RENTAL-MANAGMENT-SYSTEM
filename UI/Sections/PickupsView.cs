using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Services;

namespace RentalApp.UI.Sections
{
    public partial class PickupsView : UserControl
    {
        private RentalManager _rentalManager;

        public PickupsView()
        {
            InitializeComponent();
            _rentalManager = new RentalManager();
            LoadActiveRentals();
            InitializeDragAndDrop();
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += PickupsView_DragEnter;
            this.DragDrop += PickupsView_DragDrop;
        }

        private void PickupsView_DragEnter(object sender, DragEventArgs e)
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

        private void PickupsView_DragDrop(object sender, DragEventArgs e)
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
            MessageBox.Show($"Files dropped on Pickups View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void startPickupButton_Click(object sender, EventArgs e)
        {
            using (var form = new Popups.PickupForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadActiveRentals(); 
                }
            }
        }

        private void pickupsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadActiveRentals()
        {
            try
            {
                // Fetch active rentals from DB
                var rentalList = _rentalManager.GetActiveRentals();

                // Bind to Grid using BindingSource
                var bindingSource = new BindingSource();
                bindingSource.DataSource = rentalList;

                pickupsGrid.AutoGenerateColumns = true;
                pickupsGrid.DataSource = bindingSource;
                pickupsGrid.ReadOnly = true;

                // Hide unnecessary columns
                if (pickupsGrid.Columns["Id"] != null) pickupsGrid.Columns["Id"].Visible = false;
                if (pickupsGrid.Columns["VehicleId"] != null) pickupsGrid.Columns["VehicleId"].Visible = false;
                if (pickupsGrid.Columns["RentalAgentId"] != null) pickupsGrid.Columns["RentalAgentId"].Visible = false;
                if (pickupsGrid.Columns["CustomerId"] != null) pickupsGrid.Columns["CustomerId"].Visible = false;
                if (pickupsGrid.Columns["ReservationId"] != null) pickupsGrid.Columns["ReservationId"].Visible = false;
                if (pickupsGrid.Columns["EndMileage"] != null) pickupsGrid.Columns["EndMileage"].Visible = false;
                if (pickupsGrid.Columns["Customer"] != null) pickupsGrid.Columns["Customer"].Visible = false;
                if (pickupsGrid.Columns["Vehicle"] != null) pickupsGrid.Columns["Vehicle"].Visible = false;
                if (pickupsGrid.Columns["RentalAgent"] != null) pickupsGrid.Columns["RentalAgent"].Visible = false;

                // Rename headers for display properties
                if (pickupsGrid.Columns["CustomerName"] != null) 
                {
                    pickupsGrid.Columns["CustomerName"].HeaderText = "Customer";
                    pickupsGrid.Columns["CustomerName"].DisplayIndex = 0;
                }
                if (pickupsGrid.Columns["VehicleInfo"] != null) 
                {
                    pickupsGrid.Columns["VehicleInfo"].HeaderText = "Vehicle";
                    pickupsGrid.Columns["VehicleInfo"].DisplayIndex = 1;
                }
                if (pickupsGrid.Columns["ActualPickupDate"] != null) pickupsGrid.Columns["ActualPickupDate"].HeaderText = "Pickup Date";
                if (pickupsGrid.Columns["ActualReturnDate"] != null) pickupsGrid.Columns["ActualReturnDate"].HeaderText = "Return Date";
                if (pickupsGrid.Columns["StartMileage"] != null) pickupsGrid.Columns["StartMileage"].HeaderText = "Start Mileage";

                pickupsGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading active rentals: " + ex.Message);
            }
        }
    }
}



