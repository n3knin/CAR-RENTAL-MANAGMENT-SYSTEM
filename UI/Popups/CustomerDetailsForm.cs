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

        // ... (existing methods remain unchanged)

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
