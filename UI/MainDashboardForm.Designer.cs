namespace RentalApp.UI
{
    partial class MainDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportsButton = new System.Windows.Forms.Button();
            this.billingButton = new System.Windows.Forms.Button();
            this.returnsButton = new System.Windows.Forms.Button();
            this.pickupsButton = new System.Windows.Forms.Button();
            this.reservationsButton = new System.Windows.Forms.Button();
            this.customersButton = new System.Windows.Forms.Button();
            this.vehiclesButton = new System.Windows.Forms.Button();
            this.logoLabel = new System.Windows.Forms.Label();
            this.topBarPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.appTitleLabel = new System.Windows.Forms.Label();
            this.userRoleLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.cardsTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.cardFleet = new System.Windows.Forms.Panel();
            this.cardFleetValue = new System.Windows.Forms.Label();
            this.cardFleetLabel = new System.Windows.Forms.Label();
            this.cardActiveRentals = new System.Windows.Forms.Panel();
            this.cardActiveRentalsValue = new System.Windows.Forms.Label();
            this.cardActiveRentalsLabel = new System.Windows.Forms.Label();
            this.cardRevenue = new System.Windows.Forms.Panel();
            this.cardRevenueValue = new System.Windows.Forms.Label();
            this.cardRevenueLabel = new System.Windows.Forms.Label();
            this.sectionTitleLabel = new System.Windows.Forms.Label();
            this.placeholderLabel = new System.Windows.Forms.Label();
            this.sidebarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topBarPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.cardsTableLayout.SuspendLayout();
            this.cardFleet.SuspendLayout();
            this.cardActiveRentals.SuspendLayout();
            this.cardRevenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.sidebarPanel.Controls.Add(this.pictureBox1);
            this.sidebarPanel.Controls.Add(this.reportsButton);
            this.sidebarPanel.Controls.Add(this.billingButton);
            this.sidebarPanel.Controls.Add(this.returnsButton);
            this.sidebarPanel.Controls.Add(this.pickupsButton);
            this.sidebarPanel.Controls.Add(this.reservationsButton);
            this.sidebarPanel.Controls.Add(this.customersButton);
            this.sidebarPanel.Controls.Add(this.vehiclesButton);
            this.sidebarPanel.Controls.Add(this.logoLabel);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(200, 906);
            this.sidebarPanel.TabIndex = 0;
            this.sidebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sidebarPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RentalApp.Properties.Resources._3f854611_2392_4611_8d7c_e67094331d91_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(60, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // reportsButton
            // 
            this.reportsButton.FlatAppearance.BorderSize = 0;
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reportsButton.ForeColor = System.Drawing.Color.White;
            this.reportsButton.Location = new System.Drawing.Point(0, 530);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.reportsButton.Size = new System.Drawing.Size(200, 40);
            this.reportsButton.TabIndex = 7;
            this.reportsButton.Text = "Reports and Analytics";
            this.reportsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportsButton.UseVisualStyleBackColor = true;
            this.reportsButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // billingButton
            // 
            this.billingButton.FlatAppearance.BorderSize = 0;
            this.billingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.billingButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.billingButton.ForeColor = System.Drawing.Color.White;
            this.billingButton.Location = new System.Drawing.Point(0, 467);
            this.billingButton.Name = "billingButton";
            this.billingButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.billingButton.Size = new System.Drawing.Size(200, 40);
            this.billingButton.TabIndex = 6;
            this.billingButton.Text = "Billing and Payments";
            this.billingButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.billingButton.UseVisualStyleBackColor = true;
            this.billingButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // returnsButton
            // 
            this.returnsButton.FlatAppearance.BorderSize = 0;
            this.returnsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.returnsButton.ForeColor = System.Drawing.Color.White;
            this.returnsButton.Location = new System.Drawing.Point(0, 401);
            this.returnsButton.Name = "returnsButton";
            this.returnsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.returnsButton.Size = new System.Drawing.Size(200, 40);
            this.returnsButton.TabIndex = 5;
            this.returnsButton.Text = "Returns";
            this.returnsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.returnsButton.UseVisualStyleBackColor = true;
            this.returnsButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // pickupsButton
            // 
            this.pickupsButton.FlatAppearance.BorderSize = 0;
            this.pickupsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickupsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pickupsButton.ForeColor = System.Drawing.Color.White;
            this.pickupsButton.Location = new System.Drawing.Point(0, 335);
            this.pickupsButton.Name = "pickupsButton";
            this.pickupsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pickupsButton.Size = new System.Drawing.Size(200, 40);
            this.pickupsButton.TabIndex = 4;
            this.pickupsButton.Text = "Pickups";
            this.pickupsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pickupsButton.UseVisualStyleBackColor = true;
            this.pickupsButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // reservationsButton
            // 
            this.reservationsButton.FlatAppearance.BorderSize = 0;
            this.reservationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reservationsButton.ForeColor = System.Drawing.Color.White;
            this.reservationsButton.Location = new System.Drawing.Point(-3, 274);
            this.reservationsButton.Name = "reservationsButton";
            this.reservationsButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.reservationsButton.Size = new System.Drawing.Size(200, 40);
            this.reservationsButton.TabIndex = 3;
            this.reservationsButton.Text = "Reservations";
            this.reservationsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reservationsButton.UseVisualStyleBackColor = true;
            this.reservationsButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // customersButton
            // 
            this.customersButton.FlatAppearance.BorderSize = 0;
            this.customersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customersButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customersButton.ForeColor = System.Drawing.Color.White;
            this.customersButton.Location = new System.Drawing.Point(0, 216);
            this.customersButton.Name = "customersButton";
            this.customersButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.customersButton.Size = new System.Drawing.Size(200, 40);
            this.customersButton.TabIndex = 2;
            this.customersButton.Text = "Customers";
            this.customersButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customersButton.UseVisualStyleBackColor = true;
            this.customersButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // vehiclesButton
            // 
            this.vehiclesButton.FlatAppearance.BorderSize = 0;
            this.vehiclesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vehiclesButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.vehiclesButton.ForeColor = System.Drawing.Color.White;
            this.vehiclesButton.Location = new System.Drawing.Point(0, 156);
            this.vehiclesButton.Name = "vehiclesButton";
            this.vehiclesButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.vehiclesButton.Size = new System.Drawing.Size(200, 40);
            this.vehiclesButton.TabIndex = 1;
            this.vehiclesButton.Text = "Vehicles";
            this.vehiclesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.vehiclesButton.UseVisualStyleBackColor = true;
            this.vehiclesButton.Click += new System.EventHandler(this.navButton_Click);
            // 
            // logoLabel
            // 
            this.logoLabel.AutoSize = true;
            this.logoLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.logoLabel.ForeColor = System.Drawing.Color.White;
            this.logoLabel.Location = new System.Drawing.Point(22, 99);
            this.logoLabel.Name = "logoLabel";
            this.logoLabel.Size = new System.Drawing.Size(172, 28);
            this.logoLabel.TabIndex = 0;
            this.logoLabel.Text = "Rental Dashboard";
            // 
            // topBarPanel
            // 
            this.topBarPanel.BackColor = System.Drawing.Color.White;
            this.topBarPanel.Controls.Add(this.closeButton);
            this.topBarPanel.Controls.Add(this.appTitleLabel);
            this.topBarPanel.Controls.Add(this.userRoleLabel);
            this.topBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBarPanel.Location = new System.Drawing.Point(200, 0);
            this.topBarPanel.Name = "topBarPanel";
            this.topBarPanel.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.topBarPanel.Size = new System.Drawing.Size(1543, 60);
            this.topBarPanel.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.Color.DimGray;
            this.closeButton.Location = new System.Drawing.Point(1495, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 28);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // appTitleLabel
            // 
            this.appTitleLabel.AutoSize = true;
            this.appTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.appTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.appTitleLabel.Location = new System.Drawing.Point(23, 20);
            this.appTitleLabel.Name = "appTitleLabel";
            this.appTitleLabel.Size = new System.Drawing.Size(293, 25);
            this.appTitleLabel.TabIndex = 0;
            this.appTitleLabel.Text = "Vehicle Rental Management Hub";
            // 
            // userRoleLabel
            // 
            this.userRoleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.userRoleLabel.AutoSize = true;
            this.userRoleLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.userRoleLabel.ForeColor = System.Drawing.Color.DimGray;
            this.userRoleLabel.Location = new System.Drawing.Point(1303, 24);
            this.userRoleLabel.Name = "userRoleLabel";
            this.userRoleLabel.Size = new System.Drawing.Size(182, 20);
            this.userRoleLabel.TabIndex = 1;
            this.userRoleLabel.Text = "Signed in as: Rental Agent";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.mainPanel.Controls.Add(this.contentPanel);
            this.mainPanel.Controls.Add(this.cardsTableLayout);
            this.mainPanel.Controls.Add(this.sectionTitleLabel);
            this.mainPanel.Controls.Add(this.placeholderLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(200, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainPanel.Size = new System.Drawing.Size(1543, 846);
            this.mainPanel.TabIndex = 2;
            // 
            // contentPanel
            // 
            this.contentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Location = new System.Drawing.Point(23, 190);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1497, 636);
            this.contentPanel.TabIndex = 3;
            // 
            // cardsTableLayout
            // 
            this.cardsTableLayout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardsTableLayout.ColumnCount = 3;
            this.cardsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.cardsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.cardsTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.cardsTableLayout.Controls.Add(this.cardFleet, 0, 0);
            this.cardsTableLayout.Controls.Add(this.cardActiveRentals, 1, 0);
            this.cardsTableLayout.Controls.Add(this.cardRevenue, 2, 0);
            this.cardsTableLayout.Location = new System.Drawing.Point(23, 65);
            this.cardsTableLayout.Name = "cardsTableLayout";
            this.cardsTableLayout.RowCount = 1;
            this.cardsTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardsTableLayout.Size = new System.Drawing.Size(1497, 100);
            this.cardsTableLayout.TabIndex = 1;
            // 
            // cardFleet
            // 
            this.cardFleet.BackColor = System.Drawing.Color.White;
            this.cardFleet.Controls.Add(this.cardFleetValue);
            this.cardFleet.Controls.Add(this.cardFleetLabel);
            this.cardFleet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardFleet.Location = new System.Drawing.Point(10, 10);
            this.cardFleet.Margin = new System.Windows.Forms.Padding(10);
            this.cardFleet.Name = "cardFleet";
            this.cardFleet.Padding = new System.Windows.Forms.Padding(10);
            this.cardFleet.Size = new System.Drawing.Size(479, 80);
            this.cardFleet.TabIndex = 0;
            // 
            // cardFleetValue
            // 
            this.cardFleetValue.AutoSize = true;
            this.cardFleetValue.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cardFleetValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.cardFleetValue.Location = new System.Drawing.Point(13, 34);
            this.cardFleetValue.Name = "cardFleetValue";
            this.cardFleetValue.Size = new System.Drawing.Size(88, 37);
            this.cardFleetValue.TabIndex = 1;
            this.cardFleetValue.Text = "128 ▼";
            // 
            // cardFleetLabel
            // 
            this.cardFleetLabel.AutoSize = true;
            this.cardFleetLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cardFleetLabel.ForeColor = System.Drawing.Color.DimGray;
            this.cardFleetLabel.Location = new System.Drawing.Point(15, 12);
            this.cardFleetLabel.Name = "cardFleetLabel";
            this.cardFleetLabel.Size = new System.Drawing.Size(176, 20);
            this.cardFleetLabel.TabIndex = 0;
            this.cardFleetLabel.Text = "Total Vehicles in the Fleet";
            // 
            // cardActiveRentals
            // 
            this.cardActiveRentals.BackColor = System.Drawing.Color.White;
            this.cardActiveRentals.Controls.Add(this.cardActiveRentalsValue);
            this.cardActiveRentals.Controls.Add(this.cardActiveRentalsLabel);
            this.cardActiveRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardActiveRentals.Location = new System.Drawing.Point(509, 10);
            this.cardActiveRentals.Margin = new System.Windows.Forms.Padding(10);
            this.cardActiveRentals.Name = "cardActiveRentals";
            this.cardActiveRentals.Padding = new System.Windows.Forms.Padding(10);
            this.cardActiveRentals.Size = new System.Drawing.Size(479, 80);
            this.cardActiveRentals.TabIndex = 1;
            this.cardActiveRentals.Paint += new System.Windows.Forms.PaintEventHandler(this.cardActiveRentals_Paint);
            // 
            // cardActiveRentalsValue
            // 
            this.cardActiveRentalsValue.AutoSize = true;
            this.cardActiveRentalsValue.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cardActiveRentalsValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(177)))), ((int)(((byte)(124)))));
            this.cardActiveRentalsValue.Location = new System.Drawing.Point(13, 34);
            this.cardActiveRentalsValue.Name = "cardActiveRentalsValue";
            this.cardActiveRentalsValue.Size = new System.Drawing.Size(46, 37);
            this.cardActiveRentalsValue.TabIndex = 1;
            this.cardActiveRentalsValue.Text = "27";
            // 
            // cardActiveRentalsLabel
            // 
            this.cardActiveRentalsLabel.AutoSize = true;
            this.cardActiveRentalsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cardActiveRentalsLabel.ForeColor = System.Drawing.Color.DimGray;
            this.cardActiveRentalsLabel.Location = new System.Drawing.Point(15, 12);
            this.cardActiveRentalsLabel.Name = "cardActiveRentalsLabel";
            this.cardActiveRentalsLabel.Size = new System.Drawing.Size(102, 20);
            this.cardActiveRentalsLabel.TabIndex = 0;
            this.cardActiveRentalsLabel.Text = "Active Rentals";
            // 
            // cardRevenue
            // 
            this.cardRevenue.BackColor = System.Drawing.Color.White;
            this.cardRevenue.Controls.Add(this.cardRevenueValue);
            this.cardRevenue.Controls.Add(this.cardRevenueLabel);
            this.cardRevenue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRevenue.Location = new System.Drawing.Point(1008, 10);
            this.cardRevenue.Margin = new System.Windows.Forms.Padding(10);
            this.cardRevenue.Name = "cardRevenue";
            this.cardRevenue.Padding = new System.Windows.Forms.Padding(10);
            this.cardRevenue.Size = new System.Drawing.Size(479, 80);
            this.cardRevenue.TabIndex = 2;
            // 
            // cardRevenueValue
            // 
            this.cardRevenueValue.AutoSize = true;
            this.cardRevenueValue.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.cardRevenueValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(152)))), ((int)(((byte)(39)))));
            this.cardRevenueValue.Location = new System.Drawing.Point(13, 34);
            this.cardRevenueValue.Name = "cardRevenueValue";
            this.cardRevenueValue.Size = new System.Drawing.Size(155, 37);
            this.cardRevenueValue.TabIndex = 1;
            this.cardRevenueValue.Text = "$ 12,450.00";
            // 
            // cardRevenueLabel
            // 
            this.cardRevenueLabel.AutoSize = true;
            this.cardRevenueLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cardRevenueLabel.ForeColor = System.Drawing.Color.DimGray;
            this.cardRevenueLabel.Location = new System.Drawing.Point(15, 12);
            this.cardRevenueLabel.Name = "cardRevenueLabel";
            this.cardRevenueLabel.Size = new System.Drawing.Size(157, 20);
            this.cardRevenueLabel.TabIndex = 0;
            this.cardRevenueLabel.Text = "Revenue (Today/MTD)";
            // 
            // sectionTitleLabel
            // 
            this.sectionTitleLabel.AutoSize = true;
            this.sectionTitleLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.sectionTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.sectionTitleLabel.Location = new System.Drawing.Point(20, 20);
            this.sectionTitleLabel.Name = "sectionTitleLabel";
            this.sectionTitleLabel.Size = new System.Drawing.Size(146, 28);
            this.sectionTitleLabel.TabIndex = 0;
            this.sectionTitleLabel.Text = "Dashboard KPI";
            // 
            // placeholderLabel
            // 
            this.placeholderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.placeholderLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.placeholderLabel.ForeColor = System.Drawing.Color.Silver;
            this.placeholderLabel.Location = new System.Drawing.Point(1303, 25);
            this.placeholderLabel.Name = "placeholderLabel";
            this.placeholderLabel.Size = new System.Drawing.Size(220, 30);
            this.placeholderLabel.TabIndex = 2;
            this.placeholderLabel.Text = "Click a section on the left to manage vehicles, customers, rentals and billing.";
            // 
            // MainDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1743, 906);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topBarPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vehicle Rental Management - Dashboard";
            this.Load += new System.EventHandler(this.MainDashboardForm_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.sidebarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topBarPanel.ResumeLayout(false);
            this.topBarPanel.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.cardsTableLayout.ResumeLayout(false);
            this.cardFleet.ResumeLayout(false);
            this.cardFleet.PerformLayout();
            this.cardActiveRentals.ResumeLayout(false);
            this.cardActiveRentals.PerformLayout();
            this.cardRevenue.ResumeLayout(false);
            this.cardRevenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Button billingButton;
        private System.Windows.Forms.Button returnsButton;
        private System.Windows.Forms.Button pickupsButton;
        private System.Windows.Forms.Button reservationsButton;
        private System.Windows.Forms.Button customersButton;
        private System.Windows.Forms.Button vehiclesButton;
        private System.Windows.Forms.Label logoLabel;
        private System.Windows.Forms.Panel topBarPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label appTitleLabel;
        private System.Windows.Forms.Label userRoleLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.TableLayoutPanel cardsTableLayout;
        private System.Windows.Forms.Panel cardFleet;
        private System.Windows.Forms.Label cardFleetValue;
        private System.Windows.Forms.Label cardFleetLabel;
        private System.Windows.Forms.Panel cardActiveRentals;
        private System.Windows.Forms.Label cardActiveRentalsValue;
        private System.Windows.Forms.Label cardActiveRentalsLabel;
        private System.Windows.Forms.Panel cardRevenue;
        private System.Windows.Forms.Label cardRevenueValue;
        private System.Windows.Forms.Label cardRevenueLabel;
        private System.Windows.Forms.Label sectionTitleLabel;
        private System.Windows.Forms.Label placeholderLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


