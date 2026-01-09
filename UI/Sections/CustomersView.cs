using System.Windows.Forms;
using System;
using System.IO;
using System.Collections.Generic;
using RentalApp.Models.Services;
using RentalApp.Models.Core;

namespace RentalApp.UI.Sections
{
    public partial class CustomersView : UserControl
    {
        private CustomerManager _customerManager;

        private List<Customer> _allCustomers;
        public CustomersView()
        {
            InitializeComponent();
            InitializeDragAndDrop();
            
            // Make columns stretch to fill width
            customersGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            filterComboBox.SelectedIndex = 0;
            filterComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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
                _allCustomers = _customerManager.GetAllCustomers();
                UpdateGrid(_allCustomers);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customers: " + ex.Message);
            }
        }

        private void UpdateGrid(List<Customer> list)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = list;

            customersGrid.AutoGenerateColumns = true;
            customersGrid.DataSource = bindingSource;
            customersGrid.ReadOnly = true;

            if(customersGrid.Columns["Id"] != null) customersGrid.Columns["Id"].Visible = false;
            if(customersGrid.Columns["DriverLicenseNumber"] != null) customersGrid.Columns["DriverLicenseNumber"].Visible = false;
            if(customersGrid.Columns["LicenseIssueDate"] != null) customersGrid.Columns["LicenseIssueDate"].Visible = false;
            if(customersGrid.Columns["LicenseExpiryDate"] != null) customersGrid.Columns["LicenseExpiryDate"].Visible = false;
            if(customersGrid.Columns["IsBlacklisted"] != null) customersGrid.Columns["IsBlacklisted"].Visible = false;
            if(customersGrid.Columns["Address"] != null) customersGrid.Columns["Address"].Visible = false;
            if(customersGrid.Columns["LicenseState"] != null) customersGrid.Columns["LicenseState"].Visible = false;
            if(customersGrid.Columns["FirstName"] != null) customersGrid.Columns["FirstName"].Visible = false;
            if(customersGrid.Columns["LastName"] != null) customersGrid.Columns["LastName"].Visible = false;
            if(customersGrid.Columns["CreatedAt"] != null) customersGrid.Columns["CreatedAt"].Visible = false;

            // Set Headers
            if (customersGrid.Columns["FullName"] != null) customersGrid.Columns["FullName"].HeaderText = "Customer's Name";
            if (customersGrid.Columns["Email"] != null) customersGrid.Columns["Email"].HeaderText = "Email";
            if (customersGrid.Columns["DateOfBirth"] != null) customersGrid.Columns["DateOfBirth"].HeaderText = "Date of Birth";
            if (customersGrid.Columns["CurrentVehicleInfo"] != null) customersGrid.Columns["CurrentVehicleInfo"].HeaderText = "Current Vehicle";
            if (customersGrid.Columns["ActiveReservationId"] != null) customersGrid.Columns["ActiveReservationId"].HeaderText = "Reservation ID";

            customersGrid.Refresh();
        }

        private void filterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_allCustomers == null) return;

            string filter = filterComboBox.SelectedItem?.ToString();
            List<Customer> filteredList;

            switch (filter)
            {
                case "Corporate clients":
                    filteredList = _allCustomers.FindAll(c => c.Type == CustomerType.Corporate);
                    break;
                case "Blacklisted":
                    filteredList = _allCustomers.FindAll(c => c.IsBlacklisted);
                    break;
                case "Frequent renters":
                    // Placeholder: filter for those with a current vehicle for now
                    filteredList = _allCustomers.FindAll(c => !string.IsNullOrEmpty(c.CurrentVehicleInfo));
                    break;
                case "All customers":
                default:
                    filteredList = _allCustomers;
                    break;
            }

            UpdateGrid(filteredList);

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

        private void CustomersView_Load(object sender, EventArgs e)
        {

        }
    }
}



