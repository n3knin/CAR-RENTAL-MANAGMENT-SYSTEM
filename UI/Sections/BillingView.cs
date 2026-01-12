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
            overviewgrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
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

                var paidInvoices = _billingManager.GetAllPaid();

                var invoiceBindingSource = new BindingSource();
                invoiceBindingSource.DataSource = paidInvoices;

                overviewgrid.DataSource = invoiceBindingSource;

                if(overviewgrid.Columns["Id"] != null) overviewgrid.Columns["Id"].Visible = false;
                if(overviewgrid.Columns["RentalId"] != null) overviewgrid.Columns["RentalId"].Visible = false;
                if(overviewgrid.Columns["Rental"] != null) overviewgrid.Columns["Rental"].Visible = false;
                if(overviewgrid.Columns["IssueDate"] != null) overviewgrid.Columns["IssueDate"].HeaderText = "Issue Date";
                if(overviewgrid.Columns["CustomerName"] != null) overviewgrid.Columns["CustomerName"].HeaderText = "Customer";
                if(overviewgrid.Columns["CustomerName"] != null) overviewgrid.Columns["CustomerName"].DisplayIndex = 1;
                if(overviewgrid.Columns["VehicleInfo"] != null) overviewgrid.Columns["VehicleInfo"].HeaderText = "Vehicle";
                if(overviewgrid.Columns["VehicleInfo"] != null) overviewgrid.Columns["VehicleInfo"].DisplayIndex = 2;
                if(overviewgrid.Columns["RentalAgentName"] != null) overviewgrid.Columns["RentalAgentName"].HeaderText = "Agent";
                if(overviewgrid.Columns["RentalAgentName"] != null) overviewgrid.Columns["RentalAgentName"].DisplayIndex = 3;

                if(overviewgrid.Columns["LateFee"] != null) overviewgrid.Columns["LateFee"].HeaderText = "Late Fee";
                if(overviewgrid.Columns["LateFee"] != null) overviewgrid.Columns["LateFee"].DisplayIndex = 4;
                if(overviewgrid.Columns["DamageFee"] != null) overviewgrid.Columns["DamageFee"].HeaderText = "Damage Fee";
                if(overviewgrid.Columns["DamageFee"] != null) overviewgrid.Columns["DamageFee"].DisplayIndex = 5;
                if(overviewgrid.Columns["FuelCharge"] != null) overviewgrid.Columns["FuelCharge"].HeaderText = "Fuel Charge";
                if(overviewgrid.Columns["FuelCharge"] != null) overviewgrid.Columns["FuelCharge"].DisplayIndex = 6;
                if(overviewgrid.Columns["CleaningFee"] != null) overviewgrid.Columns["CleaningFee"].HeaderText = "Cleaning Fee";
                if(overviewgrid.Columns["CleaningFee"] != null) overviewgrid.Columns["CleaningFee"].DisplayIndex = 7;
                if(overviewgrid.Columns["TotalAmount"] != null) overviewgrid.Columns["TotalAmount"].HeaderText = "Total Amount";
                if(overviewgrid.Columns["TotalAmount"] != null) overviewgrid.Columns["TotalAmount"].DisplayIndex = 10;
                if(overviewgrid.Columns["RentalCharge"] != null) overviewgrid.Columns["RentalCharge"].HeaderText = "Rental Charge";
                if(overviewgrid.Columns["RentalCharge"] != null) overviewgrid.Columns["RentalCharge"].DisplayIndex = 9;
                if(overviewgrid.Columns["AppliedRentalCharge"] != null) overviewgrid.Columns["AppliedRentalCharge"].HeaderText = "Rate Type";
                if(overviewgrid.Columns["AppliedRentalCharge"] != null) overviewgrid.Columns["AppliedRentalCharge"].DisplayIndex = 8;
                if(overviewgrid.Columns["IsPaid"] != null) overviewgrid.Columns["IsPaid"].Visible = false;
                
                overviewgrid.ReadOnly = true;
                overviewgrid.Refresh();
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
                        var existingInvoice = _billingManager.GetInvoiceByRentalId(rental.Id);
                        if (existingInvoice != null)
                        {
                            MessageBox.Show("Cannot process payment twice. An invoice already exists for this rental.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

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

        private void overviewgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



