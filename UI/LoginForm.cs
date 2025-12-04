using System;
using System.Windows.Forms;

namespace RentalApp.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
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
    }
}



