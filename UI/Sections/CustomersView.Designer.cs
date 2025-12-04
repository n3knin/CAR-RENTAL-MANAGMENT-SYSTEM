namespace RentalApp.UI.Sections
{
    partial class CustomersView
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
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.filterLabel = new System.Windows.Forms.Label();
            this.customersGrid = new System.Windows.Forms.DataGridView();
            this.addButton = new System.Windows.Forms.Button();
            this.viewProfileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(15, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(136, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Customer Profiles";
            // 
            // filterComboBox
            // 
            this.filterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filterComboBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Items.AddRange(new object[] {
            "All customers",
            "Frequent renters",
            "Corporate clients",
            "Blacklisted"});
            this.filterComboBox.Location = new System.Drawing.Point(70, 45);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(200, 23);
            this.filterComboBox.TabIndex = 2;
            // 
            // filterLabel
            // 
            this.filterLabel.AutoSize = true;
            this.filterLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.filterLabel.ForeColor = System.Drawing.Color.DimGray;
            this.filterLabel.Location = new System.Drawing.Point(18, 48);
            this.filterLabel.Name = "filterLabel";
            this.filterLabel.Size = new System.Drawing.Size(46, 15);
            this.filterLabel.TabIndex = 1;
            this.filterLabel.Text = "Filter by";
            // 
            // customersGrid
            // 
            this.customersGrid.AllowUserToAddRows = false;
            this.customersGrid.AllowUserToDeleteRows = false;
            this.customersGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customersGrid.BackgroundColor = System.Drawing.Color.White;
            this.customersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGrid.Location = new System.Drawing.Point(18, 80);
            this.customersGrid.Name = "customersGrid";
            this.customersGrid.ReadOnly = true;
            this.customersGrid.RowHeadersVisible = false;
            this.customersGrid.Size = new System.Drawing.Size(732, 280);
            this.customersGrid.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(590, 45);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(80, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "New";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewProfileButton.BackColor = System.Drawing.Color.White;
            this.viewProfileButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.viewProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProfileButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewProfileButton.ForeColor = System.Drawing.Color.DimGray;
            this.viewProfileButton.Location = new System.Drawing.Point(676, 45);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(74, 23);
            this.viewProfileButton.TabIndex = 5;
            this.viewProfileButton.Text = "View";
            this.viewProfileButton.UseVisualStyleBackColor = false;
            // 
            // CustomersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.viewProfileButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.customersGrid);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "CustomersView";
            this.Size = new System.Drawing.Size(770, 380);
            ((System.ComponentModel.ISupportInitialize)(this.customersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Label filterLabel;
        private System.Windows.Forms.DataGridView customersGrid;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button viewProfileButton;
    }
}



