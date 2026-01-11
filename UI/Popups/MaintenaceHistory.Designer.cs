namespace RentalApp.UI.Popups
{
    partial class MaintenaceHistory
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
            this.maintenanceGrid = new System.Windows.Forms.DataGridView();
            this.newrecordbt = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.vehicletxt = new System.Windows.Forms.Label();
            this.materialLabel4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // maintenanceGrid
            // 
            this.maintenanceGrid.AllowUserToAddRows = false;
            this.maintenanceGrid.AllowUserToDeleteRows = false;
            this.maintenanceGrid.BackgroundColor = System.Drawing.Color.White;
            this.maintenanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.maintenanceGrid.Location = new System.Drawing.Point(12, 88);
            this.maintenanceGrid.Name = "maintenanceGrid";
            this.maintenanceGrid.ReadOnly = true;
            this.maintenanceGrid.RowHeadersVisible = false;
            this.maintenanceGrid.Size = new System.Drawing.Size(560, 250);
            this.maintenanceGrid.TabIndex = 0;
            this.maintenanceGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.maintenanceGrid_CellContentDoubleClick);
            // 
            // newrecordbt
            // 
            this.newrecordbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.newrecordbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newrecordbt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.newrecordbt.ForeColor = System.Drawing.Color.White;
            this.newrecordbt.Location = new System.Drawing.Point(473, 51);
            this.newrecordbt.Name = "newrecordbt";
            this.newrecordbt.Size = new System.Drawing.Size(99, 31);
            this.newrecordbt.TabIndex = 1;
            this.newrecordbt.Text = "+ New Record";
            this.newrecordbt.UseVisualStyleBackColor = false;
            this.newrecordbt.Click += new System.EventHandler(this.newrecordbt_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(218, 30);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Maintenance History";
            // 
            // vehicletxt
            // 
            this.vehicletxt.AutoSize = true;
            this.vehicletxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.vehicletxt.ForeColor = System.Drawing.Color.Black;
            this.vehicletxt.Location = new System.Drawing.Point(110, 63);
            this.vehicletxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vehicletxt.Name = "vehicletxt";
            this.vehicletxt.Size = new System.Drawing.Size(100, 19);
            this.vehicletxt.TabIndex = 15;
            this.vehicletxt.Text = "Vehicle Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel4.Location = new System.Drawing.Point(14, 65);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 15);
            this.materialLabel4.TabIndex = 14;
            this.materialLabel4.Text = "Vehicle:";
            // 
            // MaintenaceHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 350);
            this.Controls.Add(this.vehicletxt);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.newrecordbt);
            this.Controls.Add(this.maintenanceGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaintenaceHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Maintenance Details";
            ((System.ComponentModel.ISupportInitialize)(this.maintenanceGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView maintenanceGrid;
        private System.Windows.Forms.Button newrecordbt;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label vehicletxt;
        private System.Windows.Forms.Label materialLabel4;
    }
}