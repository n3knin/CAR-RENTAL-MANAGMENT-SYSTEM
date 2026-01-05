using System.Windows.Forms;
using System;
using System.IO;
using System.Drawing;
using RentalApp.UI.Sections;
using RentalApp.Models.Services;


namespace RentalApp.UI
{
    public partial class MainDashboardForm : Form
    {
        private UserControl currentView;

        public MainDashboardForm()
        {
            InitializeComponent();
            // Default to Dashboard
            sectionTitleLabel.Visible = false;
            cardsTableLayout.Visible = false;
            placeholderLabel.Visible = false;
            
            contentPanel.Location = new Point(23, 20);
            contentPanel.Size = new Size(1497, 806);
            
            ShowSection(new DashboardView());
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

        private VehicleManager _vehicleManager = new VehicleManager();
        private CustomerManager _customerManager = new CustomerManager();
        private ReservationManager _reservationManager = new ReservationManager();
        // private RentalManager _rentalManager = new RentalManager(); // Uncomment when ready

        private void navButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            // Dashboard View Logic
            if (button.Name == "dashboardButton") // Use name as I can't access private field easily without recompiling designer or checking field name match
            {
                sectionTitleLabel.Visible = false;
                cardsTableLayout.Visible = false;
                placeholderLabel.Visible = false;
                
                // Move content panel up
                contentPanel.Location = new Point(23, 20);
                contentPanel.Size = new Size(1497, 806);

                ShowSection(new DashboardView());
                return;
            }
            else
            {
                // Restore default view elements for other sections
                sectionTitleLabel.Visible = true;
                cardsTableLayout.Visible = true;
                placeholderLabel.Visible = true;
                
                // Restore content panel position
                contentPanel.Location = new Point(23, 190);
                contentPanel.Size = new Size(1497, 636);
            }

            sectionTitleLabel.Text = button.Text;
            UpdateKPIs(button.Text); // Update Cards dynamically!

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

        private void UpdateKPIs(string section)
        {
            try {
                if (section == "Vehicles")
                {
                    cardFleetLabel.Text = "Total Vehicles";
                    cardFleetValue.Text = _vehicleManager.GetAllVehicles().Count.ToString();

                    cardActiveRentalsLabel.Text = "Available Vehicles";
                    // Assuming you will implement CountAvailable later, for now just a placeholder logic or Total - Rented
                    cardActiveRentalsValue.Text = _vehicleManager.CountAvailable().ToString(); 

                    cardRevenueLabel.Text = "Rented";
                    cardRevenueValue.Text = _vehicleManager.CountRented().ToString();
                }
                else if (section == "Customers")
                {
                    cardFleetLabel.Text = "Total Customers";
                    cardFleetValue.Text = _customerManager.GetAllCustomers().Count.ToString();

                    cardActiveRentalsLabel.Text = "New Customers";
                    cardActiveRentalsValue.Text = _customerManager.CountNewCustomers().ToString(); 

                    cardRevenueLabel.Text = "Blacklisted";
                    cardRevenueValue.Text = _customerManager.CountBlacklisted().ToString(); 
                }
                else if (section == "Reservations")
                {
                    cardFleetLabel.Text = "Total Reservations";
                    cardFleetValue.Text = _reservationManager.GetAllReservations().Count.ToString();

                    cardActiveRentalsLabel.Text = "Pending";
                    cardActiveRentalsValue.Text = _reservationManager.CountPending().ToString();

                    cardRevenueLabel.Text = "Confirmed";
                    cardRevenueValue.Text = _reservationManager.CountConfirmed().ToString();
                }
                else if (section == "Pickups")
                {
                    cardFleetLabel.Text = "Today's Pickups";
                    cardFleetValue.Text = "5"; // Placeholder
                    cardActiveRentalsLabel.Text = "Pending";
                    cardActiveRentalsValue.Text = "2"; // Placeholder
                    cardRevenueLabel.Text = "Completed";
                    cardRevenueValue.Text = "3"; // Placeholder
                }
                else if (section == "Returns")
                {
                    cardFleetLabel.Text = "Pending Returns";
                    cardFleetValue.Text = "3"; // Placeholder
                    cardActiveRentalsLabel.Text = "Inspections Due";
                    cardActiveRentalsValue.Text = "1"; // Placeholder
                    cardRevenueLabel.Text = "Processed";
                    cardRevenueValue.Text = "2"; // Placeholder
                }
                else if (section == "Billing")
                {
                    cardFleetLabel.Text = "Outstanding";
                    cardFleetValue.Text = "$4,320"; // Placeholder
                    cardActiveRentalsLabel.Text = "Invoiced Today";
                    cardActiveRentalsValue.Text = "$1,250"; // Placeholder
                    cardRevenueLabel.Text = "Paid Today";
                    cardRevenueValue.Text = "$850"; // Placeholder
                }
                else if (section == "Reports")
                {
                    cardFleetLabel.Text = "Reports Generated";
                    cardFleetValue.Text = "12"; // Placeholder
                    cardActiveRentalsLabel.Text = "Exports";
                    cardActiveRentalsValue.Text = "5"; // Placeholder
                    cardRevenueLabel.Text = "Data Points";
                    cardRevenueValue.Text = "15k"; // Placeholder
                }
                else 
                {
                    // Default / Dashboard
                    cardFleetLabel.Text = "Total Fleet";
                    cardFleetValue.Text = "128";
                    cardActiveRentalsLabel.Text = "Active Rentals";
                    cardActiveRentalsValue.Text = "27";
                    cardRevenueLabel.Text = "Revenue";
                    cardRevenueValue.Text = "$12,450";
                }
            }
            catch (Exception ex)
            {
                // Fallback if DB fails
                cardFleetValue.Text = "-";
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

        private void sidebarPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardActiveRentals_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainDashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}


