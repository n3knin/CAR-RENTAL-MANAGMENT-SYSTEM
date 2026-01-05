namespace RentalApp.UI.Sections
{
    partial class PickupsView
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
            this.todayLabel = new System.Windows.Forms.Label();
            this.pickupsGrid = new System.Windows.Forms.DataGridView();
            this.quickFilterComboBox = new System.Windows.Forms.ComboBox();
            this.quickFilterLabel = new System.Windows.Forms.Label();
            this.viewChecklistButton = new System.Windows.Forms.Button();
            this.startPickupButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pickupsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(13, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(115, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Today\'s Pickups";
            // 
            // todayLabel
            // 
            this.todayLabel.AutoSize = true;
            this.todayLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.todayLabel.ForeColor = System.Drawing.Color.DimGray;
            this.todayLabel.Location = new System.Drawing.Point(15, 42);
            this.todayLabel.Name = "todayLabel";
            this.todayLabel.Size = new System.Drawing.Size(162, 15);
            this.todayLabel.TabIndex = 1;
            this.todayLabel.Text = "Prepare inspection checklists.";
            // 
            // pickupsGrid
            // 
            this.pickupsGrid.AllowUserToAddRows = false;
            this.pickupsGrid.AllowUserToDeleteRows = false;
            this.pickupsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pickupsGrid.BackgroundColor = System.Drawing.Color.White;
            this.pickupsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pickupsGrid.Location = new System.Drawing.Point(17, 63);
            this.pickupsGrid.Name = "pickupsGrid";
            this.pickupsGrid.ReadOnly = true;
            this.pickupsGrid.RowHeadersVisible = false;
            this.pickupsGrid.Size = new System.Drawing.Size(613, 252);
            this.pickupsGrid.TabIndex = 5;
            this.pickupsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pickupsGrid_CellContentClick);
            // 
            // quickFilterComboBox
            // 
            this.quickFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quickFilterComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quickFilterComboBox.FormattingEnabled = true;
            this.quickFilterComboBox.Items.AddRange(new object[] {
            "All pickups",
            "Due in next hour",
            "Overdue"});
            this.quickFilterComboBox.Location = new System.Drawing.Point(268, 34);
            this.quickFilterComboBox.Name = "quickFilterComboBox";
            this.quickFilterComboBox.Size = new System.Drawing.Size(129, 23);
            this.quickFilterComboBox.TabIndex = 3;
            // 
            // quickFilterLabel
            // 
            this.quickFilterLabel.AutoSize = true;
            this.quickFilterLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.quickFilterLabel.ForeColor = System.Drawing.Color.DimGray;
            this.quickFilterLabel.Location = new System.Drawing.Point(197, 42);
            this.quickFilterLabel.Name = "quickFilterLabel";
            this.quickFilterLabel.Size = new System.Drawing.Size(65, 15);
            this.quickFilterLabel.TabIndex = 2;
            this.quickFilterLabel.Text = "Quick filter";
            // 
            // viewChecklistButton
            // 
            this.viewChecklistButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewChecklistButton.BackColor = System.Drawing.Color.White;
            this.viewChecklistButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.viewChecklistButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewChecklistButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewChecklistButton.ForeColor = System.Drawing.Color.DimGray;
            this.viewChecklistButton.Location = new System.Drawing.Point(585, 37);
            this.viewChecklistButton.Name = "viewChecklistButton";
            this.viewChecklistButton.Size = new System.Drawing.Size(58, 20);
            this.viewChecklistButton.TabIndex = 7;
            this.viewChecklistButton.Text = "Checklist";
            this.viewChecklistButton.UseVisualStyleBackColor = false;
            // 
            // startPickupButton
            // 
            this.startPickupButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startPickupButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.startPickupButton.FlatAppearance.BorderSize = 0;
            this.startPickupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPickupButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startPickupButton.ForeColor = System.Drawing.Color.White;
            this.startPickupButton.Location = new System.Drawing.Point(485, 37);
            this.startPickupButton.Name = "startPickupButton";
            this.startPickupButton.Size = new System.Drawing.Size(94, 20);
            this.startPickupButton.TabIndex = 6;
            this.startPickupButton.Text = "Start Pickup";
            this.startPickupButton.UseVisualStyleBackColor = false;
            this.startPickupButton.Click += new System.EventHandler(this.startPickupButton_Click);
            // 
            // PickupsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.quickFilterComboBox);
            this.Controls.Add(this.quickFilterLabel);
            this.Controls.Add(this.viewChecklistButton);
            this.Controls.Add(this.startPickupButton);
            this.Controls.Add(this.pickupsGrid);
            this.Controls.Add(this.todayLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "PickupsView";
            this.Size = new System.Drawing.Size(660, 341);
            ((System.ComponentModel.ISupportInitialize)(this.pickupsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label todayLabel;
        private System.Windows.Forms.DataGridView pickupsGrid;
        private System.Windows.Forms.ComboBox quickFilterComboBox;
        private System.Windows.Forms.Label quickFilterLabel;
        private System.Windows.Forms.Button viewChecklistButton;
        private System.Windows.Forms.Button startPickupButton;
    }
}



