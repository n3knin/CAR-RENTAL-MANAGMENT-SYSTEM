namespace RentalApp.UI.Popups
{
    partial class InspectionForm
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
            this.chkHasDamage = new System.Windows.Forms.CheckBox();
            this.pnlDamage = new System.Windows.Forms.Panel();
            this.txtDamageCost = new System.Windows.Forms.TextBox();
            this.cmbDamageSeverity = new System.Windows.Forms.ComboBox();
            this.txtDamageLocation = new System.Windows.Forms.TextBox();
            this.cmbDamageType = new System.Windows.Forms.ComboBox();
            this.materialLabel16 = new System.Windows.Forms.Label();
            this.materialLabel15 = new System.Windows.Forms.Label();
            this.materialLabel14 = new System.Windows.Forms.Label();
            this.materialLabel13 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialLabel12 = new System.Windows.Forms.Label();
            this.cnbt = new System.Windows.Forms.Button();
            this.svbt = new System.Windows.Forms.Button();
            this.caNobt = new System.Windows.Forms.RadioButton();
            this.caYesbt = new System.Windows.Forms.RadioButton();
            this.svNobt = new System.Windows.Forms.RadioButton();
            this.svYesbt = new System.Windows.Forms.RadioButton();
            this.cmbFL = new System.Windows.Forms.ComboBox();
            this.cmbEC = new System.Windows.Forms.ComboBox();
            this.cmbIC = new System.Windows.Forms.ComboBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtem = new System.Windows.Forms.TextBox();
            this.txtsm = new System.Windows.Forms.TextBox();
            this.txtcstmr = new System.Windows.Forms.TextBox();
            this.txtrsv = new System.Windows.Forms.TextBox();
            this.materialLabel11 = new System.Windows.Forms.Label();
            this.materialLabel10 = new System.Windows.Forms.Label();
            this.materialLabel9 = new System.Windows.Forms.Label();
            this.materialLabel8 = new System.Windows.Forms.Label();
            this.materialLabel7 = new System.Windows.Forms.Label();
            this.materialLabel6 = new System.Windows.Forms.Label();
            this.materialLabel5 = new System.Windows.Forms.Label();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlDamage.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chkHasDamage);
            this.panel1.Controls.Add(this.pnlDamage);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.materialLabel12);
            this.panel1.Controls.Add(this.cnbt);
            this.panel1.Controls.Add(this.svbt);
            this.panel1.Controls.Add(this.caNobt);
            this.panel1.Controls.Add(this.caYesbt);
            this.panel1.Controls.Add(this.svNobt);
            this.panel1.Controls.Add(this.svYesbt);
            this.panel1.Controls.Add(this.cmbFL);
            this.panel1.Controls.Add(this.cmbEC);
            this.panel1.Controls.Add(this.cmbIC);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.txtem);
            this.panel1.Controls.Add(this.txtsm);
            this.panel1.Controls.Add(this.txtcstmr);
            this.panel1.Controls.Add(this.txtrsv);
            this.panel1.Controls.Add(this.materialLabel11);
            this.panel1.Controls.Add(this.materialLabel10);
            this.panel1.Controls.Add(this.materialLabel9);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 826);
            this.panel1.TabIndex = 0;
            // 
            // chkHasDamage
            // 
            this.chkHasDamage.AutoSize = true;
            this.chkHasDamage.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkHasDamage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.chkHasDamage.Location = new System.Drawing.Point(25, 425);
            this.chkHasDamage.Name = "chkHasDamage";
            this.chkHasDamage.Size = new System.Drawing.Size(154, 23);
            this.chkHasDamage.TabIndex = 28;
            this.chkHasDamage.Text = "Damage Detected?";
            this.chkHasDamage.UseVisualStyleBackColor = true;
            this.chkHasDamage.CheckedChanged += new System.EventHandler(this.chkHasDamage_CheckedChanged);
            // 
            // pnlDamage
            // 
            this.pnlDamage.BackColor = System.Drawing.Color.LightGray;
            this.pnlDamage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDamage.Controls.Add(this.txtDamageCost);
            this.pnlDamage.Controls.Add(this.cmbDamageSeverity);
            this.pnlDamage.Controls.Add(this.txtDamageLocation);
            this.pnlDamage.Controls.Add(this.cmbDamageType);
            this.pnlDamage.Controls.Add(this.materialLabel16);
            this.pnlDamage.Controls.Add(this.materialLabel15);
            this.pnlDamage.Controls.Add(this.materialLabel14);
            this.pnlDamage.Controls.Add(this.materialLabel13);
            this.pnlDamage.Enabled = false;
            this.pnlDamage.Location = new System.Drawing.Point(20, 455);
            this.pnlDamage.Name = "pnlDamage";
            this.pnlDamage.Size = new System.Drawing.Size(560, 140);
            this.pnlDamage.TabIndex = 29;
            this.pnlDamage.Visible = true;
            // 
            // txtDamageCost
            // 
            this.txtDamageCost.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDamageCost.Location = new System.Drawing.Point(420, 85);
            this.txtDamageCost.Name = "txtDamageCost";
            this.txtDamageCost.Size = new System.Drawing.Size(120, 25);
            this.txtDamageCost.TabIndex = 7;
            this.txtDamageCost.Text = "0.00";
            // 
            // cmbDamageSeverity
            // 
            this.cmbDamageSeverity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDamageSeverity.FormattingEnabled = true;
            this.cmbDamageSeverity.Location = new System.Drawing.Point(120, 85);
            this.cmbDamageSeverity.Name = "cmbDamageSeverity";
            this.cmbDamageSeverity.Size = new System.Drawing.Size(150, 25);
            this.cmbDamageSeverity.TabIndex = 6;
            // 
            // txtDamageLocation
            // 
            this.txtDamageLocation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDamageLocation.Location = new System.Drawing.Point(120, 45);
            this.txtDamageLocation.Name = "txtDamageLocation";
            this.txtDamageLocation.Size = new System.Drawing.Size(420, 25);
            this.txtDamageLocation.TabIndex = 5;
            // 
            // cmbDamageType
            // 
            this.cmbDamageType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDamageType.FormattingEnabled = true;
            this.cmbDamageType.Location = new System.Drawing.Point(120, 5);
            this.cmbDamageType.Name = "cmbDamageType";
            this.cmbDamageType.Size = new System.Drawing.Size(200, 25);
            this.cmbDamageType.TabIndex = 4;
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel16.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel16.Location = new System.Drawing.Point(300, 90);
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(89, 15);
            this.materialLabel16.TabIndex = 3;
            this.materialLabel16.Text = "Estimated Cost:";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel15.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel15.Location = new System.Drawing.Point(5, 90);
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(51, 15);
            this.materialLabel15.TabIndex = 2;
            this.materialLabel15.Text = "Severity:";
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel14.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel14.Location = new System.Drawing.Point(5, 50);
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(56, 15);
            this.materialLabel14.TabIndex = 1;
            this.materialLabel14.Text = "Location:";
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel13.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel13.Location = new System.Drawing.Point(5, 10);
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(82, 15);
            this.materialLabel13.TabIndex = 0;
            this.materialLabel13.Text = "Damage Type:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBox1.Location = new System.Drawing.Point(25, 635);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(540, 100);
            this.textBox1.TabIndex = 27;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel12.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel12.Location = new System.Drawing.Point(21, 610);
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(41, 15);
            this.materialLabel12.TabIndex = 26;
            this.materialLabel12.Text = "Notes:";
            // 
            // cnbt
            // 
            this.cnbt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cnbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnbt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cnbt.ForeColor = System.Drawing.Color.DimGray;
            this.cnbt.Location = new System.Drawing.Point(325, 755);
            this.cnbt.Name = "cnbt";
            this.cnbt.Size = new System.Drawing.Size(140, 45);
            this.cnbt.TabIndex = 25;
            this.cnbt.Text = "CANCEL";
            this.cnbt.UseVisualStyleBackColor = false;
            this.cnbt.Click += new System.EventHandler(this.cnbt_Click);
            // 
            // svbt
            // 
            this.svbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.svbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.svbt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.svbt.ForeColor = System.Drawing.Color.White;
            this.svbt.Location = new System.Drawing.Point(80, 755);
            this.svbt.Name = "svbt";
            this.svbt.Size = new System.Drawing.Size(200, 45);
            this.svbt.TabIndex = 24;
            this.svbt.Text = "SAVE AND RETURN";
            this.svbt.UseVisualStyleBackColor = false;
            this.svbt.Click += new System.EventHandler(this.svbt_Click);
            // 
            // caNobt
            // 
            this.caNobt.AutoSize = true;
            this.caNobt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.caNobt.Location = new System.Drawing.Point(250, 390);
            this.caNobt.Name = "caNobt";
            this.caNobt.Size = new System.Drawing.Size(45, 23);
            this.caNobt.TabIndex = 23;
            this.caNobt.TabStop = true;
            this.caNobt.Text = "No";
            this.caNobt.UseVisualStyleBackColor = true;
            this.caNobt.CheckedChanged += new System.EventHandler(this.caNobt_CheckedChanged);
            // 
            // caYesbt
            // 
            this.caYesbt.AutoSize = true;
            this.caYesbt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.caYesbt.Location = new System.Drawing.Point(190, 390);
            this.caYesbt.Name = "caYesbt";
            this.caYesbt.Size = new System.Drawing.Size(47, 23);
            this.caYesbt.TabIndex = 22;
            this.caYesbt.TabStop = true;
            this.caYesbt.Text = "Yes";
            this.caYesbt.UseVisualStyleBackColor = true;
            this.caYesbt.CheckedChanged += new System.EventHandler(this.caYesbt_CheckedChanged);
            // 
            // svNobt
            // 
            this.svNobt.AutoSize = true;
            this.svNobt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.svNobt.Location = new System.Drawing.Point(250, 350);
            this.svNobt.Name = "svNobt";
            this.svNobt.Size = new System.Drawing.Size(45, 23);
            this.svNobt.TabIndex = 21;
            this.svNobt.TabStop = true;
            this.svNobt.Text = "No";
            this.svNobt.UseVisualStyleBackColor = true;
            this.svNobt.CheckedChanged += new System.EventHandler(this.svNobt_CheckedChanged);
            // 
            // svYesbt
            // 
            this.svYesbt.AutoSize = true;
            this.svYesbt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.svYesbt.Location = new System.Drawing.Point(190, 350);
            this.svYesbt.Name = "svYesbt";
            this.svYesbt.Size = new System.Drawing.Size(47, 23);
            this.svYesbt.TabIndex = 20;
            this.svYesbt.TabStop = true;
            this.svYesbt.Text = "Yes";
            this.svYesbt.UseVisualStyleBackColor = true;
            this.svYesbt.CheckedChanged += new System.EventHandler(this.svYesbt_CheckedChanged);
            // 
            // cmbFL
            // 
            this.cmbFL.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbFL.FormattingEnabled = true;
            this.cmbFL.Location = new System.Drawing.Point(190, 310);
            this.cmbFL.Name = "cmbFL";
            this.cmbFL.Size = new System.Drawing.Size(150, 25);
            this.cmbFL.TabIndex = 19;
            this.cmbFL.SelectedIndexChanged += new System.EventHandler(this.cmbFL_SelectedIndexChanged);
            // 
            // cmbEC
            // 
            this.cmbEC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEC.FormattingEnabled = true;
            this.cmbEC.Location = new System.Drawing.Point(190, 270);
            this.cmbEC.Name = "cmbEC";
            this.cmbEC.Size = new System.Drawing.Size(250, 25);
            this.cmbEC.TabIndex = 18;
            this.cmbEC.SelectedIndexChanged += new System.EventHandler(this.cmbEC_SelectedIndexChanged);
            // 
            // cmbIC
            // 
            this.cmbIC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIC.FormattingEnabled = true;
            this.cmbIC.Location = new System.Drawing.Point(190, 230);
            this.cmbIC.Name = "cmbIC";
            this.cmbIC.Size = new System.Drawing.Size(250, 25);
            this.cmbIC.TabIndex = 17;
            this.cmbIC.SelectedIndexChanged += new System.EventHandler(this.cmbIC_SelectedIndexChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker2.Location = new System.Drawing.Point(190, 190);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(250, 25);
            this.dateTimePicker2.TabIndex = 16;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dateTimePicker1.Location = new System.Drawing.Point(190, 150);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 25);
            this.dateTimePicker1.TabIndex = 15;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtem
            // 
            this.txtem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtem.Location = new System.Drawing.Point(420, 110);
            this.txtem.Name = "txtem";
            this.txtem.Size = new System.Drawing.Size(140, 25);
            this.txtem.TabIndex = 14;
            this.txtem.TextChanged += new System.EventHandler(this.txtem_TextChanged);
            // 
            // txtsm
            // 
            this.txtsm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtsm.Location = new System.Drawing.Point(150, 110);
            this.txtsm.Name = "txtsm";
            this.txtsm.ReadOnly = true;
            this.txtsm.Size = new System.Drawing.Size(110, 25);
            this.txtsm.TabIndex = 13;
            this.txtsm.TextChanged += new System.EventHandler(this.txtsm_TextChanged);
            // 
            // txtcstmr
            // 
            this.txtcstmr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtcstmr.Location = new System.Drawing.Point(420, 70);
            this.txtcstmr.Name = "txtcstmr";
            this.txtcstmr.ReadOnly = true;
            this.txtcstmr.Size = new System.Drawing.Size(140, 25);
            this.txtcstmr.TabIndex = 12;
            this.txtcstmr.TextChanged += new System.EventHandler(this.txtcstmr_TextChanged);
            // 
            // txtrsv
            // 
            this.txtrsv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtrsv.Location = new System.Drawing.Point(150, 70);
            this.txtrsv.Name = "txtrsv";
            this.txtrsv.ReadOnly = true;
            this.txtrsv.Size = new System.Drawing.Size(110, 25);
            this.txtrsv.TabIndex = 11;
            this.txtrsv.TextChanged += new System.EventHandler(this.txtrsv_TextChanged);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel11.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel11.Location = new System.Drawing.Point(21, 355);
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(110, 15);
            this.materialLabel11.TabIndex = 10;
            this.materialLabel11.Text = "Smoking Violation: ";
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel10.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel10.Location = new System.Drawing.Point(21, 395);
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(121, 15);
            this.materialLabel10.TabIndex = 9;
            this.materialLabel10.Text = "Complete Accesories:";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel9.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel9.Location = new System.Drawing.Point(21, 315);
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(62, 15);
            this.materialLabel9.TabIndex = 8;
            this.materialLabel9.Text = "Fuel Level:";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel8.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel8.Location = new System.Drawing.Point(21, 275);
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(105, 15);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Exterior Condition:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel7.Location = new System.Drawing.Point(21, 235);
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(104, 15);
            this.materialLabel7.TabIndex = 6;
            this.materialLabel7.Text = "Interior Condition:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel6.Location = new System.Drawing.Point(21, 195);
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(109, 15);
            this.materialLabel6.TabIndex = 5;
            this.materialLabel6.Text = "Actual Return Date:";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel5.Location = new System.Drawing.Point(21, 155);
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(122, 15);
            this.materialLabel5.TabIndex = 4;
            this.materialLabel5.Text = "Expected Return Date:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel4.Location = new System.Drawing.Point(280, 75);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(105, 15);
            this.materialLabel4.TabIndex = 3;
            this.materialLabel4.Text = "Customer\'s Name:";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel3.Location = new System.Drawing.Point(280, 115);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 15);
            this.materialLabel3.TabIndex = 2;
            this.materialLabel3.Text = "Ending Mileage:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel2.Location = new System.Drawing.Point(21, 115);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 15);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Starting Mileage:";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel1.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel1.Location = new System.Drawing.Point(21, 75);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(85, 15);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Reservation ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(221, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Vehicle Inspection";
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(600, 826);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InspectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Vehicle Inspection";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDamage.ResumeLayout(false);
            this.pnlDamage.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.Label materialLabel4;
        private System.Windows.Forms.Label materialLabel5;
        private System.Windows.Forms.Label materialLabel6;
        private System.Windows.Forms.Label materialLabel7;
        private System.Windows.Forms.Label materialLabel8;
        private System.Windows.Forms.Label materialLabel9;
        private System.Windows.Forms.Label materialLabel10;
        private System.Windows.Forms.Label materialLabel11;
        private System.Windows.Forms.TextBox txtrsv;
        private System.Windows.Forms.TextBox txtcstmr;
        private System.Windows.Forms.TextBox txtsm;
        private System.Windows.Forms.TextBox txtem;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox cmbIC;
        private System.Windows.Forms.ComboBox cmbEC;
        private System.Windows.Forms.ComboBox cmbFL;
        private System.Windows.Forms.RadioButton svYesbt;
        private System.Windows.Forms.RadioButton svNobt;
        private System.Windows.Forms.RadioButton caYesbt;
        private System.Windows.Forms.RadioButton caNobt;
        private System.Windows.Forms.Button svbt;
        private System.Windows.Forms.Button cnbt;
        private System.Windows.Forms.Label materialLabel12;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox chkHasDamage;
        private System.Windows.Forms.Panel pnlDamage;
        private System.Windows.Forms.Label materialLabel13;
        private System.Windows.Forms.Label materialLabel14;
        private System.Windows.Forms.Label materialLabel15;
        private System.Windows.Forms.Label materialLabel16;
        private System.Windows.Forms.ComboBox cmbDamageType;
        private System.Windows.Forms.TextBox txtDamageLocation;
        private System.Windows.Forms.ComboBox cmbDamageSeverity;
        private System.Windows.Forms.TextBox txtDamageCost;
    }
}