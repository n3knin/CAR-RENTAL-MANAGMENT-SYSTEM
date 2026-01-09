using System.Windows.Forms;
using System;
using System.IO;
using System.Drawing;
using RentalApp.UI.Sections;
using RentalApp.Models.Services;
using RentalApp.Models.Users;


namespace RentalApp.UI
{
    public partial class MainDashboardForm : Form
    {
        private UserControl currentView;
        private User _user;
        public MainDashboardForm(User user)
        {
            InitializeComponent();
            _user = user;
            // Default to Dashboard
            sectionTitleLabel.Visible = false;
            cardsTableLayout.Visible = false;
            placeholderLabel.Visible = false;
            userRoleLabel.Text = $"Signed in as: {user.GetRoleName()}";
            
            contentPanel.AutoScroll = true; // Enable scrolling for large content
            contentPanel.Location = new Point(23, 20);
            contentPanel.Size = new Size(mainPanel.Width - 46, mainPanel.Height - 40);

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
        private RentalManager _rentalManager = new RentalManager();
        private BillingManager _billingManager = new BillingManager();

        private void navButton_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            // Dashboard View Logic
            // Dashboard View Logic
            if (button.Name == "dashboardButton") // Use name as I can't access private field easily without recompiling designer or checking field name match
            {
                sectionTitleLabel.Visible = false;
                cardsTableLayout.Visible = false;
                placeholderLabel.Visible = false;
                
                // Move content panel up
                contentPanel.Location = new Point(23, 20);
                contentPanel.Size = new Size(mainPanel.Width - 46, mainPanel.Height - 40);

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
                contentPanel.Size = new Size(mainPanel.Width - 46, mainPanel.Height - 210);
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
                    cardFleetValue.Text = _reservationManager.CountTotal().ToString();

                    cardActiveRentalsLabel.Text = "Pending";
                    cardActiveRentalsValue.Text = _reservationManager.CountPending().ToString();

                    cardRevenueLabel.Text = "Confirmed";
                    cardRevenueValue.Text = _reservationManager.CountConfirmed().ToString();
                }
                else if (section == "Pickups")
                {
                    cardFleetLabel.Text = "Today's Pickups";
                    cardFleetValue.Text = _rentalManager.CountTodayPickups().ToString();
                    cardActiveRentalsLabel.Text = "Pending Reservations";
                    cardActiveRentalsValue.Text = _reservationManager.CountPending().ToString();
                    cardRevenueLabel.Text = "Active Rentals";
                    cardRevenueValue.Text = _rentalManager.CountActive().ToString();
                }
                else if (section == "Returns")
                {
                    cardFleetLabel.Text = "Pending Returns";
                    cardFleetValue.Text = _rentalManager.CountPendingReturns().ToString();
                    cardActiveRentalsLabel.Text = "Inspections Due";
                    cardActiveRentalsValue.Text = _rentalManager.CountPendingReturns().ToString();; // Placeholder
                    cardRevenueLabel.Text = "Processed";
                    cardRevenueValue.Text = _rentalManager.CountCompleted().ToString(); 
                }
                else if (section == "Billing" || section == "Billing and Payments")
                {
                    cardFleetLabel.Text = "Transactions Today";
                    cardFleetValue.Text = _billingManager.CountToday().ToString();
                    cardActiveRentalsLabel.Text = "Invoiced Today";
                    cardActiveRentalsValue.Text = _billingManager.SumInvoicedToday().ToString();
                    cardRevenueLabel.Text = "Paid Today";
                    cardRevenueValue.Text = _billingManager.CountToday().ToString();
                }
                else if (section == "Reports" || section == "Reports and Analytics")
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
                    cardFleetValue.Text = _vehicleManager.GetAllVehicles().Count.ToString();
                    cardActiveRentalsLabel.Text = "Active Rentals";
                    cardActiveRentalsValue.Text = _rentalManager.CountActive().ToString();
                    cardRevenueLabel.Text = "Revenue";
                    cardRevenueValue.Text = _billingManager.SumRevenue().ToString();
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

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cardFleet_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


