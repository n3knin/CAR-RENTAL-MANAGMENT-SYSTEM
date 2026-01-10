namespace RentalApp.UI.Popups
{
    partial class STARTrentalform
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
            this.strtbtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.cnclbttn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.pickupdt = new System.Windows.Forms.DateTimePicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.lblmileage = new System.Windows.Forms.TextBox();
            this.rsvtnID = new MaterialSkin.Controls.MaterialLabel();
            this.vehicletxt = new MaterialSkin.Controls.MaterialLabel();
            this.txtcstmr = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.expectreturndt = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // strtbtn
            // 
            this.strtbtn.AutoSize = true;
            this.strtbtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.strtbtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.strtbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.strtbtn.Depth = 0;
            this.strtbtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.strtbtn.Location = new System.Drawing.Point(15, 288);
            this.strtbtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.strtbtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.strtbtn.Name = "strtbtn";
            this.strtbtn.Primary = false;
            this.strtbtn.Size = new System.Drawing.Size(109, 36);
            this.strtbtn.TabIndex = 0;
            this.strtbtn.Text = "Start Rental";
            this.strtbtn.UseVisualStyleBackColor = false;
            this.strtbtn.Click += new System.EventHandler(this.strtbtn_Click);
            // 
            // cnclbttn
            // 
            this.cnclbttn.AutoSize = true;
            this.cnclbttn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cnclbttn.Depth = 0;
            this.cnclbttn.Location = new System.Drawing.Point(201, 288);
            this.cnclbttn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.cnclbttn.MouseState = MaterialSkin.MouseState.HOVER;
            this.cnclbttn.Name = "cnclbttn";
            this.cnclbttn.Primary = false;
            this.cnclbttn.Size = new System.Drawing.Size(64, 36);
            this.cnclbttn.TabIndex = 1;
            this.cnclbttn.Text = "Cancel";
            this.cnclbttn.UseVisualStyleBackColor = true;
            this.cnclbttn.Click += new System.EventHandler(this.cnclbttn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 76);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(130, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "RESERVATION ID:";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(10, 76);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(0, 19);
            this.materialLabel2.TabIndex = 3;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 114);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(148, 19);
            this.materialLabel3.TabIndex = 5;
            this.materialLabel3.Text = "CUSTOMERS NAME:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(10, 191);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(78, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "VEHICLE: ";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(12, 153);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(151, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "STARTING MILEAGE:";
            // 
            // pickupdt
            // 
            this.pickupdt.Location = new System.Drawing.Point(128, 230);
            this.pickupdt.Name = "pickupdt";
            this.pickupdt.Size = new System.Drawing.Size(96, 20);
            this.pickupdt.TabIndex = 8;
            this.pickupdt.ValueChanged += new System.EventHandler(this.pickupdt_ValueChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(12, 230);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(110, 19);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "PICK-UP DATE:";
            // 
            // lblmileage
            // 
            this.lblmileage.Location = new System.Drawing.Point(161, 154);
            this.lblmileage.Name = "lblmileage";
            this.lblmileage.Size = new System.Drawing.Size(129, 20);
            this.lblmileage.TabIndex = 11;
            this.lblmileage.TextChanged += new System.EventHandler(this.lblmileage_TextChanged);
            // 
            // rsvtnID
            // 
            this.rsvtnID.AutoSize = true;
            this.rsvtnID.Depth = 0;
            this.rsvtnID.Font = new System.Drawing.Font("Roboto", 11F);
            this.rsvtnID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rsvtnID.Location = new System.Drawing.Point(166, 76);
            this.rsvtnID.MouseState = MaterialSkin.MouseState.HOVER;
            this.rsvtnID.Name = "rsvtnID";
            this.rsvtnID.Size = new System.Drawing.Size(17, 19);
            this.rsvtnID.TabIndex = 12;
            this.rsvtnID.Text = "4";
            this.rsvtnID.Click += new System.EventHandler(this.rsvtnID_Click);
            // 
            // vehicletxt
            // 
            this.vehicletxt.AutoSize = true;
            this.vehicletxt.Depth = 0;
            this.vehicletxt.Font = new System.Drawing.Font("Roboto", 11F);
            this.vehicletxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vehicletxt.Location = new System.Drawing.Point(92, 191);
            this.vehicletxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.vehicletxt.Name = "vehicletxt";
            this.vehicletxt.Size = new System.Drawing.Size(152, 19);
            this.vehicletxt.TabIndex = 13;
            this.vehicletxt.Text = "KAWASAKIT SA HRT ";
            this.vehicletxt.Click += new System.EventHandler(this.vehicletxt_Click);
            // 
            // txtcstmr
            // 
            this.txtcstmr.AutoSize = true;
            this.txtcstmr.Depth = 0;
            this.txtcstmr.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtcstmr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtcstmr.Location = new System.Drawing.Point(157, 114);
            this.txtcstmr.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtcstmr.Name = "txtcstmr";
            this.txtcstmr.Size = new System.Drawing.Size(124, 19);
            this.txtcstmr.TabIndex = 14;
            this.txtcstmr.Text = "JOSHUA GARCIA";
            this.txtcstmr.Click += new System.EventHandler(this.materialLabel8_Click);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(10, 20);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(87, 19);
            this.materialLabel7.TabIndex = 15;
            this.materialLabel7.Text = "Start Rental";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(12, 259);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(129, 19);
            this.materialLabel8.TabIndex = 16;
            this.materialLabel8.Text = "EXPECT RETURN:";
            // 
            // expectreturndt
            // 
            this.expectreturndt.Enabled = false;
            this.expectreturndt.Location = new System.Drawing.Point(147, 259);
            this.expectreturndt.Name = "expectreturndt";
            this.expectreturndt.Size = new System.Drawing.Size(96, 20);
            this.expectreturndt.TabIndex = 17;
            this.expectreturndt.ValueChanged += new System.EventHandler(this.expectreturndt_ValueChanged);
            // 
            // STARTrentalform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 352);
            this.Controls.Add(this.expectreturndt);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.txtcstmr);
            this.Controls.Add(this.vehicletxt);
            this.Controls.Add(this.rsvtnID);
            this.Controls.Add(this.lblmileage);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.pickupdt);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.cnclbttn);
            this.Controls.Add(this.strtbtn);
            this.Name = "STARTrentalform";
            this.Text = "STARTrentalform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton strtbtn;
        private MaterialSkin.Controls.MaterialFlatButton cnclbttn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.DateTimePicker pickupdt;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.TextBox lblmileage;
        private MaterialSkin.Controls.MaterialLabel rsvtnID;
        private MaterialSkin.Controls.MaterialLabel vehicletxt;
        private MaterialSkin.Controls.MaterialLabel txtcstmr;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private System.Windows.Forms.DateTimePicker expectreturndt;
    }
}