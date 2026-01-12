using System;
using System.Drawing;
using System.Windows.Forms;
using RentalApp.Data.Repositories;
using RentalApp.Models.Users;
using MaterialSkin.Controls;

namespace RentalApp.UI.Popups
{
    public partial class AddUserSimple : Form
    {
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private ComboBox cmbRole;
        private Button btnSave;
        private Button btnCancel;
        private UserRepository _userRepository;

        public AddUserSimple()
        {
            InitializeComponent();
            if(!this.DesignMode)
            {
                _userRepository = new UserRepository();
            }
        }

        private void InitializeComponent()
        {
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(20, 70);
            this.txtFirstName.Size = new System.Drawing.Size(340, 30);
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(20, 130);
            this.txtLastName.Size = new System.Drawing.Size(340, 30);
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(20, 190);
            this.txtUsername.Size = new System.Drawing.Size(340, 30);
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.BackColor = System.Drawing.Color.WhiteSmoke;

            // 
            // cmbRole
            // 
            this.cmbRole.Location = new System.Drawing.Point(20, 250);
            this.cmbRole.Size = new System.Drawing.Size(340, 30);
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbRole.Items.AddRange(new object[] { "RentalAgent", "Manager", "Admin" });
            this.cmbRole.SelectedIndex = 0;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(20, 310);
            this.txtPassword.Size = new System.Drawing.Size(340, 30);
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.UseSystemPasswordChar = true;

            // 
            // btnSave
            // 
            this.btnSave.Text = "SAVE USER";
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(63, 81, 181);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.Size = new System.Drawing.Size(120, 40);
            this.btnSave.Location = new System.Drawing.Point(20, 370);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);

            // 
            // btnCancel
            // 
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.Location = new System.Drawing.Point(240, 370);
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);

            // Labels (Inline creation)
            System.Windows.Forms.Label lblHeader = new System.Windows.Forms.Label();
            lblHeader.Text = "Create New User";
            lblHeader.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            lblHeader.ForeColor = System.Drawing.Color.FromArgb(63, 81, 181);
            lblHeader.AutoSize = true;
            lblHeader.Location = new System.Drawing.Point(20, 20);

            System.Windows.Forms.Label lblFirstName = new System.Windows.Forms.Label();
            lblFirstName.Text = "First Name";
            lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblFirstName.ForeColor = System.Drawing.Color.Gray;
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new System.Drawing.Point(20, 50);

            System.Windows.Forms.Label lblLastName = new System.Windows.Forms.Label();
            lblLastName.Text = "Last Name";
            lblLastName.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblLastName.ForeColor = System.Drawing.Color.Gray;
            lblLastName.AutoSize = true;
            lblLastName.Location = new System.Drawing.Point(20, 110);

            System.Windows.Forms.Label lblUsername = new System.Windows.Forms.Label();
            lblUsername.Text = "Username";
            lblUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblUsername.ForeColor = System.Drawing.Color.Gray;
            lblUsername.AutoSize = true;
            lblUsername.Location = new System.Drawing.Point(20, 170);

            System.Windows.Forms.Label lblRole = new System.Windows.Forms.Label();
            lblRole.Text = "Role";
            lblRole.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblRole.ForeColor = System.Drawing.Color.Gray;
            lblRole.AutoSize = true;
            lblRole.Location = new System.Drawing.Point(20, 230);

            System.Windows.Forms.Label lblPassword = new System.Windows.Forms.Label();
            lblPassword.Text = "Password";
            lblPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            lblPassword.ForeColor = System.Drawing.Color.Gray;
            lblPassword.AutoSize = true;
            lblPassword.Location = new System.Drawing.Point(20, 290);

            // 
            // AddUserSimple
            // 
            this.ClientSize = new System.Drawing.Size(400, 450);
            this.Controls.Add(lblHeader);
            this.Controls.Add(lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(lblLastName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(lblUsername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(lblRole);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Text = "Add New User";
            this.BackColor = System.Drawing.Color.White;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        // Removed helper methods as they are no longer used

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || 
                string.IsNullOrWhiteSpace(txtLastName.Text) || 
                string.IsNullOrWhiteSpace(txtUsername.Text) || 
                string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_userRepository.UsernameExists(txtUsername.Text))
            {
                MessageBox.Show("Username is already taken.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                User newUser = null;
                string role = cmbRole.SelectedItem.ToString();
                int id = 0; // Auto-increment

                if (role == "Admin")
                    newUser = new Admin(id, txtFirstName.Text, txtLastName.Text, txtUsername.Text);
                else if (role == "Manager")
                    newUser = new Manager(id, txtFirstName.Text, txtLastName.Text, txtUsername.Text);
                else
                    newUser = new RentalAgent(id, txtFirstName.Text, txtLastName.Text, txtUsername.Text);

                newUser.SetPassword(txtPassword.Text);
                
                // Status is set to Active by default in constructor

                _userRepository.Add(newUser);

                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating user: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
