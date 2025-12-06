using System;
using System.Windows.Forms;

namespace RentalApp
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new UI.LoginForm());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Application Error:\n\n" + ex.Message + "\n\n" + ex.StackTrace,
                    "Fatal Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}