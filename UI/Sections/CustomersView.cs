using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Services;
using RentalApp.Models.Core;

namespace RentalApp.UI.Sections
{
    public partial class CustomersView : UserControl
    {
        private CustomerManager _customerManager;

        public CustomersView()
        {
            InitializeComponent();
            InitializeDragAndDrop();
            _customerManager = new CustomerManager();

            LoadCustomers();
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += CustomersView_DragEnter;
            this.DragDrop += CustomersView_DragDrop;
        }

        private void CustomersView_DragEnter(object sender, DragEventArgs e)
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

        private void CustomersView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                HandleDroppedFiles(files);
            }
        }

        private void LoadCustomers()
        {
            try
            {
                var customers = _customerManager.GetAllCustomers();
                
                // Fix: Assign data to bindingSource FIRST
                var bindingSource = new BindingSource();
                bindingSource.DataSource = customers;
                
                customersGrid.AutoGenerateColumns = true;
                customersGrid.DataSource = bindingSource;
                customersGrid.Columns["DriverLicenseNumber"].Visible = false;
                customersGrid.Columns["LicenseIssueDate"].Visible = false;
                customersGrid.Columns["LicenseExpiryDate"].Visible = false;
                customersGrid.Columns["IsBlacklisted"].Visible = false;
                customersGrid.Columns["Id"].Visible = false;
                customersGrid.Columns["Address"].Visible = false;
                customersGrid.Columns["LicenseState"].Visible = false;
                customersGrid.Columns["LastName"].Visible = false;
                customersGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }

        }
        private void customersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void HandleDroppedFiles(string[] files)
        {
            string fileList = string.Join("\n", files);
            MessageBox.Show($"Files dropped on Customers View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void customersGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            var selectedCustomer = (Customer)customersGrid.CurrentRow.DataBoundItem;


            using (var detailsForm = new Popups.CustomerDetailsForm(selectedCustomer))
            {
                detailsForm.ShowDialog();
            }
        }
    }
}



