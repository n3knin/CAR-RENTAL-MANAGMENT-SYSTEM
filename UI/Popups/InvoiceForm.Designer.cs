namespace RentalApp.UI.Popups
{
    partial class InvoiceForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtdeposit = new System.Windows.Forms.TextBox();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbPM = new System.Windows.Forms.ComboBox();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFC = new System.Windows.Forms.TextBox();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCF = new System.Windows.Forms.TextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.txtLF = new System.Windows.Forms.TextBox();
            this.txtBC = new System.Windows.Forms.TextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtAR = new System.Windows.Forms.TextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpERD = new System.Windows.Forms.DateTimePicker();
            this.dtpSRD = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btcancel = new System.Windows.Forms.Button();
            this.btcheckout = new System.Windows.Forms.Button();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(260, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(148, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "PROCESS PAYMENT";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click_1);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(13, 76);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(134, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Customer\'s Name:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.txtdeposit);
            this.panel1.Controls.Add(this.materialLabel18);
            this.panel1.Controls.Add(this.cmbPM);
            this.panel1.Controls.Add(this.materialLabel17);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtBC);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.txtAR);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.dtpERD);
            this.panel1.Controls.Add(this.dtpSRD);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.cmbVT);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Location = new System.Drawing.Point(22, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(718, 392);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtdeposit
            // 
            this.txtdeposit.Location = new System.Drawing.Point(420, 186);
            this.txtdeposit.Name = "txtdeposit";
            this.txtdeposit.ReadOnly = true;
            this.txtdeposit.Size = new System.Drawing.Size(135, 20);
            this.txtdeposit.TabIndex = 22;
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel18.Location = new System.Drawing.Point(282, 186);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(142, 19);
            this.materialLabel18.TabIndex = 21;
            this.materialLabel18.Text = "Deposited Amount: ";
            // 
            // cmbPM
            // 
            this.cmbPM.FormattingEnabled = true;
            this.cmbPM.Location = new System.Drawing.Point(412, 150);
            this.cmbPM.Name = "cmbPM";
            this.cmbPM.Size = new System.Drawing.Size(117, 21);
            this.cmbPM.TabIndex = 20;
            this.cmbPM.SelectedIndexChanged += new System.EventHandler(this.cmbPM_SelectedIndexChanged);
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel17.Location = new System.Drawing.Point(282, 150);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(126, 19);
            this.materialLabel17.TabIndex = 19;
            this.materialLabel17.Text = "Payment Method:";
            this.materialLabel17.Click += new System.EventHandler(this.materialLabel17_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Menu;
            this.panel3.Controls.Add(this.txtFC);
            this.panel3.Controls.Add(this.materialLabel13);
            this.panel3.Controls.Add(this.txtCF);
            this.panel3.Controls.Add(this.materialLabel12);
            this.panel3.Controls.Add(this.textBox3);
            this.panel3.Controls.Add(this.materialLabel11);
            this.panel3.Controls.Add(this.materialLabel10);
            this.panel3.Controls.Add(this.materialLabel9);
            this.panel3.Controls.Add(this.txtLF);
            this.panel3.Location = new System.Drawing.Point(16, 213);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(689, 160);
            this.panel3.TabIndex = 18;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // txtFC
            // 
            this.txtFC.Location = new System.Drawing.Point(408, 79);
            this.txtFC.Name = "txtFC";
            this.txtFC.Size = new System.Drawing.Size(141, 20);
            this.txtFC.TabIndex = 24;
            this.txtFC.TextChanged += new System.EventHandler(this.txtFC_TextChanged);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel13.Location = new System.Drawing.Point(306, 77);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(96, 19);
            this.materialLabel13.TabIndex = 23;
            this.materialLabel13.Text = "Fuel Charge: ";
            this.materialLabel13.Click += new System.EventHandler(this.materialLabel13_Click);
            // 
            // txtCF
            // 
            this.txtCF.Location = new System.Drawing.Point(408, 41);
            this.txtCF.Name = "txtCF";
            this.txtCF.Size = new System.Drawing.Size(141, 20);
            this.txtCF.TabIndex = 22;
            this.txtCF.TextChanged += new System.EventHandler(this.txtCF_TextChanged);
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel12.Location = new System.Drawing.Point(306, 42);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(99, 19);
            this.materialLabel12.TabIndex = 21;
            this.materialLabel12.Text = "Cleaning Fee:";
            this.materialLabel12.Click += new System.EventHandler(this.materialLabel12_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(113, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(141, 20);
            this.textBox3.TabIndex = 20;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel11.Location = new System.Drawing.Point(18, 78);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(96, 19);
            this.materialLabel11.TabIndex = 19;
            this.materialLabel11.Text = "Damage Fee:";
            this.materialLabel11.Click += new System.EventHandler(this.materialLabel11_Click);
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel10.Location = new System.Drawing.Point(18, 42);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(70, 19);
            this.materialLabel10.TabIndex = 18;
            this.materialLabel10.Text = "Late Fee:";
            this.materialLabel10.Click += new System.EventHandler(this.materialLabel10_Click);
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.SystemColors.Info;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel9.Location = new System.Drawing.Point(266, 8);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(136, 19);
            this.materialLabel9.TabIndex = 17;
            this.materialLabel9.Text = "Addtional Charges:";
            this.materialLabel9.Click += new System.EventHandler(this.materialLabel9_Click);
            // 
            // txtLF
            // 
            this.txtLF.Location = new System.Drawing.Point(90, 41);
            this.txtLF.Name = "txtLF";
            this.txtLF.ReadOnly = true;
            this.txtLF.Size = new System.Drawing.Size(141, 20);
            this.txtLF.TabIndex = 8;
            this.txtLF.TextChanged += new System.EventHandler(this.txtLF_TextChanged);
            // 
            // txtBC
            // 
            this.txtBC.Location = new System.Drawing.Point(106, 187);
            this.txtBC.Name = "txtBC";
            this.txtBC.ReadOnly = true;
            this.txtBC.Size = new System.Drawing.Size(141, 20);
            this.txtBC.TabIndex = 16;
            this.txtBC.TextChanged += new System.EventHandler(this.txtBC_TextChanged);
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(12, 186);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(97, 19);
            this.materialLabel8.TabIndex = 15;
            this.materialLabel8.Text = "Base Charge:";
            this.materialLabel8.Click += new System.EventHandler(this.materialLabel8_Click);
            // 
            // txtAR
            // 
            this.txtAR.Location = new System.Drawing.Point(106, 151);
            this.txtAR.Name = "txtAR";
            this.txtAR.ReadOnly = true;
            this.txtAR.Size = new System.Drawing.Size(141, 20);
            this.txtAR.TabIndex = 14;
            this.txtAR.TextChanged += new System.EventHandler(this.txtAR_TextChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(12, 152);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(101, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Applied Rate: ";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // dtpERD
            // 
            this.dtpERD.Enabled = false;
            this.dtpERD.Location = new System.Drawing.Point(484, 115);
            this.dtpERD.Name = "dtpERD";
            this.dtpERD.Size = new System.Drawing.Size(222, 20);
            this.dtpERD.TabIndex = 12;
            this.dtpERD.ValueChanged += new System.EventHandler(this.dtpERD_ValueChanged);
            // 
            // dtpSRD
            // 
            this.dtpSRD.Enabled = false;
            this.dtpSRD.Location = new System.Drawing.Point(129, 113);
            this.dtpSRD.Name = "dtpSRD";
            this.dtpSRD.Size = new System.Drawing.Size(221, 20);
            this.dtpSRD.TabIndex = 11;
            this.dtpSRD.ValueChanged += new System.EventHandler(this.dtpSRD_ValueChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(371, 115);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(107, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "End Rent Date:";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // cmbVT
            // 
            this.cmbVT.Enabled = false;
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(602, 74);
            this.cmbVT.Name = "cmbVT";
            this.cmbVT.Size = new System.Drawing.Size(104, 21);
            this.cmbVT.TabIndex = 9;
            this.cmbVT.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(561, 77);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(49, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Type: ";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 114);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(114, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Start Rent Date:";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(424, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(141, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(313, 77);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(117, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Vehicle Rented: ";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.panel2.Controls.Add(this.materialLabel1);
            this.panel2.Location = new System.Drawing.Point(16, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 45);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Controls.Add(this.btcancel);
            this.panel4.Controls.Add(this.btcheckout);
            this.panel4.Controls.Add(this.materialLabel16);
            this.panel4.Controls.Add(this.materialLabel15);
            this.panel4.Controls.Add(this.materialLabel14);
            this.panel4.Location = new System.Drawing.Point(25, 453);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(714, 86);
            this.panel4.TabIndex = 3;
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // btcancel
            // 
            this.btcancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancel.Location = new System.Drawing.Point(558, 28);
            this.btcancel.Name = "btcancel";
            this.btcancel.Size = new System.Drawing.Size(144, 42);
            this.btcancel.TabIndex = 29;
            this.btcancel.Text = "CANCEL";
            this.btcancel.UseVisualStyleBackColor = true;
            this.btcancel.Click += new System.EventHandler(this.btcancel_Click);
            // 
            // btcheckout
            // 
            this.btcheckout.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btcheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcheckout.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcheckout.Location = new System.Drawing.Point(397, 28);
            this.btcheckout.Name = "btcheckout";
            this.btcheckout.Size = new System.Drawing.Size(144, 42);
            this.btcheckout.TabIndex = 28;
            this.btcheckout.Text = "CHECKOUT";
            this.btcheckout.UseVisualStyleBackColor = false;
            this.btcheckout.Click += new System.EventHandler(this.btcheckout_Click);
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel16.Location = new System.Drawing.Point(44, 42);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(73, 19);
            this.materialLabel16.TabIndex = 27;
            this.materialLabel16.Text = "12345657";
            this.materialLabel16.Click += new System.EventHandler(this.materialLabel16_Click);
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel15.Location = new System.Drawing.Point(7, 42);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(19, 19);
            this.materialLabel15.TabIndex = 26;
            this.materialLabel15.Text = "₱";
            this.materialLabel15.Click += new System.EventHandler(this.materialLabel15_Click_1);
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel14.Location = new System.Drawing.Point(9, 11);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(109, 19);
            this.materialLabel14.TabIndex = 25;
            this.materialLabel14.Text = "Total Amount: ";
            this.materialLabel14.Click += new System.EventHandler(this.materialLabel14_Click);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 551);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "InvoiceForm";
            this.Text = "InvoiceForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DateTimePicker dtpERD;
        private System.Windows.Forms.DateTimePicker dtpSRD;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.ComboBox cmbVT;
        private System.Windows.Forms.TextBox txtLF;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.TextBox txtBC;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.TextBox txtAR;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.TextBox txtCF;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private System.Windows.Forms.TextBox textBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private System.Windows.Forms.TextBox txtFC;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private System.Windows.Forms.Button btcheckout;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private System.Windows.Forms.ComboBox cmbPM;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private System.Windows.Forms.Button btcancel;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private System.Windows.Forms.TextBox txtdeposit;
    }
}