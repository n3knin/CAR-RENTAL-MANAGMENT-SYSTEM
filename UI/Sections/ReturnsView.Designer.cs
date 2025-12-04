namespace RentalApp.UI.Sections
{
    partial class ReturnsView
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
            this.returnsGrid = new System.Windows.Forms.DataGridView();
            this.startReturnButton = new System.Windows.Forms.Button();
            this.damageAssessmentButton = new System.Windows.Forms.Button();
            this.summaryLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.returnsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(15, 15);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(130, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Vehicle Returns   ";
            // 
            // returnsGrid
            // 
            this.returnsGrid.AllowUserToAddRows = false;
            this.returnsGrid.AllowUserToDeleteRows = false;
            this.returnsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.returnsGrid.BackgroundColor = System.Drawing.Color.White;
            this.returnsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.returnsGrid.Location = new System.Drawing.Point(18, 80);
            this.returnsGrid.Name = "returnsGrid";
            this.returnsGrid.ReadOnly = true;
            this.returnsGrid.RowHeadersVisible = false;
            this.returnsGrid.Size = new System.Drawing.Size(732, 280);
            this.returnsGrid.TabIndex = 3;
            // 
            // startReturnButton
            // 
            this.startReturnButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startReturnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.startReturnButton.FlatAppearance.BorderSize = 0;
            this.startReturnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startReturnButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.startReturnButton.ForeColor = System.Drawing.Color.White;
            this.startReturnButton.Location = new System.Drawing.Point(566, 45);
            this.startReturnButton.Name = "startReturnButton";
            this.startReturnButton.Size = new System.Drawing.Size(110, 23);
            this.startReturnButton.TabIndex = 4;
            this.startReturnButton.Text = "Start Return";
            this.startReturnButton.UseVisualStyleBackColor = false;
            // 
            // damageAssessmentButton
            // 
            this.damageAssessmentButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.damageAssessmentButton.BackColor = System.Drawing.Color.White;
            this.damageAssessmentButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.damageAssessmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.damageAssessmentButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.damageAssessmentButton.ForeColor = System.Drawing.Color.DimGray;
            this.damageAssessmentButton.Location = new System.Drawing.Point(682, 45);
            this.damageAssessmentButton.Name = "damageAssessmentButton";
            this.damageAssessmentButton.Size = new System.Drawing.Size(68, 23);
            this.damageAssessmentButton.TabIndex = 5;
            this.damageAssessmentButton.Text = "Damage";
            this.damageAssessmentButton.UseVisualStyleBackColor = false;
            // 
            // summaryLabel
            // 
            this.summaryLabel.AutoSize = true;
            this.summaryLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.summaryLabel.ForeColor = System.Drawing.Color.DimGray;
            this.summaryLabel.Location = new System.Drawing.Point(18, 48);
            this.summaryLabel.Name = "summaryLabel";
            this.summaryLabel.Size = new System.Drawing.Size(270, 15);
            this.summaryLabel.TabIndex = 1;
            this.summaryLabel.Text = "Inspect condition, record odometer and finalize bill.";
            // 
            // ReturnsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.summaryLabel);
            this.Controls.Add(this.damageAssessmentButton);
            this.Controls.Add(this.startReturnButton);
            this.Controls.Add(this.returnsGrid);
            this.Controls.Add(this.headerLabel);
            this.Name = "ReturnsView";
            this.Size = new System.Drawing.Size(770, 380);
            ((System.ComponentModel.ISupportInitialize)(this.returnsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DataGridView returnsGrid;
        private System.Windows.Forms.Button startReturnButton;
        private System.Windows.Forms.Button damageAssessmentButton;
        private System.Windows.Forms.Label summaryLabel;
    }
}



