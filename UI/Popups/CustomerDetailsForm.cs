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
        private ReservationManager _reservationManager; // To fetch history

        // Constructor REQUIRES a customer object
        public CustomerDetailsForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            _customerManager = new CustomerManager();
            _reservationManager = new ReservationManager();

            LoadCustomerData();
        }

        private void LoadCustomerData()
        {
            // Set Window Title
            this.Text = "Customer Details";

            // Populate Labels
            txtname.Text = _customer.FirstName;
            txtlastname.Text = _customer.LastName;
            txtaddress.Text = _customer.Address; // Assuming Address property exists
            
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
                customergrid.Columns["CustomerID"].Visible = false;
                customergrid.Columns["VehicleID"].Visible = false;
                customergrid.Columns["ID"].Visible = false;
                customergrid.Columns["StartDate"].Visible = false;
                customergrid.Columns["EndDate"].Visible = false;
                customergrid.Columns["Status"].Visible = false;
                customergrid.Columns["CreatedAt"].Visible = false;
                
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
