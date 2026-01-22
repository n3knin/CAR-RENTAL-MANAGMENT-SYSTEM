namespace RentalApp.UI.Popups
{
    partial class STARTrentalform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpRentalDetails = new System.Windows.Forms.GroupBox();
            this.cmbrenttype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdeposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.expectreturndt = new System.Windows.Forms.DateTimePicker();
            this.materialLabel8 = new System.Windows.Forms.Label();
            this.pickupdt = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new System.Windows.Forms.Label();
            this.lblmileage = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new System.Windows.Forms.Label();
            this.grpReservationInfo = new System.Windows.Forms.GroupBox();
            this.vehicletxt = new System.Windows.Forms.Label();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.txtcstmr = new System.Windows.Forms.Label();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.rsvtnID = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cnclbttn = new System.Windows.Forms.Button();
            this.strtbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpRentalDetails.SuspendLayout();
            this.grpReservationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.grpRentalDetails);
            this.panel1.Controls.Add(this.grpReservationInfo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.cnclbttn);
            this.panel1.Controls.Add(this.strtbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 581);
            this.panel1.TabIndex = 0;
            // 
            // grpRentalDetails
            // 
            this.grpRentalDetails.Controls.Add(this.cmbrenttype);
            this.grpRentalDetails.Controls.Add(this.label2);
            this.grpRentalDetails.Controls.Add(this.txtdeposit);
            this.grpRentalDetails.Controls.Add(this.label1);
            this.grpRentalDetails.Controls.Add(this.expectreturndt);
            this.grpRentalDetails.Controls.Add(this.materialLabel8);
            this.grpRentalDetails.Controls.Add(this.pickupdt);
            this.grpRentalDetails.Controls.Add(this.materialLabel6);
            this.grpRentalDetails.Controls.Add(this.lblmileage);
            this.grpRentalDetails.Controls.Add(this.materialLabel5);
            this.grpRentalDetails.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpRentalDetails.Location = new System.Drawing.Point(19, 187);
            this.grpRentalDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRentalDetails.Name = "grpRentalDetails";
            this.grpRentalDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpRentalDetails.Size = new System.Drawing.Size(338, 309);
            this.grpRentalDetails.TabIndex = 17;
            this.grpRentalDetails.TabStop = false;
            this.grpRentalDetails.Text = "Rental Details";
            // 
            // cmbrenttype
            // 
            this.cmbrenttype.FormattingEnabled = true;
            this.cmbrenttype.Location = new System.Drawing.Point(19, 51);
            this.cmbrenttype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbrenttype.Name = "cmbrenttype";
            this.cmbrenttype.Size = new System.Drawing.Size(301, 25);
            this.cmbrenttype.TabIndex = 15;
            this.cmbrenttype.SelectedIndexChanged += new System.EventHandler(this.cmbrenttype_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(16, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Rent Type:";
            // 
            // txtdeposit
            // 
            this.txtdeposit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtdeposit.Location = new System.Drawing.Point(19, 96);
            this.txtdeposit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdeposit.Name = "txtdeposit";
            this.txtdeposit.Size = new System.Drawing.Size(301, 25);
            this.txtdeposit.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 15);
            this.label1.TabIndex = 18;
            this.label1.Text = "Deposited Amount:";
            // 
            // expectreturndt
            // 
            this.expectreturndt.Enabled = false;
            this.expectreturndt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.expectreturndt.Location = new System.Drawing.Point(19, 252);
            this.expectreturndt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.expectreturndt.Name = "expectreturndt";
            this.expectreturndt.Size = new System.Drawing.Size(301, 25);
            this.expectreturndt.TabIndex = 17;
            this.expectreturndt.ValueChanged += new System.EventHandler(this.expectreturndt_ValueChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel8.Location = new System.Drawing.Point(16, 232);
            this.materialLabel8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(122, 15);
            this.materialLabel8.TabIndex = 16;
            this.materialLabel8.Text = "Expected Return Date:";
            // 
            // pickupdt
            // 
            this.pickupdt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pickupdt.Location = new System.Drawing.Point(19, 196);
            this.pickupdt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pickupdt.Name = "pickupdt";
            this.pickupdt.Size = new System.Drawing.Size(301, 25);
            this.pickupdt.TabIndex = 8;
            this.pickupdt.ValueChanged += new System.EventHandler(this.pickupdt_ValueChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel6.Location = new System.Drawing.Point(16, 175);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(73, 15);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Pickup Date:";
            // 
            // lblmileage
            // 
            this.lblmileage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblmileage.Location = new System.Drawing.Point(19, 143);
            this.lblmileage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lblmileage.Name = "lblmileage";
            this.lblmileage.ReadOnly = true;
            this.lblmileage.Size = new System.Drawing.Size(301, 25);
            this.lblmileage.TabIndex = 11;
            this.lblmileage.TextChanged += new System.EventHandler(this.lblmileage_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel5.Location = new System.Drawing.Point(16, 122);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(96, 15);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Starting Mileage:";
            // 
            // grpReservationInfo
            // 
            this.grpReservationInfo.Controls.Add(this.vehicletxt);
            this.grpReservationInfo.Controls.Add(this.materialLabel4);
            this.grpReservationInfo.Controls.Add(this.txtcstmr);
            this.grpReservationInfo.Controls.Add(this.materialLabel3);
            this.grpReservationInfo.Controls.Add(this.rsvtnID);
            this.grpReservationInfo.Controls.Add(this.materialLabel1);
            this.grpReservationInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpReservationInfo.Location = new System.Drawing.Point(19, 57);
            this.grpReservationInfo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpReservationInfo.Name = "grpReservationInfo";
            this.grpReservationInfo.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpReservationInfo.Size = new System.Drawing.Size(338, 122);
            this.grpReservationInfo.TabIndex = 16;
            this.grpReservationInfo.TabStop = false;
            this.grpReservationInfo.Text = "Reservation Info";
            this.grpReservationInfo.Enter += new System.EventHandler(this.grpReservationInfo_Enter);
            // 
            // vehicletxt
            // 
            this.vehicletxt.AutoSize = true;
            this.vehicletxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.vehicletxt.ForeColor = System.Drawing.Color.Black;
            this.vehicletxt.Location = new System.Drawing.Point(112, 89);
            this.vehicletxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vehicletxt.Name = "vehicletxt";
            this.vehicletxt.Size = new System.Drawing.Size(100, 19);
            this.vehicletxt.TabIndex = 13;
            this.vehicletxt.Text = "Vehicle Name";
            this.vehicletxt.Click += new System.EventHandler(this.vehicletxt_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel4.Location = new System.Drawing.Point(16, 91);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 15);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Vehicle:";
            // 
            // txtcstmr
            // 
            this.txtcstmr.AutoSize = true;
            this.txtcstmr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtcstmr.ForeColor = System.Drawing.Color.Black;
            this.txtcstmr.Location = new System.Drawing.Point(112, 57);
            this.txtcstmr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtcstmr.Name = "txtcstmr";
            this.txtcstmr.Size = new System.Drawing.Size(117, 19);
            this.txtcstmr.TabIndex = 14;
            this.txtcstmr.Text = "Customer Name";
            this.txtcstmr.Click += new System.EventHandler(this.materialLabel8_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel3.Location = new System.Drawing.Point(16, 58);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(62, 15);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "Customer:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // rsvtnID
            // 
            this.rsvtnID.AutoSize = true;
            this.rsvtnID.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.rsvtnID.ForeColor = System.Drawing.Color.Black;
            this.rsvtnID.Location = new System.Drawing.Point(112, 24);
            this.rsvtnID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rsvtnID.Name = "rsvtnID";
            this.rsvtnID.Size = new System.Drawing.Size(17, 19);
            this.rsvtnID.TabIndex = 12;
            this.rsvtnID.Text = "0";
            this.rsvtnID.Click += new System.EventHandler(this.rsvtnID_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel1.Location = new System.Drawing.Point(16, 26);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 15);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Reservation ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblTitle.Location = new System.Drawing.Point(15, 16);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(147, 32);
            this.lblTitle.TabIndex = 15;
            this.lblTitle.Text = "Start Rental";
            // 
            // cnclbttn
            // 
            this.cnclbttn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cnclbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnclbttn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cnclbttn.ForeColor = System.Drawing.Color.DimGray;
            this.cnclbttn.Location = new System.Drawing.Point(254, 522);
            this.cnclbttn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cnclbttn.Name = "cnclbttn";
            this.cnclbttn.Size = new System.Drawing.Size(105, 37);
            this.cnclbttn.TabIndex = 1;
            this.cnclbttn.Text = "Cancel";
            this.cnclbttn.UseVisualStyleBackColor = false;
            this.cnclbttn.Click += new System.EventHandler(this.cnclbttn_Click);
            // 
            // strtbtn
            // 
            this.strtbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.strtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strtbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.strtbtn.ForeColor = System.Drawing.Color.White;
            this.strtbtn.Location = new System.Drawing.Point(20, 522);
            this.strtbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.strtbtn.Name = "strtbtn";
            this.strtbtn.Size = new System.Drawing.Size(150, 37);
            this.strtbtn.TabIndex = 0;
            this.strtbtn.Text = "Start Rental";
            this.strtbtn.UseVisualStyleBackColor = false;
            this.strtbtn.Click += new System.EventHandler(this.strtbtn_Click);
            // 
            // STARTrentalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(375, 581);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "STARTrentalform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Start Rental";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grpRentalDetails.ResumeLayout(false);
            this.grpRentalDetails.PerformLayout();
            this.grpReservationInfo.ResumeLayout(false);
            this.grpReservationInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpReservationInfo;
        private System.Windows.Forms.GroupBox grpRentalDetails;
        private System.Windows.Forms.Button strtbtn;
        private System.Windows.Forms.Button cnclbttn;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label rsvtnID;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.Label txtcstmr;
        private System.Windows.Forms.Label materialLabel4;
        private System.Windows.Forms.Label vehicletxt;
        private System.Windows.Forms.Label materialLabel5;
        private System.Windows.Forms.TextBox lblmileage;
        private System.Windows.Forms.Label materialLabel6;
        private System.Windows.Forms.DateTimePicker pickupdt;
        private System.Windows.Forms.Label materialLabel8;
        private System.Windows.Forms.DateTimePicker expectreturndt;
        private System.Windows.Forms.TextBox txtdeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbrenttype;
        private System.Windows.Forms.Label label2;
    }
}