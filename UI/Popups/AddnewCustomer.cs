using System;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
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
            comboBox1.Items.Add("Davao del Norte");
            comboBox1.Items.Add("Davao del Sur");
            comboBox1.Items.Add("Davao Oriental");
            comboBox1.Items.Add("Davao City");
            comboBox1.Items.Add("Davao de Oro");
            comboBox1.Items.Add("Davao Occidental");
            comboBox1.SelectedIndex = 0;

            // Restrict input to numbers only while typing
            txtdlnumber.KeyPress += NumericOnly_KeyPress;
            phone.KeyPress += NumericOnly_KeyPress;
        }

        private void NumericOnly_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow digits and control keys (like backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
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
      
        private void cmbcustomertype_SelectedIndexChanged(object sender, EventArgs e) { }
        private void AddnewCustomer_Load(object sender, EventArgs e) { }

        private void addbt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtfirstname.Text) || string.IsNullOrWhiteSpace(textxtlastname.Text))
            {
                MessageBox.Show("First and Last Name are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtdlnumber.Text) || txtdlnumber.Text.Length != 11 || !System.Text.RegularExpressions.Regex.IsMatch(txtdlnumber.Text, @"^\d+$"))
            {
                MessageBox.Show("Driver's License Number is required, must be exactly 11 digits, and contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtdateissue.Value > dtdateexpire.Value)
            {
                MessageBox.Show("License issue date cannot be after the expiration date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtdateexpire.Value <= DateTime.Now)
            {
                MessageBox.Show("License has expired! Cannot register customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_customerManager.RecordExistedbyEmail(textBox1.Text))
            {
                MessageBox.Show("Email already exists! Cannot register customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_customerManager.RecordExistedbyDriverLicenseNumber(txtdlnumber.Text))
            {
                MessageBox.Show("Driver's License Number already exists! Cannot register customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_customerManager.RecordExistedbyPhone(phone.Text))
            {
                MessageBox.Show("Phone already exists! Cannot register customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(_customerManager.RecordExistedbyName(txtfirstname.Text, textxtlastname.Text))
            {
                MessageBox.Show("Name already exists! Cannot register customer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(phone.Text) || phone.Text.Length != 11 || !System.Text.RegularExpressions.Regex.IsMatch(phone.Text, @"^\d+$"))
            {
                MessageBox.Show("Phone number is required, must be exactly 11 digits, and contain only numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!new EmailAddressAttribute().IsValid(textBox1.Text))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                LicenseState = comboBox1.SelectedItem?.ToString() ?? "",

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dadf_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
