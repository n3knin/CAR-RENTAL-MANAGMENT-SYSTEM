using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Services;
using RentalApp.Models.Vehicles;
using RentalApp.Models.Core;
using RentalApp.UI.Popups;
namespace RentalApp.UI.Sections
{
    public partial class PickupsView : UserControl
    {
        private RentalManager _rentalManager;

        public PickupsView()
        {
            InitializeComponent();
            
            // Make columns stretch to fill width
            pickupsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            _rentalManager = new RentalManager();
            
            // Hook up date range filters
            dtpFROM.ValueChanged += (s, e) => LoadRentalData();
            dtpTO.ValueChanged += (s, e) => LoadRentalData();

            LoadRentalData();
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
                    LoadRentalData(); 
                }
            }
        }

        private void pickupsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadRentalData()   
        {
            try
            {
                DateTime start = dtpFROM.Value;
                DateTime end = dtpTO.Value;

                if (start.Date > end.Date)
                {
                    MessageBox.Show("Start date cannot be after end date.", "Invalid Date Range", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Fetch rentals from DB for the range
                var rentalList = _rentalManager.GetByDateRange(start, end);

                // Bind to Grid using BindingSource
                var bindingSource = new BindingSource();
                bindingSource.DataSource = rentalList;

                pickupsGrid.AutoGenerateColumns = true;
                pickupsGrid.DataSource = null;
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
                if (pickupsGrid.Columns["ActualReturnDate"] != null) pickupsGrid.Columns["ActualReturnDate"].Visible = false;
                if (pickupsGrid.Columns["RentalAgentName"] != null) pickupsGrid.Columns["RentalAgentName"].HeaderText = "Agent";
                if (pickupsGrid.Columns["RentalAgentName"] != null) pickupsGrid.Columns["RentalAgentName"].DisplayIndex = 4;
                if (pickupsGrid.Columns["ExpectedReturnDate"] != null) pickupsGrid.Columns["ExpectedReturnDate"].HeaderText = " Expected Return Date";
                if (pickupsGrid.Columns["ExpectedReturnDate"] != null) pickupsGrid.Columns["ExpectedReturnDate"].DisplayIndex = 5;

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
                if (pickupsGrid.Columns["ActualPickupDate"] != null) pickupsGrid.Columns["ActualPickupDate"].DisplayIndex = 6;
                if (pickupsGrid.Columns["StartMileage"] != null) pickupsGrid.Columns["StartMileage"].HeaderText = "Start Mileage";
                if (pickupsGrid.Columns["StartMileage"] != null) pickupsGrid.Columns["StartMileage"].DisplayIndex = 7;

                pickupsGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading active rentals: " + ex.Message);
            }
        }

        private void viewChecklistButton_Click(object sender, EventArgs e)
        {
            using (var form = new Popups.WalkInForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadRentalData(); 
                }
            }
        }

        private void dtpFROM_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpTO_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}



