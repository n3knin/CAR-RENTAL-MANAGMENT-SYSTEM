using System;
using System.Windows.Forms;
using MaterialSkin.Controls;

namespace RentalApp.UI
{

    public partial class LoginForm : MaterialForm
    {
        public LoginForm()
        {
            InitializeComponent();
            MessageBox.Show("LoginForm loaded!", "Test");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // UI-only: no real authentication, just open the dashboard
            var dashboard = new MainDashboardForm();
            dashboard.StartPosition = FormStartPosition.CenterScreen;
            dashboard.Show();
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}



