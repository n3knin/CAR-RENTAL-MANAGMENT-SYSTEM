namespace RentalApp.UI.Sections
{
    partial class BillingView
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
            this.billingGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(13, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(121, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Billing Overview";
            this.headerLabel.DoubleClick += new System.EventHandler(this.billingGrid_DoubleClick);
            // 
            // billingGrid
            // 
            this.billingGrid.AllowUserToAddRows = false;
            this.billingGrid.AllowUserToDeleteRows = false;
            this.billingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billingGrid.BackgroundColor = System.Drawing.Color.White;
            this.billingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingGrid.Location = new System.Drawing.Point(15, 43);
            this.billingGrid.Name = "billingGrid";
            this.billingGrid.ReadOnly = true;
            this.billingGrid.RowHeadersVisible = false;
            this.billingGrid.Size = new System.Drawing.Size(627, 266);
            this.billingGrid.TabIndex = 1;
            this.billingGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billingGrid_CellContentClick);
            this.billingGrid.DoubleClick += new System.EventHandler(this.billingGrid_DoubleClick);
            // 
            // BillingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.billingGrid);
            this.Controls.Add(this.headerLabel);
            this.Name = "BillingView";
            this.Size = new System.Drawing.Size(660, 329);
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView billingGrid;
    }
}



