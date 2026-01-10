namespace RentalApp.UI.Sections
{
    partial class ReservationsView
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
            this.dtpFROM = new System.Windows.Forms.DateTimePicker();
            this.dtpTO = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.reservationsGrid = new System.Windows.Forms.DataGridView();
            this.newReservationButton = new System.Windows.Forms.Button();
            this.cancelbt = new System.Windows.Forms.Button();
            this.dateRangeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(13, 13);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(145, 20);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Reservations Queue";
            // 
            // dtpFROM
            // 
            this.dtpFROM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFROM.Location = new System.Drawing.Point(87, 39);
            this.dtpFROM.Name = "dtpFROM";
            this.dtpFROM.Size = new System.Drawing.Size(95, 23);
            this.dtpFROM.TabIndex = 2;
            // 
            // dtpTO
            // 
            this.dtpTO.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTO.Location = new System.Drawing.Point(207, 39);
            this.dtpTO.Name = "dtpTO";
            this.dtpTO.Size = new System.Drawing.Size(95, 23);
            this.dtpTO.TabIndex = 3;
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toLabel.ForeColor = System.Drawing.Color.DimGray;
            this.toLabel.Location = new System.Drawing.Point(186, 42);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(18, 15);
            this.toLabel.TabIndex = 0;
            this.toLabel.Text = "to";
            // 
            // reservationsGrid
            // 
            this.reservationsGrid.AllowUserToAddRows = false;
            this.reservationsGrid.AllowUserToDeleteRows = false;
            this.reservationsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reservationsGrid.BackgroundColor = System.Drawing.Color.White;
            this.reservationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservationsGrid.Location = new System.Drawing.Point(16, 69);
            this.reservationsGrid.Name = "reservationsGrid";
            this.reservationsGrid.ReadOnly = true;
            this.reservationsGrid.RowHeadersVisible = false;
            this.reservationsGrid.Size = new System.Drawing.Size(627, 243);
            this.reservationsGrid.TabIndex = 5;
            this.reservationsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reservationsGrid_CellContentClick);
            // 
            // newReservationButton
            // 
            this.newReservationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.newReservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(161)))), ((int)(((byte)(242)))));
            this.newReservationButton.FlatAppearance.BorderSize = 0;
            this.newReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newReservationButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.newReservationButton.ForeColor = System.Drawing.Color.White;
            this.newReservationButton.Location = new System.Drawing.Point(416, 39);
            this.newReservationButton.Name = "newReservationButton";
            this.newReservationButton.Size = new System.Drawing.Size(94, 24);
            this.newReservationButton.TabIndex = 6;
            this.newReservationButton.Text = "New Reservation";
            this.newReservationButton.UseVisualStyleBackColor = false;
            this.newReservationButton.Click += new System.EventHandler(this.newReservationButton_Click);
            // 
            // cancelbt
            // 
            this.cancelbt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelbt.BackColor = System.Drawing.Color.White;
            this.cancelbt.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cancelbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cancelbt.ForeColor = System.Drawing.Color.DimGray;
            this.cancelbt.Location = new System.Drawing.Point(516, 39);
            this.cancelbt.Name = "cancelbt";
            this.cancelbt.Size = new System.Drawing.Size(127, 24);
            this.cancelbt.TabIndex = 7;
            this.cancelbt.Text = "Cancel Reservation";
            this.cancelbt.UseVisualStyleBackColor = false;
            this.cancelbt.Click += new System.EventHandler(this.cancelbt_Click);
            // 
            // dateRangeLabel
            // 
            this.dateRangeLabel.AutoSize = true;
            this.dateRangeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateRangeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.dateRangeLabel.Location = new System.Drawing.Point(14, 44);
            this.dateRangeLabel.Name = "dateRangeLabel";
            this.dateRangeLabel.Size = new System.Drawing.Size(67, 15);
            this.dateRangeLabel.TabIndex = 1;
            this.dateRangeLabel.Text = "Date Range";
            // 
            // ReservationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dateRangeLabel);
            this.Controls.Add(this.cancelbt);
            this.Controls.Add(this.newReservationButton);
            this.Controls.Add(this.reservationsGrid);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.dtpTO);
            this.Controls.Add(this.dtpFROM);
            this.Controls.Add(this.headerLabel);
            this.Name = "ReservationsView";
            this.Size = new System.Drawing.Size(660, 329);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DateTimePicker dtpFROM;
        private System.Windows.Forms.DateTimePicker dtpTO;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DataGridView reservationsGrid;
        private System.Windows.Forms.Button newReservationButton;
        private System.Windows.Forms.Button cancelbt;
        private System.Windows.Forms.Label dateRangeLabel;
    }
}



