namespace RentalApp.UI.Popups
{
    partial class VehicleDetailsForm
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
            this.lblMakeModel = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFeatures = new System.Windows.Forms.Label();
            this.lstFeatures = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblMakeModel
            // 
            this.lblMakeModel.AutoSize = true;
            this.lblMakeModel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblMakeModel.Location = new System.Drawing.Point(20, 20);
            this.lblMakeModel.Name = "lblMakeModel";
            this.lblMakeModel.Size = new System.Drawing.Size(154, 30);
            this.lblMakeModel.TabIndex = 0;
            this.lblMakeModel.Text = "Vehicle Name";
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLicense.Location = new System.Drawing.Point(22, 60);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(61, 21);
            this.lblLicense.TabIndex = 1;
            this.lblLicense.Text = "License";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.DimGray;
            this.lblStatus.Location = new System.Drawing.Point(22, 90);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(49, 19);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 120);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 3;
            this.lblType.Text = "Type";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(200, 280);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblFeatures
            // 
            this.lblFeatures.AutoSize = true;
            this.lblFeatures.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblFeatures.Location = new System.Drawing.Point(22, 140);
            this.lblFeatures.Name = "lblFeatures";
            this.lblFeatures.Size = new System.Drawing.Size(65, 19);
            this.lblFeatures.TabIndex = 5;
            this.lblFeatures.Text = "Features";
            // 
            // lstFeatures
            // 
            this.lstFeatures.FormattingEnabled = true;
            this.lstFeatures.Location = new System.Drawing.Point(26, 165);
            this.lstFeatures.Name = "lstFeatures";
            this.lstFeatures.Size = new System.Drawing.Size(249, 95);
            this.lstFeatures.TabIndex = 6;
            this.lstFeatures.SelectedIndexChanged += new System.EventHandler(this.lstFeatures_SelectedIndexChanged);
            // 
            // VehicleDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 320);
            this.Controls.Add(this.lstFeatures);
            this.Controls.Add(this.lblFeatures);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblMakeModel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VehicleDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Details";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblMakeModel;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFeatures;
        private System.Windows.Forms.ListBox lstFeatures;
    }
}
