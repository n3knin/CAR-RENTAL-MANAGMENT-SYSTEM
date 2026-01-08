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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbcstmr = new System.Windows.Forms.ComboBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbvhcl = new System.Windows.Forms.ComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSM = new System.Windows.Forms.TextBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.dtpPD = new System.Windows.Forms.DateTimePicker();
            this.dtpERD = new System.Windows.Forms.DateTimePicker();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.cmbVT = new System.Windows.Forms.ComboBox();
            this.startbt = new System.Windows.Forms.Button();
            this.cancelbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(24, 25);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(124, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Walkin Customer";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(25, 101);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(135, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Choose Customer:";
            // 
            // cmbcstmr
            // 
            this.cmbcstmr.FormattingEnabled = true;
            this.cmbcstmr.Location = new System.Drawing.Point(29, 123);
            this.cmbcstmr.Name = "cmbcstmr";
            this.cmbcstmr.Size = new System.Drawing.Size(162, 21);
            this.cmbcstmr.TabIndex = 2;
            this.cmbcstmr.SelectedIndexChanged += new System.EventHandler(this.cmbcstmr_SelectedIndexChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(25, 158);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Choose Vehicle:";
            // 
            // cmbvhcl
            // 
            this.cmbvhcl.FormattingEnabled = true;
            this.cmbvhcl.Location = new System.Drawing.Point(29, 180);
            this.cmbvhcl.Name = "cmbvhcl";
            this.cmbvhcl.Size = new System.Drawing.Size(162, 21);
            this.cmbvhcl.TabIndex = 4;
            this.cmbvhcl.SelectedIndexChanged += new System.EventHandler(this.cmbvhcl_SelectedIndexChanged);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(25, 217);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(122, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Starting Mileage:";
            // 
            // txtSM
            // 
            this.txtSM.Location = new System.Drawing.Point(29, 239);
            this.txtSM.Name = "txtSM";
            this.txtSM.Size = new System.Drawing.Size(159, 20);
            this.txtSM.TabIndex = 7;
            this.txtSM.TextChanged += new System.EventHandler(this.txtSM_TextChanged);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(25, 279);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(99, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Pick Up Date:";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(24, 333);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(156, 19);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Expected Return Date:";
            // 
            // dtpPD
            // 
            this.dtpPD.Location = new System.Drawing.Point(29, 301);
            this.dtpPD.Name = "dtpPD";
            this.dtpPD.Size = new System.Drawing.Size(218, 20);
            this.dtpPD.TabIndex = 10;
            this.dtpPD.ValueChanged += new System.EventHandler(this.dtpPD_ValueChanged);
            // 
            // dtpERD
            // 
            this.dtpERD.Location = new System.Drawing.Point(29, 355);
            this.dtpERD.Name = "dtpERD";
            this.dtpERD.Size = new System.Drawing.Size(218, 20);
            this.dtpERD.TabIndex = 11;
            this.dtpERD.ValueChanged += new System.EventHandler(this.dtpERD_ValueChanged);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddCustomer.Location = new System.Drawing.Point(197, 117);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(30, 27);
            this.btnAddCustomer.TabIndex = 12;
            this.btnAddCustomer.Text = "+";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(210, 158);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(45, 19);
            this.materialLabel7.TabIndex = 13;
            this.materialLabel7.Text = "Type:";
            // 
            // cmbVT
            // 
            this.cmbVT.Enabled = false;
            this.cmbVT.FormattingEnabled = true;
            this.cmbVT.Location = new System.Drawing.Point(214, 180);
            this.cmbVT.Name = "cmbVT";
            this.cmbVT.Size = new System.Drawing.Size(96, 21);
            this.cmbVT.TabIndex = 14;
            this.cmbVT.SelectedIndexChanged += new System.EventHandler(this.cmbVT_SelectedIndexChanged);
            // 
            // startbt
            // 
            this.startbt.Location = new System.Drawing.Point(32, 426);
            this.startbt.Name = "startbt";
            this.startbt.Size = new System.Drawing.Size(115, 41);
            this.startbt.TabIndex = 15;
            this.startbt.Text = "START";
            this.startbt.UseVisualStyleBackColor = true;
            this.startbt.Click += new System.EventHandler(this.startbt_Click);
            // 
            // cancelbt
            // 
            this.cancelbt.Location = new System.Drawing.Point(166, 426);
            this.cancelbt.Name = "cancelbt";
            this.cancelbt.Size = new System.Drawing.Size(115, 41);
            this.cancelbt.TabIndex = 16;
            this.cancelbt.Text = "CANCEL";
            this.cancelbt.UseVisualStyleBackColor = true;
            // 
            // WalkInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 503);
            this.Controls.Add(this.cancelbt);
            this.Controls.Add(this.startbt);
            this.Controls.Add(this.cmbVT);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.dtpERD);
            this.Controls.Add(this.dtpPD);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.txtSM);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.cmbvhcl);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cmbcstmr);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "WalkInForm";
            this.Text = "WalkInForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private System.Windows.Forms.ComboBox cmbcstmr;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox cmbvhcl;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.TextBox txtSM;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DateTimePicker dtpPD;
        private System.Windows.Forms.DateTimePicker dtpERD;
        private System.Windows.Forms.Button btnAddCustomer;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private System.Windows.Forms.ComboBox cmbVT;
        private System.Windows.Forms.Button startbt;
        private System.Windows.Forms.Button cancelbt;
    }
}