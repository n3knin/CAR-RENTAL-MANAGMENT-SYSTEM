using System.Windows.Forms;
using System;
using System.IO;
using System.Drawing;
using System.Linq;
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
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            bool isFullAccess = _user.GetRoleName() == "Admin" || _user.GetRoleName() == "Manager";

            vehiclesButton.Visible = isFullAccess;
            reportsButton.Visible = isFullAccess;
            dashboardButton.Visible = isFullAccess;
            
            usersButton.Visible = _user.GetRoleName() == "Admin";
            
            customersButton.Visible = true;
            reservationsButton.Visible = true;
            pickupsButton.Visible = true;
            returnsButton.Visible = true;
            billingButton.Visible = true;
            
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
            
            if (button == dashboardButton) 
            {
                sectionTitleLabel.Visible = false;
                cardsTableLayout.Visible = false;
                placeholderLabel.Visible = false;
                
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
                
                contentPanel.Location = new Point(23, 190);
                contentPanel.Size = new Size(mainPanel.Width - 46, mainPanel.Height - 210);
            }
            
            sectionTitleLabel.Text = button.Text;
            UpdateKPIs(button.Text);

            // Access Control per Section
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
            else if (button == reportsButton && _user.CanViewReports())
            {
                ShowSection(new ReportsView());
            }
            else if (button == usersButton && _user.CanManageUsers())
            {
                ShowSection(new UsersView());
            }
        }

        private void UpdateKPIs(string section)
        {
            try {
                if (section == "Reports" || section == "Reports and Analytics")
                {
                    // Expand and configure cards layout for 5 metrics
                    cardsTableLayout.ColumnCount = 5;
                    cardsTableLayout.ColumnStyles.Clear();
                    for (int i = 0; i < 5; i++)
                        cardsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));

                    // Standardize Date Range: Current Month
                    DateTime start = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                    DateTime end = DateTime.Now;
                    int daysInMonth = (int)(end.Date - start.Date).TotalDays + 1;
                    if (daysInMonth <= 0) daysInMonth = 1;

                    int fleetCount = _vehicleManager.CountAll();

                    // 1. Fleet Utilization
                    int rentalDays = _rentalManager.GetTotalRentalDays(start, end);
                    double utilization = fleetCount > 0 ? (double)rentalDays / (fleetCount * daysInMonth) * 100 : 0;
                    cardFleetLabel.Text = "Fleet Utilization";
                    cardFleetValue.Text = utilization.ToString("N1") + "%";
                    cardFleetValue.ForeColor = Color.FromArgb(0, 102, 204);

                    // 2. Revenue Per Vehicle
                    decimal rpv = _billingManager.GetRevenuePerVehicle(start, end);
                    cardActiveRentalsLabel.Text = "Rev/Vehicle/Day";
                    cardActiveRentalsValue.Text = "₱" + rpv.ToString("N1");
                    cardActiveRentalsValue.ForeColor = Color.MediumSeaGreen;

                    // 3. Avg Rental Duration
                    double avgDuration = _rentalManager.GetAverageRentalDuration(start, end);
                    cardRevenueLabel.Text = "Avg. Duration";
                    cardRevenueValue.Text = avgDuration.ToString("N1") + "d";
                    cardRevenueValue.ForeColor = Color.FromArgb(255, 128, 0);

                    // 4. Damage Rate
                    Panel cardDamage = cardsTableLayout.Controls.Find("cardDamage", false).FirstOrDefault() as Panel;
                    if (cardDamage == null)
                    {
                        cardDamage = CreateKPICard("cardDamage", Color.Red);
                        cardsTableLayout.Controls.Add(cardDamage, 3, 0);
                    }
                    UpdateKPICard(cardDamage, "Damage Rate", _rentalManager.GetDamageIncidentRate(start, end).ToString("N1") + "%");
                    cardDamage.Visible = true;

                    // 5. Customer Retention
                    Panel cardRetention = cardsTableLayout.Controls.Find("cardRetention", false).FirstOrDefault() as Panel;
                    if (cardRetention == null)
                    {
                        cardRetention = CreateKPICard("cardRetention", Color.SlateBlue);
                        cardsTableLayout.Controls.Add(cardRetention, 4, 0);
                    }
                    UpdateKPICard(cardRetention, "Customer Retention", _customerManager.GetRetentionRate().ToString("N1") + "%");
                    cardRetention.Visible = true;
                }
                else 
                {
                    // Reset to 3 columns for other sections
                    cardsTableLayout.ColumnCount = 3;
                    cardsTableLayout.ColumnStyles.Clear();
                    cardsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                    cardsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
                    cardsTableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));

                    Panel cardDamage = cardsTableLayout.Controls.Find("cardDamage", false).FirstOrDefault() as Panel;
                    if (cardDamage != null) cardDamage.Visible = false;

                    Panel cardRetention = cardsTableLayout.Controls.Find("cardRetention", false).FirstOrDefault() as Panel;
                    if (cardRetention != null) cardRetention.Visible = false;

                    // Restore original colors
                    cardFleetValue.ForeColor = Color.FromArgb(29, 161, 242);
                    cardActiveRentalsValue.ForeColor = Color.FromArgb(37, 177, 124);
                    cardRevenueValue.ForeColor = Color.FromArgb(245, 152, 39);
                    
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
                        cardActiveRentalsValue.Text = _rentalManager.CountPendingReturns().ToString(); // Placeholder
                        cardRevenueLabel.Text = "Processed";
                        cardRevenueValue.Text = _rentalManager.CountCompleted().ToString(); 
                    }
                    else if (section == "Billing" || section == "Billing and Payments")
                    {
                        cardFleetLabel.Text = "Transactions Today";
                        cardFleetValue.Text = _billingManager.CountToday().ToString();
                        cardActiveRentalsLabel.Text = "Invoiced Today";
                        cardActiveRentalsValue.Text = "₱" + _billingManager.SumInvoicedToday().ToString("N0");
                        cardRevenueLabel.Text = "Paid Today";
                        cardRevenueValue.Text = _billingManager.CountToday().ToString();
                    }
                    else if (section == "Users")
                    {
                        var userRepo = new RentalApp.Data.Repositories.UserRepository();
                        cardFleetLabel.Text = "Total Users";
                        cardFleetValue.Text = userRepo.GetAll().Count.ToString();
                        
                        cardActiveRentalsLabel.Text = "Admins";
                        cardActiveRentalsValue.Text = userRepo.GetByRole("Admin").Count.ToString();

                        cardRevenueLabel.Text = "Rental Agents";
                        cardRevenueValue.Text = userRepo.GetByRole("RentalAgent").Count.ToString();
                    }
                    else
                    {
                        cardFleetLabel.Text = "Total Fleet";
                        cardFleetValue.Text = _vehicleManager.GetAllVehicles().Count.ToString();
                        cardActiveRentalsLabel.Text = "Active Rentals";
                        cardActiveRentalsValue.Text = _rentalManager.CountActive().ToString();
                        cardRevenueLabel.Text = "Total Revenue";
                        cardRevenueValue.Text = "₱" + _billingManager.SumRevenue().ToString("N0");
                    }

                }
            }
            catch (Exception)
            {
                cardFleetValue.Text = "-";
            }
        }

        private Panel CreateKPICard(string name, Color valueColor)
        {
            Panel panel = new Panel { Name = name, BackColor = Color.White, Dock = DockStyle.Fill, Margin = new Padding(10), Padding = new Padding(10) };
            Label lblValue = new Label { Name = "val", Text = "0", AutoSize = true, Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold), ForeColor = valueColor, Location = new Point(13, 34) };
            Label lblTitle = new Label { Name = "lbl", Text = "Metric", AutoSize = true, Font = new Font("Segoe UI", 9F), ForeColor = Color.DimGray, Location = new Point(15, 12) };
            panel.Controls.Add(lblValue);
            panel.Controls.Add(lblTitle);
            return panel;
        }

        private void UpdateKPICard(Panel card, string title, string value)
        {
            Label lblTitle = card.Controls.Find("lbl", false).FirstOrDefault() as Label;
            Label lblValue = card.Controls.Find("val", false).FirstOrDefault() as Label;
            if (lblTitle != null) lblTitle.Text = title;
            if (lblValue != null) lblValue.Text = value;
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


