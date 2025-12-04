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
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.totalDueLabel = new System.Windows.Forms.Label();
            this.totalDueValueLabel = new System.Windows.Forms.Label();
            this.processPaymentButton = new System.Windows.Forms.Button();
            this.exportInvoiceButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).BeginInit();
            this.summaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(15, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(121, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Billing Overview";
            // 
            // billingGrid
            // 
            this.billingGrid.AllowUserToAddRows = false;
            this.billingGrid.AllowUserToDeleteRows = false;
            this.billingGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.billingGrid.BackgroundColor = System.Drawing.Color.White;
            this.billingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingGrid.Location = new System.Drawing.Point(18, 50);
            this.billingGrid.Name = "billingGrid";
            this.billingGrid.ReadOnly = true;
            this.billingGrid.RowHeadersVisible = false;
            this.billingGrid.Size = new System.Drawing.Size(732, 220);
            this.billingGrid.TabIndex = 1;
            // 
            // summaryPanel
            // 
            this.summaryPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.summaryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.summaryPanel.Controls.Add(this.exportInvoiceButton);
            this.summaryPanel.Controls.Add(this.processPaymentButton);
            this.summaryPanel.Controls.Add(this.totalDueValueLabel);
            this.summaryPanel.Controls.Add(this.totalDueLabel);
            this.summaryPanel.Location = new System.Drawing.Point(18, 280);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(732, 80);
            this.summaryPanel.TabIndex = 2;
            // 
            // totalDueLabel
            // 
            this.totalDueLabel.AutoSize = true;
            this.totalDueLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.totalDueLabel.ForeColor = System.Drawing.Color.DimGray;
            this.totalDueLabel.Location = new System.Drawing.Point(15, 15);
            this.totalDueLabel.Name = "totalDueLabel";
            this.totalDueLabel.Size = new System.Drawing.Size(121, 15);
            this.totalDueLabel.TabIndex = 0;
            this.totalDueLabel.Text = "Total Outstanding Due";
            // 
            // totalDueValueLabel
            // 
            this.totalDueValueLabel.AutoSize = true;
            this.totalDueValueLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.totalDueValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(152)))), ((int)(((byte)(39)))));
            this.totalDueValueLabel.Location = new System.Drawing.Point(13, 35);
            this.totalDueValueLabel.Name = "totalDueValueLabel";
            this.totalDueValueLabel.Size = new System.Drawing.Size(116, 25);
            this.totalDueValueLabel.TabIndex = 1;
            this.totalDueValueLabel.Text = "$ 4,320.50";
            // 
            // processPaymentButton
            // 
            this.processPaymentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.processPaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(177)))), ((int)(((byte)(124)))));
            this.processPaymentButton.FlatAppearance.BorderSize = 0;
            this.processPaymentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.processPaymentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.processPaymentButton.ForeColor = System.Drawing.Color.White;
            this.processPaymentButton.Location = new System.Drawing.Point(530, 25);
            this.processPaymentButton.Name = "processPaymentButton";
            this.processPaymentButton.Size = new System.Drawing.Size(110, 28);
            this.processPaymentButton.TabIndex = 2;
            this.processPaymentButton.Text = "Process Payment";
            this.processPaymentButton.UseVisualStyleBackColor = false;
            // 
            // exportInvoiceButton
            // 
            this.exportInvoiceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exportInvoiceButton.BackColor = System.Drawing.Color.White;
            this.exportInvoiceButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.exportInvoiceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportInvoiceButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exportInvoiceButton.ForeColor = System.Drawing.Color.DimGray;
            this.exportInvoiceButton.Location = new System.Drawing.Point(646, 25);
            this.exportInvoiceButton.Name = "exportInvoiceButton";
            this.exportInvoiceButton.Size = new System.Drawing.Size(68, 28);
            this.exportInvoiceButton.TabIndex = 3;
            this.exportInvoiceButton.Text = "Invoice";
            this.exportInvoiceButton.UseVisualStyleBackColor = false;
            // 
            // BillingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.summaryPanel);
            this.Controls.Add(this.billingGrid);
            this.Controls.Add(this.headerLabel);
            this.Name = "BillingView";
            this.Size = new System.Drawing.Size(770, 380);
            ((System.ComponentModel.ISupportInitialize)(this.billingGrid)).EndInit();
            this.summaryPanel.ResumeLayout(false);
            this.summaryPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView billingGrid;
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.Label totalDueLabel;
        private System.Windows.Forms.Label totalDueValueLabel;
        private System.Windows.Forms.Button processPaymentButton;
        private System.Windows.Forms.Button exportInvoiceButton;
    }
}



