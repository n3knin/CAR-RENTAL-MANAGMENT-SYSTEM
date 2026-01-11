using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.DataVisualization.Charting;
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
            InitializeAnalytics();
        }

        private void InitializeCards()
        {
            cardsPanel.Controls.Clear();
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
            
            var btnRes = CreateQuickActionButton("New Rental Reservation", Color.LimeGreen);
            btnRes.Click += QuickAction_Click;
            flow.Controls.Add(btnRes);

            var btnCust = CreateQuickActionButton("Register New Customer", Color.FromArgb(29, 161, 242));
            btnCust.Click += QuickAction_Click;
            flow.Controls.Add(btnCust);

            var btnVeh = CreateQuickActionButton("Add Vehicle to Fleet", Color.FromArgb(21, 32, 43));
            btnVeh.Click += QuickAction_Click;
            flow.Controls.Add(btnVeh);

            var btnRet = CreateQuickActionButton("Process Return", Color.Orange);
            btnRet.Click += QuickAction_Click;
            flow.Controls.Add(btnRet);

            quickActionsPanel.Controls.Add(flow);
        }

        private void QuickAction_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null) return;

            switch (btn.Text)
            {
                case "New Rental Reservation":
                    using (var form = new Popups.ReservationForm())
                    {
                        form.ShowDialog();
                    }
                    break;
                case "Register New Customer":
                    using (var form = new Popups.AddnewCustomer())
                    {
                        form.ShowDialog();
                    }
                    break;
                case "Add Vehicle to Fleet":
                    if(Session.CurrentUserRole == "Admin")
                    {
                        using (var form = new Popups.AddVehicleForm())
                        {
                            form.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("You do not have permission to add vehicles to the fleet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                case "Process Return":
                    MessageBox.Show("Please navigate to the 'Returns' section to select an active rental for processing.", 
                                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            
            InitializeCards();
        }      

        private Button CreateQuickActionButton(string text, Color color)
        {
            Button btn = new Button();
            btn.Text = text;
            btn.Size = new Size(240, 45);
            btn.BackColor = color;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.Margin = new Padding(0, 0, 0, 15);
            btn.Cursor = Cursors.Hand;
            return btn;
        }

        private void InitializeAnalytics()
        {
            analyticsPanel.Controls.Clear();

            TableLayoutPanel mainLayout = new TableLayoutPanel();
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            Chart revenueChart = new Chart();
            revenueChart.Dock = DockStyle.Fill;
            revenueChart.BackColor = Color.White;
            
            ChartArea revArea = new ChartArea("RevenueArea");
            revArea.AxisX.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
            revArea.AxisY.MajorGrid.LineColor = Color.FromArgb(240, 240, 240);
            revArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            revArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 8F);
            revenueChart.ChartAreas.Add(revArea);

            Series revSeries = new Series("Revenue")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String,
                Palette = ChartColorPalette.SeaGreen
            };

            var revData = _billingManager.GetMonthlyRevenue(6);
            foreach (var entry in revData)
            {
                revSeries.Points.AddXY(entry.Key, entry.Value);
            }

            revenueChart.Series.Add(revSeries);
            revenueChart.Titles.Add(new Title("Monthly Revenue Trend", Docking.Top, new Font("Segoe UI", 10F, FontStyle.Bold), Color.Black));
            mainLayout.Controls.Add(revenueChart, 0, 0);

            Chart fleetChart = new Chart();
            fleetChart.Dock = DockStyle.Fill;
            fleetChart.BackColor = Color.White;

            ChartArea fleetArea = new ChartArea("FleetArea");
            fleetChart.ChartAreas.Add(fleetArea);

            Series fleetSeries = new Series("Fleet")
            {
                ChartType = SeriesChartType.Doughnut,
                XValueType = ChartValueType.String,
            };
            
            // Set custom colors for a premium look
            fleetSeries.Palette = ChartColorPalette.Pastel;
            fleetSeries["PieLabelStyle"] = "Outside";
            fleetSeries["DoughnutRadius"] = "50";

            var fleetData = _vehicleManager.GetFleetDistribution();
            foreach (var entry in fleetData)
            {
                 // Only add if there are vehicles in that category to keep it clean
                 if(entry.Value > 0)
                    fleetSeries.Points.AddXY(entry.Key, entry.Value);
            }

            fleetChart.Series.Add(fleetSeries);
            fleetChart.Titles.Add(new Title("Available Fleet Distribution", Docking.Top, new Font("Segoe UI", 10F, FontStyle.Bold), Color.Black));
            
            Legend legend = new Legend("FleetLegend");
            legend.Docking = Docking.Bottom;
            legend.Font = new Font("Segoe UI", 7F);
            fleetChart.Legends.Add(legend);

            mainLayout.Controls.Add(fleetChart, 1, 0);

            analyticsPanel.Controls.Add(mainLayout);
        }

        private void cardsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void analyticsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void quickActionsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
