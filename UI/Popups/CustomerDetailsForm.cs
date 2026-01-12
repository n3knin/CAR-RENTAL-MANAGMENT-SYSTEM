using System;
using System.Windows.Forms;
using RentalApp.Models.Core;
using RentalApp.Models.Services;

namespace RentalApp.UI.Popups
{
    public partial class CustomerDetailsForm : Form
    {
        private Customer _customer;
        private CustomerManager _customerManager;
        private RentalManager _rentalManager;
        private ReservationManager _reservationManager;

        // Constructor REQUIRES a customer object
        public CustomerDetailsForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            _customerManager = new CustomerManager();
            _reservationManager = new ReservationManager();
            _rentalManager = new RentalManager();
            customergrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            // Set Window Title
            this.Text = "Customer Details";

            // Populate Labels
            txtname.Text = _customer.FirstName;
            txtlastname.Text = _customer.LastName;
            txtaddress.Text = _customer.Address; 
            
            // Driver's License Info
            dlnumber.Text = _customer.DriverLicenseNumber;
            // Format dates nicely
            // Handle Nullable Date safely
            if (_customer.LicenseIssueDate.HasValue)
            {
               dlissuedate.Text = _customer.LicenseIssueDate.Value.ToShortDateString();
            }
            else
            {
                dlissuedate.Text = "N/A";
            }
            
            dlexpiredate.Text = _customer.LicenseExpiryDate.ToShortDateString();

            // Load History Grid
            LoadHistory();
        }

        private void LoadHistory()
        {
            try 
            {
                var history = _reservationManager.GetCustomerHistory(_customer.Id);
                customergrid.DataSource = history;
                customergrid.ReadOnly = true;
                if (customergrid.Columns["CustomerID"] != null) customergrid.Columns["CustomerID"].Visible = false;
                if (customergrid.Columns["VehicleID"] != null) customergrid.Columns["VehicleID"].Visible = false;
                if (customergrid.Columns["ID"] != null) customergrid.Columns["ID"].Visible = false;
                if (customergrid.Columns["StartDate"] != null) customergrid.Columns["StartDate"].Visible = false;
                if (customergrid.Columns["EndDate"] != null) customergrid.Columns["EndDate"].Visible = false;
                if (customergrid.Columns["Status"] != null) customergrid.Columns["Status"].Visible = false;
                if (customergrid.Columns["CreatedAt"] != null) customergrid.Columns["CreatedAt"].Visible = false;
                if (customergrid.Columns["Customer"] != null) customergrid.Columns["Customer"].Visible = false;
                if (customergrid.Columns["Vehicle"] != null) customergrid.Columns["Vehicle"].Visible = false;
                if (customergrid.Columns["CustomerId"] != null) customergrid.Columns["CustomerId"].Visible = false;
                if (customergrid.Columns["VehicleId"] != null) customergrid.Columns["VehicleId"].Visible = false;
                if (customergrid.Columns["Id"] != null) customergrid.Columns["Id"].Visible = false;

                if (customergrid.Columns["CustomerName"] != null) customergrid.Columns["CustomerName"].HeaderText = "Customer Name";
                if (customergrid.Columns["VehicleInfo"] != null) customergrid.Columns["VehicleInfo"].HeaderText = "Rented Vehicles";
                
            }
            catch (Exception ex)
            {
                // If history load fails, just ignore or log
                Console.WriteLine(ex.Message); 
            }
        }

        private void btclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btblacklist_Click(object sender, EventArgs e)
        {
            // Check for active rentals first
            if (_rentalManager.HasActiveRental(_customer.Id))
            {
                MessageBox.Show($"Cannot blacklist customer. This customer currently has an ACTIVE RENTAL.\nPlease complete the return before blacklisting.", 
                    "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to BLACKLIST {_customer.FirstName} {_customer.LastName}?", 
                "Confirm Blacklist", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try {
                    _customerManager.Blacklist(_customer.Id);
                    MessageBox.Show("User has been blacklisted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error blacklisting: " + ex.Message);
                }
            }
        }

        // Empty event handlers to satisfy Designer (if they were auto-generated)
        private void Form1_Load(object sender, EventArgs e) { }
        private void materialLabel1_Click(object sender, EventArgs e) { }
        private void txtlastname_Click(object sender, EventArgs e) { }
        private void txt_Click(object sender, EventArgs e) { }
        private void txtaddress_Click(object sender, EventArgs e) { }
        private void materialLabel1_Click_1(object sender, EventArgs e) { }
        private void materialLabel2_Click(object sender, EventArgs e) { }
        private void materialLabel3_Click(object sender, EventArgs e) { }
        private void dlnumber_Click(object sender, EventArgs e) { }
        private void dlissuedate_Click(object sender, EventArgs e) { }
        private void dlexpiredate_Click(object sender, EventArgs e) { }
        private void materialLabel4_Click(object sender, EventArgs e) { }
        private void customergrid_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        
        // Fix for Designer Error:
        private void customergrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e) { }
    }
}
        