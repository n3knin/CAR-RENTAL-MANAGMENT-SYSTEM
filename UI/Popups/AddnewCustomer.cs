using System;
using System.Windows.Forms;
using RentalApp.Models.Services;
using RentalApp.Models.Core;

namespace RentalApp.UI.Popups
{
    public partial class AddnewCustomer : Form
    {
        private CustomerManager _customerManager;

        public AddnewCustomer()
        {
            InitializeComponent();
            _customerManager = new CustomerManager();
            LoadCustomerTypes();
        }

        private void LoadCustomerTypes()
        {
            // Populate Dropdown with Enum Values
            cmbcustomertype.DataSource = Enum.GetValues(typeof(CustomerType));
            cmbcustomertype.SelectedIndex = 0; // Default to Individual
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event Handlers that were auto-generated in Designer can remain empty/default
        private void lblCustomer_Click(object sender, EventArgs e) { }
        private void txtfirstname_TextChanged(object sender, EventArgs e) { }
        private void textxtlastname_TextChanged(object sender, EventArgs e) { }
        private void txtdlnumber_TextChanged(object sender, EventArgs e) { }
        private void dtdateissue_ValueChanged(object sender, EventArgs e) { }
        private void dtdateexpire_ValueChanged(object sender, EventArgs e) { }
        private void txtaddress_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void phone_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void txtlicensestate_TextChanged(object sender, EventArgs e) { }
        private void cmbcustomertype_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AddnewCustomer_Load(object sender, EventArgs e) { }

        private void addbt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfirstname.Text) || string.IsNullOrWhiteSpace(textxtlastname.Text))
            {
                MessageBox.Show("First and Last Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdlnumber.Text))
            {
                MessageBox.Show("Driver's License Number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtdateexpire.Value <= DateTime.Now)
            {
                MessageBox.Show("License has expired! Cannot register customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2. Create Object with ALL properties mapped + User's Variable Names
            var newCustomer = new Customer
            {
                FirstName = txtfirstname.Text.Trim(),
                LastName = textxtlastname.Text.Trim(),
                Address = txtaddress.Text.Trim(),
                Email = textBox1.Text.Trim(), // textBox1 is Email
                Phone = phone.Text.Trim(),
                Type = (CustomerType)cmbcustomertype.SelectedItem,
                EmergencyContact = textBox2.Text.Trim(), // textBox2 is Emergency Contact
                
                DriverLicenseNumber = txtdlnumber.Text.Trim(),
                LicenseIssueDate = dtdateissue.Value,
                LicenseExpiryDate = dtdateexpire.Value,
                LicenseState = txtlicensestate.Text.Trim(),

                CreatedAt = DateTime.Now,
                IsBlacklisted = false,
            
                DateOfBirth = DateTime.Now.AddYears(-21) 
            };

            try
            {
                // 3. Save to DB
                _customerManager.AddCustomer(newCustomer);
                
                MessageBox.Show("Customer Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK; // Signal success to parent form
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
