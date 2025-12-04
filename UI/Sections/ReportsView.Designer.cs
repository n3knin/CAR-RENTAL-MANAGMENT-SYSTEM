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
            this.headerLabel = new System.Windows.Forms.Label();
            this.rangeFromPicker = new System.Windows.Forms.DateTimePicker();
            this.rangeToPicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.metricComboBox = new System.Windows.Forms.ComboBox();
            this.metricLabel = new System.Windows.Forms.Label();
            this.chartPlaceholderPanel = new System.Windows.Forms.Panel();
            this.chartPlaceholderLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.chartPlaceholderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(15, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(137, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Reports & Analytics";
            // 
            // rangeFromPicker
            // 
            this.rangeFromPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rangeFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rangeFromPicker.Location = new System.Drawing.Point(80, 45);
            this.rangeFromPicker.Name = "rangeFromPicker";
            this.rangeFromPicker.Size = new System.Drawing.Size(110, 23);
            this.rangeFromPicker.TabIndex = 2;
            // 
            // rangeToPicker
            // 
            this.rangeToPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rangeToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rangeToPicker.Location = new System.Drawing.Point(220, 45);
            this.rangeToPicker.Name = "rangeToPicker";
            this.rangeToPicker.Size = new System.Drawing.Size(110, 23);
            this.rangeToPicker.TabIndex = 3;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toLabel.ForeColor = System.Drawing.Color.DimGray;
            this.toLabel.Location = new System.Drawing.Point(196, 49);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(18, 15);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "to";
            // 
            // metricComboBox
            // 
            this.metricComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metricComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.metricComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metricComboBox.FormattingEnabled = true;
            this.metricComboBox.Items.AddRange(new object[] {
            "Fleet utilization rate",
            "Revenue per vehicle per day",
            "Average rental duration",
            "Damage incident rate",
            "Customer retention rate"});
            this.metricComboBox.Location = new System.Drawing.Point(476, 45);
            this.metricComboBox.Name = "metricComboBox";
            this.metricComboBox.Size = new System.Drawing.Size(190, 23);
            this.metricComboBox.TabIndex = 5;
            // 
            // metricLabel
            // 
            this.metricLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metricLabel.AutoSize = true;
            this.metricLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.metricLabel.ForeColor = System.Drawing.Color.DimGray;
            this.metricLabel.Location = new System.Drawing.Point(430, 48);
            this.metricLabel.Name = "metricLabel";
            this.metricLabel.Size = new System.Drawing.Size(40, 15);
            this.metricLabel.TabIndex = 4;
            this.metricLabel.Text = "Metric";
            // 
            // chartPlaceholderPanel
            // 
            this.chartPlaceholderPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPlaceholderPanel.BackColor = System.Drawing.Color.White;
            this.chartPlaceholderPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chartPlaceholderPanel.Controls.Add(this.chartPlaceholderLabel);
            this.chartPlaceholderPanel.Location = new System.Drawing.Point(18, 80);
            this.chartPlaceholderPanel.Name = "chartPlaceholderPanel";
            this.chartPlaceholderPanel.Size = new System.Drawing.Size(732, 270);
            this.chartPlaceholderPanel.TabIndex = 6;
            // 
            // chartPlaceholderLabel
            // 
            this.chartPlaceholderLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPlaceholderLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chartPlaceholderLabel.ForeColor = System.Drawing.Color.DimGray;
            this.chartPlaceholderLabel.Location = new System.Drawing.Point(0, 0);
            this.chartPlaceholderLabel.Name = "chartPlaceholderLabel";
            this.chartPlaceholderLabel.Size = new System.Drawing.Size(730, 268);
            this.chartPlaceholderLabel.TabIndex = 0;
            this.chartPlaceholderLabel.Text = "Chart / report preview placeholder.\r\n\r\nLater you can add charts, tables, and exp" +
    "ort buttons here.";
            this.chartPlaceholderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // generateButton
            // 
            this.generateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.generateButton.FlatAppearance.BorderSize = 0;
            this.generateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generateButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.generateButton.ForeColor = System.Drawing.Color.White;
            this.generateButton.Location = new System.Drawing.Point(672, 45);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(78, 23);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = false;
            // 
            // ReportsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.chartPlaceholderPanel);
            this.Controls.Add(this.metricComboBox);
            this.Controls.Add(this.metricLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.rangeToPicker);
            this.Controls.Add(this.rangeFromPicker);
            this.Controls.Add(this.headerLabel);
            this.Name = "ReportsView";
            this.Size = new System.Drawing.Size(770, 380);
            this.chartPlaceholderPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DateTimePicker rangeFromPicker;
        private System.Windows.Forms.DateTimePicker rangeToPicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.ComboBox metricComboBox;
        private System.Windows.Forms.Label metricLabel;
        private System.Windows.Forms.Panel chartPlaceholderPanel;
        private System.Windows.Forms.Label chartPlaceholderLabel;
        private System.Windows.Forms.Button generateButton;
    }
}



