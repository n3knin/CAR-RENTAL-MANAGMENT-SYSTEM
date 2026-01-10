namespace RentalApp.UI.Sections
{
    partial class ReportsView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.headerLabel = new System.Windows.Forms.Label();
            this.rangeFromPicker = new System.Windows.Forms.DateTimePicker();
            this.rangeToPicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.chartPlaceholderPanel = new System.Windows.Forms.Panel();
            this.statusChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.revenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportsGrid = new System.Windows.Forms.DataGridView();
            this.chartPlaceholderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(17, 6);
            this.headerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(130, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Reports & Analytics";
            // 
            // rangeFromPicker
            // 
            this.rangeFromPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rangeFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rangeFromPicker.Location = new System.Drawing.Point(20, 32);
            this.rangeFromPicker.Margin = new System.Windows.Forms.Padding(2);
            this.rangeFromPicker.Name = "rangeFromPicker";
            this.rangeFromPicker.Size = new System.Drawing.Size(90, 23);
            this.rangeFromPicker.TabIndex = 2;
            this.rangeFromPicker.ValueChanged += new System.EventHandler(this.rangeFromPicker_ValueChanged);
            // 
            // rangeToPicker
            // 
            this.rangeToPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rangeToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rangeToPicker.Location = new System.Drawing.Point(140, 32);
            this.rangeToPicker.Margin = new System.Windows.Forms.Padding(2);
            this.rangeToPicker.Name = "rangeToPicker";
            this.rangeToPicker.Size = new System.Drawing.Size(90, 23);
            this.rangeToPicker.TabIndex = 3;
            this.rangeToPicker.ValueChanged += new System.EventHandler(this.rangeToPicker_ValueChanged);
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toLabel.ForeColor = System.Drawing.Color.DimGray;
            this.toLabel.Location = new System.Drawing.Point(120, 35);
            this.toLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(18, 15);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "to";
            // 
            // chartPlaceholderPanel
            // 
            this.chartPlaceholderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPlaceholderPanel.BackColor = System.Drawing.Color.White;
            this.chartPlaceholderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartPlaceholderPanel.Controls.Add(this.statusChart);
            this.chartPlaceholderPanel.Controls.Add(this.revenueChart);
            this.chartPlaceholderPanel.Location = new System.Drawing.Point(20, 64);
            this.chartPlaceholderPanel.Margin = new System.Windows.Forms.Padding(2);
            this.chartPlaceholderPanel.Name = "chartPlaceholderPanel";
            this.chartPlaceholderPanel.Size = new System.Drawing.Size(623, 177);
            this.chartPlaceholderPanel.TabIndex = 6;
            // 
            // statusChart
            // 
            chartArea1.Name = "ChartArea1";
            this.statusChart.ChartAreas.Add(chartArea1);
            this.statusChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.statusChart.Legends.Add(legend1);
            this.statusChart.Location = new System.Drawing.Point(381, 0);
            this.statusChart.Margin = new System.Windows.Forms.Padding(2);
            this.statusChart.Name = "statusChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.statusChart.Series.Add(series1);
            this.statusChart.Size = new System.Drawing.Size(240, 175);
            this.statusChart.TabIndex = 1;
            this.statusChart.Text = "statusChart";
            this.statusChart.Click += new System.EventHandler(this.statusChart_Click);
            // 
            // revenueChart
            // 
            chartArea2.Name = "ChartArea1";
            this.revenueChart.ChartAreas.Add(chartArea2);
            this.revenueChart.Dock = System.Windows.Forms.DockStyle.Left;
            legend2.Name = "Legend1";
            this.revenueChart.Legends.Add(legend2);
            this.revenueChart.Location = new System.Drawing.Point(0, 0);
            this.revenueChart.Margin = new System.Windows.Forms.Padding(2);
            this.revenueChart.Name = "revenueChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.revenueChart.Series.Add(series2);
            this.revenueChart.Size = new System.Drawing.Size(381, 175);
            this.revenueChart.TabIndex = 0;
            this.revenueChart.Text = "revenueChart";
            this.revenueChart.Click += new System.EventHandler(this.revenueChart_Click);
            // 
            // reportsGrid
            // 
            this.reportsGrid.AllowUserToAddRows = false;
            this.reportsGrid.AllowUserToDeleteRows = false;
            this.reportsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportsGrid.BackgroundColor = System.Drawing.Color.White;
            this.reportsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGrid.Location = new System.Drawing.Point(19, 244);
            this.reportsGrid.Margin = new System.Windows.Forms.Padding(2);
            this.reportsGrid.Name = "reportsGrid";
            this.reportsGrid.ReadOnly = true;
            this.reportsGrid.RowHeadersVisible = false;
            this.reportsGrid.RowHeadersWidth = 51;
            this.reportsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.reportsGrid.Size = new System.Drawing.Size(623, 83);
            this.reportsGrid.TabIndex = 9;
            this.reportsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reportsGrid_CellContentClick);
            // 
            // ReportsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.reportsGrid);
            this.Controls.Add(this.chartPlaceholderPanel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.rangeToPicker);
            this.Controls.Add(this.rangeFromPicker);
            this.Controls.Add(this.headerLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReportsView";
            this.Size = new System.Drawing.Size(660, 329);
            this.chartPlaceholderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statusChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.revenueChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DateTimePicker rangeFromPicker;
        private System.Windows.Forms.DateTimePicker rangeToPicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Panel chartPlaceholderPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart revenueChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart statusChart;
        private System.Windows.Forms.DataGridView reportsGrid;
    }
}



