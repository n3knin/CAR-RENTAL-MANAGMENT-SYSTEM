using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.UI.Sections;

namespace RentalApp.UI
{
    public partial class MainDashboardForm : Form
    {
        private UserControl currentView;

        public MainDashboardForm()
        {
            InitializeComponent();
            ShowSection(new VehiclesView());
            InitializeDragAndDrop();
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += MainDashboardForm_DragEnter;
            this.DragDrop += MainDashboardForm_DragDrop;
        }

        private void MainDashboardForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void MainDashboardForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                HandleDroppedFiles(files);
            }
        }

        private void HandleDroppedFiles(string[] files)
        {
            string fileList = string.Join("\n", files);
            MessageBox.Show($"Files dropped on Main Dashboard:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void navButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            sectionTitleLabel.Text = button.Text;

            if (button == vehiclesButton)
            {
                ShowSection(new VehiclesView());
            }
            else if (button == customersButton)
            {
                ShowSection(new CustomersView());
            }
            else if (button == reservationsButton)
            {
                ShowSection(new ReservationsView());
            }
            else if (button == pickupsButton)
            {
                ShowSection(new PickupsView());
            }
            else if (button == returnsButton)
            {
                ShowSection(new ReturnsView());
            }
            else if (button == billingButton)
            {
                ShowSection(new BillingView());
            }
            else if (button == reportsButton)
            {
                ShowSection(new ReportsView());
            }
        }

        private void ShowSection(UserControl view)
        {
            if (currentView != null)
            {
                contentPanel.Controls.Remove(currentView);
                currentView.Dispose();
            }

            currentView = view;
            currentView.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(currentView);
        }
    }
}


