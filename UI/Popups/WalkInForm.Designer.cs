namespace RentalApp.UI.Popups
{
    partial class WalkInForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbrenttype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdeposit = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelbt = new System.Windows.Forms.Button();
            this.startbt = new System.Windows.Forms.Button();
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.materialLabel7 = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.dtpERD = new System.Windows.Forms.DateTimePicker();
            this.dtpPD = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new System.Windows.Forms.Label();
            this.materialLabel5 = new System.Windows.Forms.Label();
            this.txtSM = new System.Windows.Forms.TextBox();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.cmbvhcl = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new System.Windows.Forms.Label();
            this.cmbcstmr = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new System.Windows.Forms.Label();
            this.materialLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cmbrenttype);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtdeposit);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cancelbt);
            this.panel1.Controls.Add(this.startbt);
            this.panel1.Controls.Add(this.cmbVT);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.btnAddCustomer);
            this.panel1.Controls.Add(this.dtpERD);
            this.panel1.Controls.Add(this.dtpPD);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.txtSM);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.cmbvhcl);
            this.panel1.Controls.Add(this.materialLabel3);
            this.panel1.Controls.Add(this.cmbcstmr);
            this.panel1.Controls.Add(this.materialLabel2);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 535);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cmbrenttype
            // 
            this.cmbrenttype.FormattingEnabled = true;
            this.cmbrenttype.Location = new System.Drawing.Point(22, 266);
            this.cmbrenttype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbrenttype.Name = "cmbrenttype";
            this.cmbrenttype.Size = new System.Drawing.Size(130, 21);
            this.cmbrenttype.TabIndex = 21;
            this.cmbrenttype.SelectedIndexChanged += new System.EventHandler(this.cmbrenttype_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(19, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Rent Type:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtdeposit
            // 
            this.txtdeposit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtdeposit.Location = new System.Drawing.Point(22, 312);
            this.txtdeposit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdeposit.Name = "txtdeposit";
            this.txtdeposit.Size = new System.Drawing.Size(132, 25);
            this.txtdeposit.TabIndex = 17;
            this.txtdeposit.TextChanged += new System.EventHandler(this.txtdeposit_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(19, 292);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Deposit Amount:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cancelbt
            // 
            this.cancelbt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cancelbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelbt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cancelbt.ForeColor = System.Drawing.Color.DimGray;
            this.cancelbt.Location = new System.Drawing.Point(135, 472);
            this.cancelbt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelbt.Name = "cancelbt";
            this.cancelbt.Size = new System.Drawing.Size(105, 37);
            this.cancelbt.TabIndex = 15;
            this.cancelbt.Text = "CANCEL";
            this.cancelbt.UseVisualStyleBackColor = false;
            this.cancelbt.Click += new System.EventHandler(this.cancelbt_Click_1);
            // 
            // startbt
            // 
            this.startbt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.startbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startbt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.startbt.ForeColor = System.Drawing.Color.White;
            this.startbt.Location = new System.Drawing.Point(19, 472);
            this.startbt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.startbt.Name = "startbt";
            this.startbt.Size = new System.Drawing.Size(109, 37);
            this.startbt.TabIndex = 14;
            this.startbt.Text = "START";
            this.startbt.UseVisualStyleBackColor = false;
            this.startbt.Click += new System.EventHandler(this.startbt_Click);
            // 
            // cmbVT
            // 
            this.cmbVT.Enabled = false;
            this.cmbVT.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(160, 154);
            this.cmbVT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbVT.Name = "cmbVT";
            this.cmbVT.Size = new System.Drawing.Size(81, 25);
            this.cmbVT.TabIndex = 13;
            this.cmbVT.SelectedIndexChanged += new System.EventHandler(this.cmbVT_SelectedIndexChanged);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel7.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel7.Location = new System.Drawing.Point(158, 134);
            this.materialLabel7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(35, 15);
            this.materialLabel7.TabIndex = 12;
            this.materialLabel7.Text = "Type:";
            this.materialLabel7.Click += new System.EventHandler(this.materialLabel7_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.Location = new System.Drawing.Point(160, 99);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(26, 24);
            this.btnAddCustomer.TabIndex = 11;
            this.btnAddCustomer.Text = "+";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // dtpERD
            // 
            this.dtpERD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpERD.Location = new System.Drawing.Point(22, 427);
            this.dtpERD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpERD.Name = "dtpERD";
            this.dtpERD.Size = new System.Drawing.Size(219, 25);
            this.dtpERD.TabIndex = 10;
            this.dtpERD.ValueChanged += new System.EventHandler(this.dtpERD_ValueChanged);
            // 
            // dtpPD
            // 
            this.dtpPD.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpPD.Location = new System.Drawing.Point(22, 370);
            this.dtpPD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpPD.Name = "dtpPD";
            this.dtpPD.Size = new System.Drawing.Size(219, 25);
            this.dtpPD.TabIndex = 9;
            this.dtpPD.ValueChanged += new System.EventHandler(this.dtpPD_ValueChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel6.Location = new System.Drawing.Point(19, 407);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(122, 15);
            this.materialLabel6.TabIndex = 8;
            this.materialLabel6.Text = "Expected Return Date:";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel5.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel5.Location = new System.Drawing.Point(19, 350);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(77, 15);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Pick Up Date:";
            this.materialLabel5.Click += new System.EventHandler(this.materialLabel5_Click);
            // 
            // txtSM
            // 
            this.txtSM.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSM.Location = new System.Drawing.Point(22, 207);
            this.txtSM.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSM.Name = "txtSM";
            this.txtSM.ReadOnly = true;
            this.txtSM.Size = new System.Drawing.Size(132, 25);
            this.txtSM.TabIndex = 6;
            this.txtSM.TextChanged += new System.EventHandler(this.txtSM_TextChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel4.Location = new System.Drawing.Point(19, 187);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(96, 15);
            this.materialLabel4.TabIndex = 5;
            this.materialLabel4.Text = "Starting Mileage:";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // cmbvhcl
            // 
            this.cmbvhcl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbvhcl.FormattingEnabled = true;
            this.cmbvhcl.Location = new System.Drawing.Point(22, 154);
            this.cmbvhcl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbvhcl.Name = "cmbvhcl";
            this.cmbvhcl.Size = new System.Drawing.Size(132, 25);
            this.cmbvhcl.TabIndex = 4;
            this.cmbvhcl.SelectedIndexChanged += new System.EventHandler(this.cmbvhcl_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel3.Location = new System.Drawing.Point(19, 134);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(90, 15);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Choose Vehicle:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // cmbcstmr
            // 
            this.cmbcstmr.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbcstmr.FormattingEnabled = true;
            this.cmbcstmr.Location = new System.Drawing.Point(22, 99);
            this.cmbcstmr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbcstmr.Name = "cmbcstmr";
            this.cmbcstmr.Size = new System.Drawing.Size(132, 25);
            this.cmbcstmr.TabIndex = 2;
            this.cmbcstmr.SelectedIndexChanged += new System.EventHandler(this.cmbcstmr_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel2.Location = new System.Drawing.Point(19, 77);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(105, 15);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Choose Customer:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.materialLabel1.Location = new System.Drawing.Point(16, 20);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(218, 32);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Walk-in Customer";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // WalkInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(262, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WalkInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Walk-in Rental";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label materialLabel1;
        private System.Windows.Forms.Label materialLabel2;
        private System.Windows.Forms.ComboBox cmbcstmr;
        private System.Windows.Forms.Label materialLabel3;
        private System.Windows.Forms.ComboBox cmbvhcl;
        private System.Windows.Forms.Label materialLabel4;
        private System.Windows.Forms.TextBox txtSM;
        private System.Windows.Forms.Label materialLabel5;
        private System.Windows.Forms.Label materialLabel6;
        private System.Windows.Forms.DateTimePicker dtpPD;
        private System.Windows.Forms.DateTimePicker dtpERD;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label materialLabel7;
        private System.Windows.Forms.ComboBox cmbVT;
        private System.Windows.Forms.Button startbt;
        private System.Windows.Forms.Button cancelbt;
        private System.Windows.Forms.TextBox txtdeposit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbrenttype;
        private System.Windows.Forms.Label label2;
    }
}