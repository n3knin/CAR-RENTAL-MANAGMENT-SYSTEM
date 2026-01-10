using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Services;
using RentalApp.Models.Core;

namespace RentalApp.UI.Sections
{
    public partial class ReturnsView : UserControl
    {
        private RentalManager _rentalManager;
        private VehicleManager _vehicleManager;
        public ReturnsView()
        {
            InitializeComponent();
            InitializeDragAndDrop();
            
            // Make columns stretch to fill width
            returnsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            _rentalManager = new RentalManager();
            _vehicleManager = new VehicleManager();
            LoadRentalData();
        }
        private void LoadRentalData()
        {
            try
            {
                var rentals = _rentalManager.GetActiveRentals();

                var bindingSource = new BindingSource();
                bindingSource.DataSource = rentals;

                returnsGrid.DataSource = null;
                returnsGrid.DataSource = bindingSource;
                returnsGrid.ReadOnly = true;

                
                if (returnsGrid.Columns["Id"] != null) returnsGrid.Columns["Id"].Visible = false;
                if (returnsGrid.Columns["VehicleId"] != null) returnsGrid.Columns["VehicleId"].Visible = false;
                if (returnsGrid.Columns["CustomerId"] != null) returnsGrid.Columns["CustomerId"].Visible = false;
                if (returnsGrid.Columns["Customer"] != null) returnsGrid.Columns["Customer"].Visible = false;
                if (returnsGrid.Columns["Vehicle"] != null) returnsGrid.Columns["Vehicle"].Visible = false;
                if (returnsGrid.Columns["RentalAgent"] != null) returnsGrid.Columns["RentalAgent"].Visible = false;
                if(returnsGrid.Columns["ReservationId"] != null) returnsGrid.Columns["ReservationId"].Visible = false;
                if (returnsGrid.Columns["RentalAgentId"] != null) returnsGrid.Columns["RentalAgentId"].Visible = false;
               
    
                
                if (returnsGrid.Columns["CustomerName"] != null) 
                {
                    returnsGrid.Columns["CustomerName"].HeaderText = "Customer";
                    returnsGrid.Columns["CustomerName"].DisplayIndex = 0;
                }
                if (returnsGrid.Columns["VehicleInfo"] != null)
                {
                    returnsGrid.Columns["VehicleInfo"].HeaderText = "Vehicle";
                    returnsGrid.Columns["VehicleInfo"].DisplayIndex = 1;
                }
                if (returnsGrid.Columns["ActualPickupDate"] != null) returnsGrid.Columns["ActualPickupDate"].HeaderText = "Pickup Date";
                if (returnsGrid.Columns["ExpectedReturnDate"] != null) returnsGrid.Columns["ExpectedReturnDate"].HeaderText = "Expected Return Date";
                if (returnsGrid.Columns["ActualReturnDate"] != null) returnsGrid.Columns["ActualReturnDate"].HeaderText = "Return Date";
                if (returnsGrid.Columns["RentalAgentName"] != null) returnsGrid.Columns["RentalAgentName"].HeaderText = "Agent";
                if (returnsGrid.Columns["StartMileage"] != null) returnsGrid.Columns["StartMileage"].HeaderText = "Start Mileage";
                if (returnsGrid.Columns["EndMileage"] != null) returnsGrid.Columns["EndMileage"].HeaderText = "End Mileage";

                returnsGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rental data: " + ex.Message);
            }
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += ReturnsView_DragEnter;
            this.DragDrop += ReturnsView_DragDrop;
        }

        private void ReturnsView_DragEnter(object sender, DragEventArgs e)
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

        private void ReturnsView_DragDrop(object sender, DragEventArgs e)
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
            MessageBox.Show($"Files dropped on Returns View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void returnsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void returnsGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            
            try
            {
                var selectedRental = (Rental)returnsGrid.Rows[e.RowIndex].DataBoundItem;
                
                if (selectedRental == null)
                {
                    MessageBox.Show("No rental selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                
                using (var form = new Popups.InspectionForm())
                {
                    form.LoadData(selectedRental);
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        LoadRentalData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening inspection form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startReturnButton_Click(object sender, EventArgs e)
        {

        }
    }
}



