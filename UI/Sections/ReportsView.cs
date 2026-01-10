using System.Windows.Forms;
using System;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;

namespace RentalApp.UI.Sections
{
    public partial class ReportsView : UserControl
    {
        private Models.Services.BillingManager _billingManager;

        public ReportsView()
        {
            InitializeComponent();
            _billingManager = new Models.Services.BillingManager();
            InitializeDragAndDrop();
            InitializeCharts();
            InitializeGrid();
            RefreshReportData(); // Load data immediately on startup
        }

        private void InitializeGrid()
        {
            reportsGrid.Columns.Clear();
            reportsGrid.AutoGenerateColumns = false;

            reportsGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "IssueDate", HeaderText = "Date", DefaultCellStyle = new DataGridViewCellStyle { Format = "MM/dd/yyyy" } });
            reportsGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "CustomerName", HeaderText = "Customer" });
            reportsGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "VehicleInfo", HeaderText = "Vehicle" });
            reportsGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "DurationDays", HeaderText = "Days" });
            reportsGrid.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TotalAmount", HeaderText = "Amount (₱)", DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" } });
        }

        private void InitializeCharts()
        {
            LoadWeeklySalesChart();
            LoadCategoryUsageChart();
        }

        private void LoadWeeklySalesChart()
        {
            revenueChart.Series.Clear();
            revenueChart.Titles.Clear();
            revenueChart.Titles.Add("Weekly Sales Trend (Sun-Sat)");
            revenueChart.Palette = ChartColorPalette.SeaGreen;

            Series series = new Series("Revenue")
            {
                ChartType = SeriesChartType.Column,
                XValueType = ChartValueType.String
            };

            var data = _billingManager.GetWeeklySalesTrend();
            string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            for (int i = 0; i < 7; i++)
            {
                series.Points.AddXY(days[i], data[i]);
            }

            revenueChart.Series.Add(series);
            revenueChart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            revenueChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;
        }

        private void LoadCategoryUsageChart()
        {
            statusChart.Series.Clear();
            statusChart.Titles.Clear();
            statusChart.Titles.Add("Vehicle Usage (This Month)");
            statusChart.Palette = ChartColorPalette.BrightPastel;

            Series series = new Series("Usage")
            {
                ChartType = SeriesChartType.Doughnut,
                IsValueShownAsLabel = true
            };

            var data = _billingManager.GetCategoryUsageCurrentMonth();
            foreach (var item in data)
            {
                series.Points.AddXY(item.Key, item.Value);
            }

            statusChart.Series.Add(series);
        }

        private void RefreshReportData()
        {
            DateTime start = rangeFromPicker.Value;
            DateTime end = rangeToPicker.Value;

            var data = _billingManager.GetReportData(start, end);
            reportsGrid.DataSource = null;
            reportsGrid.DataSource = data;
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += ReportsView_DragEnter;
            this.DragDrop += ReportsView_DragDrop;
        }

        private void ReportsView_DragEnter(object sender, DragEventArgs e)
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

        private void ReportsView_DragDrop(object sender, DragEventArgs e)
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
            MessageBox.Show($"Files dropped on Reports View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void statusChart_Click(object sender, EventArgs e) { }
        private void revenueChart_Click(object sender, EventArgs e) { }
        private void metricComboBox_SelectedIndexChanged(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rangeToPicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshReportData();
        }

        private void rangeFromPicker_ValueChanged(object sender, EventArgs e)
        {
            RefreshReportData();
        }

        private void reportsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



