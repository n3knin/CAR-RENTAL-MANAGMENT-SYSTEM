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
            this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
            this.dateToPicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.reservationsGrid = new System.Windows.Forms.DataGridView();
            this.newReservationButton = new System.Windows.Forms.Button();
            this.viewDetailsButton = new System.Windows.Forms.Button();
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
            // dateFromPicker
            // 
            this.dateFromPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFromPicker.Location = new System.Drawing.Point(87, 39);
            this.dateFromPicker.Name = "dateFromPicker";
            this.dateFromPicker.Size = new System.Drawing.Size(95, 23);
            this.dateFromPicker.TabIndex = 2;
            // 
            // dateToPicker
            // 
            this.dateToPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateToPicker.Location = new System.Drawing.Point(207, 39);
            this.dateToPicker.Name = "dateToPicker";
            this.dateToPicker.Size = new System.Drawing.Size(95, 23);
            this.dateToPicker.TabIndex = 3;
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
            this.reservationsGrid.Location = new System.Drawing.Point(15, 69);
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
            this.newReservationButton.Location = new System.Drawing.Point(485, 39);
            this.newReservationButton.Name = "newReservationButton";
            this.newReservationButton.Size = new System.Drawing.Size(94, 20);
            this.newReservationButton.TabIndex = 6;
            this.newReservationButton.Text = "New Reservation";
            this.newReservationButton.UseVisualStyleBackColor = false;
            this.newReservationButton.Click += new System.EventHandler(this.newReservationButton_Click);
            // 
            // viewDetailsButton
            // 
            this.viewDetailsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewDetailsButton.BackColor = System.Drawing.Color.White;
            this.viewDetailsButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.viewDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDetailsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.viewDetailsButton.ForeColor = System.Drawing.Color.DimGray;
            this.viewDetailsButton.Location = new System.Drawing.Point(585, 39);
            this.viewDetailsButton.Name = "viewDetailsButton";
            this.viewDetailsButton.Size = new System.Drawing.Size(58, 20);
            this.viewDetailsButton.TabIndex = 7;
            this.viewDetailsButton.Text = "Details";
            this.viewDetailsButton.UseVisualStyleBackColor = false;
            // 
            // dateRangeLabel
            // 
            this.dateRangeLabel.AutoSize = true;
            this.dateRangeLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateRangeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.dateRangeLabel.Location = new System.Drawing.Point(15, 42);
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
            this.Controls.Add(this.viewDetailsButton);
            this.Controls.Add(this.newReservationButton);
            this.Controls.Add(this.reservationsGrid);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.dateToPicker);
            this.Controls.Add(this.dateFromPicker);
            this.Controls.Add(this.headerLabel);
            this.Name = "ReservationsView";
            this.Size = new System.Drawing.Size(660, 329);
            ((System.ComponentModel.ISupportInitialize)(this.reservationsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DataGridView reservationsGrid;
        private System.Windows.Forms.Button newReservationButton;
        private System.Windows.Forms.Button viewDetailsButton;
        private System.Windows.Forms.Label dateRangeLabel;
    }
}



