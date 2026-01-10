using System;
using System.Drawing;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using RentalApp.Models.Core;

using RentalApp.Models.Services;

namespace RentalApp.UI.Sections
{
    public partial class DashboardView : UserControl
    {
        private VehicleManager _vehicleManager;
        private RentalManager _rentalManager;
        private ReservationManager _reservationManager;
        private BillingManager _billingManager;

        public DashboardView()
        {
            InitializeComponent();
            _vehicleManager = new VehicleManager();
            _rentalManager = new RentalManager();
            _reservationManager = new ReservationManager();
            _billingManager = new BillingManager();
            
            InitializeCards();
            InitializeRecentActivity();
            InitializeQuickActions();
        }

        private void InitializeCards()
        {
            // Fetch real data
            int todayPickups = _rentalManager.CountTodayPickups();
            int todayReturns = _rentalManager.CountPendingReturns();
            int fleetAvailable = _vehicleManager.CountAvailable();
            int activeRentals = _rentalManager.CountActive();
            int pendingReservations = _reservationManager.CountPending();
            decimal revenueToday = _billingManager.SumInvoicedToday();

            AddCard("Today's Returns", todayReturns.ToString(), Color.FromArgb(21, 32, 43));
            AddCard("Fleet Available", fleetAvailable.ToString(), Color.FromArgb(21, 32, 43));
            AddCard("Active Rentals", activeRentals.ToString(), Color.FromArgb(21, 32, 43));
            AddCard("Pending Reservations", pendingReservations.ToString(), Color.FromArgb(21, 32, 43));
            AddCard("Revenue Today", "₱" + (revenueToday / 1000m).ToString("N1") + "k", Color.LimeGreen);
            
            //AddQuickActions();
        }

        private void AddCard(string title, string value, Color valueColor)
        {
            Panel p = new Panel();
            p.BackColor = Color.White;
            p.Size = new Size(250, 90);
            p.Margin = new Padding(0, 0, 15, 15);
            
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 8F);
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Location = new Point(20, 15);
            lblTitle.AutoSize = true;
            
            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblValue.ForeColor = valueColor;
            lblValue.Location = new Point(20, 35);
            lblValue.AutoSize = true;
            
            p.Controls.Add(lblTitle);
            p.Controls.Add(lblValue);
            
            p.Resize += (s, e) => {
               // Center if needed
            };
            
            cardsPanel.Controls.Add(p);
        }

        private void InitializeRecentActivity()
        {
            recentActivityPanel.Controls.Clear();
            
            // Get recent rentals (mock or real)
            var rentals = _rentalManager.GetAllRentals();
            var recentRentals = rentals.OrderByDescending(r => r.ActualPickupDate).Take(10).ToList();

            if (recentRentals.Count == 0)
            {
                Label diff = new Label();
                diff.Text = "No recent activity found.";
                diff.AutoSize = true;
                diff.ForeColor = Color.DimGray;
                diff.Padding = new Padding(10);
                recentActivityPanel.Controls.Add(diff);
                return;
            }

            foreach (var rental in recentRentals)
            {
                Panel row = new Panel();
                row.Size = new Size(recentActivityPanel.Width - 25, 60);
                row.BackColor = Color.White;
                row.Margin = new Padding(0, 0, 0, 5);

                // Status Strip
                Panel statusStrip = new Panel();
                statusStrip.Size = new Size(5, 60);
                statusStrip.Dock = DockStyle.Left;
                statusStrip.BackColor = GetStatusColor(rental.Status);
                row.Controls.Add(statusStrip);

                // Customer Name
                Label lblName = new Label();
                lblName.Text = rental.CustomerName ?? "Unknown Customer";
                lblName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
                lblName.Location = new Point(20, 10);
                lblName.AutoSize = true;
                row.Controls.Add(lblName);

                // Vehicle Info
                Label lblVehicle = new Label();
                lblVehicle.Text = rental.VehicleInfo ?? "Unknown Vehicle";
                lblVehicle.Font = new Font("Segoe UI", 9F);
                lblVehicle.ForeColor = Color.DimGray;
                lblVehicle.Location = new Point(20, 32);
                lblVehicle.AutoSize = true;
                row.Controls.Add(lblVehicle);

                // Date
                Label lblDate = new Label();
                lblDate.Text = rental.ActualPickupDate.ToShortDateString();
                lblDate.Font = new Font("Segoe UI", 9F);
                lblDate.ForeColor = Color.Gray;
                lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                lblDate.Location = new Point(row.Width - 100, 10);
                row.Controls.Add(lblDate);

                // Status Text
                Label lblStatus = new Label();
                lblStatus.Text = rental.Status.ToString().ToUpper();
                lblStatus.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
                lblStatus.ForeColor = GetStatusColor(rental.Status);
                lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                lblStatus.Location = new Point(row.Width - 100, 32);
                row.Controls.Add(lblStatus);

                recentActivityPanel.Controls.Add(row);
            }
        }

        private Color GetStatusColor(RentalStatus status)
        {
            switch (status)
            {
                case RentalStatus.Active: return Color.FromArgb(29, 161, 242); // Blue
                case RentalStatus.Completed: return Color.LimeGreen;
                case RentalStatus.Overdue: return Color.OrangeRed;
                default: return Color.Gray;
            }
        }

        private void InitializeQuickActions()
        {
            quickActionsPanel.Controls.Clear();
            
            // Container for buttons to keep them tidy
            FlowLayoutPanel flow = new FlowLayoutPanel();
            flow.Dock = DockStyle.Fill;
            flow.FlowDirection = FlowDirection.TopDown;
            flow.Padding = new Padding(10);
            
            flow.Controls.Add(CreateQuickActionButton("New Rental Reservation", Color.LimeGreen));
            flow.Controls.Add(CreateQuickActionButton("Register New Customer", Color.FromArgb(29, 161, 242)));
            flow.Controls.Add(CreateQuickActionButton("Add Vehicle to Fleet", Color.FromArgb(21, 32, 43)));
            flow.Controls.Add(CreateQuickActionButton("Process Return", Color.Orange));

            quickActionsPanel.Controls.Add(flow);
        }

        private Button CreateQuickActionButton(string text, Color color)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(300, 45);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Margin = new Padding(0, 0, 0, 15);
            btn.Cursor = Cursors.Hand;
            return btn;
        }

        private void cardsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
