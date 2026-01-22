namespace RentalApp.UI.Popups
{
    partial class AddVehicleForm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpyear = new System.Windows.Forms.DateTimePicker();
            this.cmbmake = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialLabel13 = new System.Windows.Forms.Label();
            this.FEATURES = new System.Windows.Forms.CheckedListBox();
            this.seat = new System.Windows.Forms.NumericUpDown();
            this.materialLabel12 = new System.Windows.Forms.Label();
            this.materialLabel11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtmileage = new System.Windows.Forms.TextBox();
            this.txtvin = new System.Windows.Forms.TextBox();
            this.txtcolor = new System.Windows.Forms.TextBox();
            this.txtmodel = new System.Windows.Forms.TextBox();
            this.CATEGORYCMB = new System.Windows.Forms.ComboBox();
            this.materialLabel10 = new System.Windows.Forms.Label();
            this.BTNMANUAL = new System.Windows.Forms.RadioButton();
            this.BTNAUTOMATIC = new System.Windows.Forms.RadioButton();
            this.materialLabel9 = new System.Windows.Forms.Label();
            this.materialLabel8 = new System.Windows.Forms.Label();
            this.materialLabel7 = new System.Windows.Forms.Label();
            this.materialLabel6 = new System.Windows.Forms.Label();
            this.materialLabel5 = new System.Windows.Forms.Label();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnvhcl = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtlicense = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seat)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dtpyear);
            this.panel1.Controls.Add(this.cmbmake);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.materialLabel13);
            this.panel1.Controls.Add(this.FEATURES);
            this.panel1.Controls.Add(this.seat);
            this.panel1.Controls.Add(this.materialLabel12);
            this.panel1.Controls.Add(this.txtlicense);
            this.panel1.Controls.Add(this.materialLabel11);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.txtmileage);
            this.panel1.Controls.Add(this.txtvin);
            this.panel1.Controls.Add(this.txtcolor);
            this.panel1.Controls.Add(this.txtmodel);
            this.panel1.Controls.Add(this.CATEGORYCMB);
            this.panel1.Controls.Add(this.materialLabel10);
            this.panel1.Controls.Add(this.BTNMANUAL);
            this.panel1.Controls.Add(this.BTNAUTOMATIC);
            this.panel1.Controls.Add(this.materialLabel9);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.btncancel);
            this.panel1.Controls.Add(this.btnvhcl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 659);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dtpyear
            // 
            this.dtpyear.Location = new System.Drawing.Point(26, 180);
            this.dtpyear.Name = "dtpyear";
            this.dtpyear.Size = new System.Drawing.Size(200, 20);
            this.dtpyear.TabIndex = 35;
            this.dtpyear.ValueChanged += new System.EventHandler(this.dtpyear_ValueChanged);
            // 
            // cmbmake
            // 
            this.cmbmake.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbmake.FormattingEnabled = true;
            this.cmbmake.Location = new System.Drawing.Point(28, 122);
            this.cmbmake.Name = "cmbmake";
            this.cmbmake.Size = new System.Drawing.Size(200, 25);
            this.cmbmake.TabIndex = 34;
            this.cmbmake.SelectedIndexChanged += new System.EventHandler(this.cmbmake_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.label1.Location = new System.Drawing.Point(25, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Please fill up all fields.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel13.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel13.Location = new System.Drawing.Point(26, 414);
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(54, 15);
            this.materialLabel13.TabIndex = 32;
            this.materialLabel13.Text = "Features:";
            this.materialLabel13.Click += new System.EventHandler(this.materialLabel13_Click);
            // 
            // FEATURES
            // 
            this.FEATURES.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FEATURES.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FEATURES.FormattingEnabled = true;
            this.FEATURES.Location = new System.Drawing.Point(30, 440);
            this.FEATURES.Name = "FEATURES";
            this.FEATURES.Size = new System.Drawing.Size(441, 120);
            this.FEATURES.TabIndex = 31;
            this.FEATURES.SelectedIndexChanged += new System.EventHandler(this.FEATURES_SelectedIndexChanged);
            // 
            // seat
            // 
            this.seat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.seat.Location = new System.Drawing.Point(339, 349);
            this.seat.Name = "seat";
            this.seat.Size = new System.Drawing.Size(121, 25);
            this.seat.TabIndex = 30;
            this.seat.ValueChanged += new System.EventHandler(this.seat_ValueChanged);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel12.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel12.Location = new System.Drawing.Point(336, 328);
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(98, 15);
            this.materialLabel12.TabIndex = 29;
            this.materialLabel12.Text = "Seating Capacity:";
            this.materialLabel12.Click += new System.EventHandler(this.materialLabel12_Click);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel11.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel11.Location = new System.Drawing.Point(20, 217);
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(78, 15);
            this.materialLabel11.TabIndex = 27;
            this.materialLabel11.Text = "License Plate:";
            this.materialLabel11.Click += new System.EventHandler(this.materialLabel11_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 349);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(140, 25);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtmileage
            // 
            this.txtmileage.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmileage.Location = new System.Drawing.Point(256, 180);
            this.txtmileage.Name = "txtmileage";
            this.txtmileage.Size = new System.Drawing.Size(200, 25);
            this.txtmileage.TabIndex = 25;
            this.txtmileage.TextChanged += new System.EventHandler(this.txtmileage_TextChanged);
            // 
            // txtvin
            // 
            this.txtvin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtvin.Location = new System.Drawing.Point(254, 236);
            this.txtvin.Name = "txtvin";
            this.txtvin.Size = new System.Drawing.Size(200, 25);
            this.txtvin.TabIndex = 24;
            this.txtvin.Text = "Ex. 4Y1SL65848Z411439";
            this.txtvin.TextChanged += new System.EventHandler(this.txtvin_TextChanged);
            // 
            // txtcolor
            // 
            this.txtcolor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcolor.Location = new System.Drawing.Point(25, 293);
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.Size = new System.Drawing.Size(200, 25);
            this.txtcolor.TabIndex = 23;
            this.txtcolor.TextChanged += new System.EventHandler(this.txtcolor_TextChanged);
            // 
            // txtmodel
            // 
            this.txtmodel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtmodel.Location = new System.Drawing.Point(256, 124);
            this.txtmodel.Name = "txtmodel";
            this.txtmodel.Size = new System.Drawing.Size(200, 25);
            this.txtmodel.TabIndex = 21;
            this.txtmodel.TextChanged += new System.EventHandler(this.txtmodel_TextChanged);
            // 
            // CATEGORYCMB
            // 
            this.CATEGORYCMB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CATEGORYCMB.FormattingEnabled = true;
            this.CATEGORYCMB.Location = new System.Drawing.Point(254, 293);
            this.CATEGORYCMB.Name = "CATEGORYCMB";
            this.CATEGORYCMB.Size = new System.Drawing.Size(200, 25);
            this.CATEGORYCMB.TabIndex = 19;
            this.CATEGORYCMB.SelectedIndexChanged += new System.EventHandler(this.CATEGORYCMB_SelectedIndexChanged);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel10.Location = new System.Drawing.Point(251, 274);
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(35, 15);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Type:";
            this.materialLabel10.Click += new System.EventHandler(this.materialLabel10_Click);
            // 
            // BTNMANUAL
            // 
            this.BTNMANUAL.AutoSize = true;
            this.BTNMANUAL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNMANUAL.Location = new System.Drawing.Point(270, 388);
            this.BTNMANUAL.Name = "BTNMANUAL";
            this.BTNMANUAL.Size = new System.Drawing.Size(65, 19);
            this.BTNMANUAL.TabIndex = 17;
            this.BTNMANUAL.TabStop = true;
            this.BTNMANUAL.Text = "Manual";
            this.BTNMANUAL.UseVisualStyleBackColor = true;
            this.BTNMANUAL.CheckedChanged += new System.EventHandler(this.BTNMANUAL_CheckedChanged);
            // 
            // BTNAUTOMATIC
            // 
            this.BTNAUTOMATIC.AutoSize = true;
            this.BTNAUTOMATIC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BTNAUTOMATIC.Location = new System.Drawing.Point(180, 388);
            this.BTNAUTOMATIC.Name = "BTNAUTOMATIC";
            this.BTNAUTOMATIC.Size = new System.Drawing.Size(81, 19);
            this.BTNAUTOMATIC.TabIndex = 16;
            this.BTNAUTOMATIC.TabStop = true;
            this.BTNAUTOMATIC.Text = "Automatic";
            this.BTNAUTOMATIC.UseVisualStyleBackColor = true;
            this.BTNAUTOMATIC.CheckedChanged += new System.EventHandler(this.BTNAUTOMATIC_CheckedChanged);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel9.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel9.Location = new System.Drawing.Point(25, 388);
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(107, 15);
            this.materialLabel9.TabIndex = 15;
            this.materialLabel9.Text = "Transmission Type:";
            this.materialLabel9.Click += new System.EventHandler(this.materialLabel9_Click);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel8.Location = new System.Drawing.Point(25, 328);
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(60, 15);
            this.materialLabel8.TabIndex = 9;
            this.materialLabel8.Text = "Fuel Type:";
            this.materialLabel8.Click += new System.EventHandler(this.materialLabel8_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel7.Location = new System.Drawing.Point(254, 160);
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(52, 15);
            this.materialLabel7.TabIndex = 8;
            this.materialLabel7.Text = "Mileage:";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel6.Location = new System.Drawing.Point(250, 217);
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(29, 15);
            this.materialLabel6.TabIndex = 7;
            this.materialLabel6.Text = "VIN:";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel5.Location = new System.Drawing.Point(21, 274);
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(39, 15);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Color:";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel4.Location = new System.Drawing.Point(23, 160);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(32, 15);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Year:";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel3.Location = new System.Drawing.Point(254, 104);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(44, 15);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Model:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel2.Location = new System.Drawing.Point(25, 104);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(39, 15);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Make:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.materialLabel1.Location = new System.Drawing.Point(23, 20);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 32);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Add Vehicle";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btncancel.ForeColor = System.Drawing.Color.DimGray;
            this.btncancel.Location = new System.Drawing.Point(270, 591);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(186, 45);
            this.btncancel.TabIndex = 1;
            this.btncancel.Text = "CANCEL";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click_1);
            // 
            // btnvhcl
            // 
            this.btnvhcl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnvhcl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvhcl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnvhcl.ForeColor = System.Drawing.Color.White;
            this.btnvhcl.Location = new System.Drawing.Point(26, 591);
            this.btnvhcl.Name = "btnvhcl";
            this.btnvhcl.Size = new System.Drawing.Size(228, 45);
            this.btnvhcl.TabIndex = 0;
            this.btnvhcl.Text = "ADD VEHICLE";
            this.btnvhcl.UseVisualStyleBackColor = false;
            this.btnvhcl.Click += new System.EventHandler(this.btnvhcl_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // txtlicense
            // 
            this.txtlicense.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtlicense.Location = new System.Drawing.Point(23, 236);
            this.txtlicense.Name = "txtlicense";
            this.txtlicense.Size = new System.Drawing.Size(200, 25);
            this.txtlicense.TabIndex = 28;
            this.txtlicense.Text = "Ex.  ABC1234";
            this.txtlicense.TextChanged += new System.EventHandler(this.txtlicense_TextChanged);
            // 
            // AddVehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 659);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddVehicleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Vehicle";
            this.Load += new System.EventHandler(this.AddVehicleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seat)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnvhcl;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.Label materialLabel4;
        private System.Windows.Forms.Label materialLabel5;
        private System.Windows.Forms.Label materialLabel6;
        private System.Windows.Forms.Label materialLabel7;
        private System.Windows.Forms.Label materialLabel8;
        private System.Windows.Forms.Label materialLabel9;
        private System.Windows.Forms.RadioButton BTNAUTOMATIC;
        private System.Windows.Forms.RadioButton BTNMANUAL;
        private System.Windows.Forms.Label materialLabel10;
        private System.Windows.Forms.ComboBox CATEGORYCMB;
        private System.Windows.Forms.TextBox txtmodel;
        private System.Windows.Forms.TextBox txtcolor;
        private System.Windows.Forms.TextBox txtvin;
        private System.Windows.Forms.TextBox txtmileage;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label materialLabel11;
        private System.Windows.Forms.Label materialLabel12;
        private System.Windows.Forms.NumericUpDown seat;
        private System.Windows.Forms.CheckedListBox FEATURES;
        private System.Windows.Forms.Label materialLabel13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpyear;
        private System.Windows.Forms.ComboBox cmbmake;
        private System.Windows.Forms.TextBox txtlicense;
    }
}