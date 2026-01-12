using System;
using System.Windows.Forms;
using MaterialSkin.Controls;
using RentalApp.Data.Repositories;  
using RentalApp.Models.Users;
using RentalApp.Models.Core;
namespace RentalApp.UI
{

    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text;


            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username and password are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            try {
                UserRepository userRepository = new UserRepository();
                User user = userRepository.GetByUsername(username);

                if (user != null && user.VerifyPassword(password))
                {
                    if (user.Status != "Active")
                    {
                         MessageBox.Show("Your account is inactive. Please contact your administrator.", "Account Inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                         return;
                    }

                    Session.CurrentUserId = user.Id;
                    Session.CurrentUsername = user.Username;
                    Session.CurrentUserRole = user.GetRoleName();

                    MessageBox.Show("Login successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var dashboard = new MainDashboardForm(user);
                    dashboard.StartPosition = FormStartPosition.CenterScreen;
                    dashboard.Show();
                    Hide();
                }else 
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rightPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}



