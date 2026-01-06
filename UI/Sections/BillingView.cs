using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Core;
using RentalApp.Models.Services;
using RentalApp.Models.Vehicles;
using RentalApp.UI.Popups;


namespace RentalApp.UI.Sections
{
    public partial class BillingView : UserControl
    {
        private BillingManager _billingManager;
        private VehicleManager _vehicleManager;
        private CustomerManager _customerManager;
        private RentalManager _rentalManager;

        public BillingView()
        {
            InitializeComponent();
            
            _billingManager = new BillingManager();
            _vehicleManager = new VehicleManager();
            _customerManager = new CustomerManager();
            _rentalManager = new RentalManager();
            
            billingGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            InitializeDragAndDrop();
            LoadData();
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += BillingView_DragEnter;
            this.DragDrop += BillingView_DragDrop;
        }

        private void LoadData()
        {
            try
            {
                var rentals = _rentalManager.GetAllRentals();

                var bindingSource = new BindingSource();
                bindingSource.DataSource = rentals;

                billingGrid.DataSource = bindingSource;
                billingGrid.ReadOnly = true;

                
                if (billingGrid.Columns["Id"] != null) billingGrid.Columns["Id"].Visible = false;
                if (billingGrid.Columns["VehicleId"] != null) billingGrid.Columns["VehicleId"].Visible = false;
                if (billingGrid.Columns["CustomerId"] != null) billingGrid.Columns["CustomerId"].Visible = false;
                if (billingGrid.Columns["Customer"] != null) billingGrid.Columns["Customer"].Visible = false;
                if (billingGrid.Columns["Vehicle"] != null) billingGrid.Columns["Vehicle"].Visible = false;
                if (billingGrid.Columns["RentalAgent"] != null) billingGrid.Columns["RentalAgent"].Visible = false;
                if(billingGrid.Columns["ReservationId"] != null) billingGrid.Columns["ReservationId"].Visible = false;
                if (billingGrid.Columns["RentalAgentId"] != null) billingGrid.Columns["RentalAgentId"].Visible = false;
               
    
                
                if (billingGrid.Columns["CustomerName"] != null) 
                {
                    billingGrid.Columns["CustomerName"].HeaderText = "Customer";
                    billingGrid.Columns["CustomerName"].DisplayIndex = 0;
                }
                if (billingGrid.Columns["VehicleInfo"] != null)
                {
                    billingGrid.Columns["VehicleInfo"].HeaderText = "Vehicle";
                    billingGrid.Columns["VehicleInfo"].DisplayIndex = 1;
                }
                if (billingGrid.Columns["ActualPickupDate"] != null) billingGrid.Columns["ActualPickupDate"].HeaderText = "Pickup Date";
                if (billingGrid.Columns["ExpectedReturnDate"] != null) billingGrid.Columns["ExpectedReturnDate"].HeaderText = "Expected Return Date";
                if (billingGrid.Columns["ActualReturnDate"] != null) billingGrid.Columns["ActualReturnDate"].HeaderText = "Return Date";
                if (billingGrid.Columns["RentalAgentName"] != null) billingGrid.Columns["RentalAgentName"].HeaderText = "Agent";
                if (billingGrid.Columns["StartMileage"] != null) billingGrid.Columns["StartMileage"].HeaderText = "Start Mileage";
                if (billingGrid.Columns["EndMileage"] != null) billingGrid.Columns["EndMileage"].HeaderText = "End Mileage";

                billingGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading rental data: " + ex.Message);
            }
        }

        private void billingGrid_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (billingGrid.CurrentRow != null && billingGrid.CurrentRow.Index >= 0)
                {
                    var rental = (Rental)billingGrid.CurrentRow.DataBoundItem;
                    if (rental != null)
                    {
                        using (var invoiceForm = new InvoiceForm(rental))
                        {
                            if (invoiceForm.ShowDialog() == DialogResult.OK)
                            {
                                LoadData(); 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Invoice Form: " + ex.Message);
            }
        }

        private void BillingView_DragEnter(object sender, DragEventArgs e)
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

        private void BillingView_DragDrop(object sender, DragEventArgs e)
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
            MessageBox.Show($"Files dropped on Billing View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void billingGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



