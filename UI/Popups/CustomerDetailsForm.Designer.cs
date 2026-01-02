namespace RentalApp.UI.Popups
{
    partial class CustomerDetailsForm
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
            this.txtname = new MaterialSkin.Controls.MaterialLabel();
            this.txtlastname = new MaterialSkin.Controls.MaterialLabel();
            this.txt = new MaterialSkin.Controls.MaterialLabel();
            this.txtaddress = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.dlnumber = new MaterialSkin.Controls.MaterialLabel();
            this.dlissuedate = new MaterialSkin.Controls.MaterialLabel();
            this.dlexpiredate = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.customergrid = new System.Windows.Forms.DataGridView();
            this.btblacklist = new MaterialSkin.Controls.MaterialFlatButton();
            this.btclose = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Depth = 0;
            this.txtname.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtname.Location = new System.Drawing.Point(12, 9);
            this.txtname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(83, 19);
            this.txtname.TabIndex = 0;
            this.txtname.Text = "First Name";
            this.txtname.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txtlastname
            // 
            this.txtlastname.AutoSize = true;
            this.txtlastname.Depth = 0;
            this.txtlastname.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtlastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtlastname.Location = new System.Drawing.Point(187, 9);
            this.txtlastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(75, 19);
            this.txtlastname.TabIndex = 1;
            this.txtlastname.Text = "Lastname";
            this.txtlastname.Click += new System.EventHandler(this.txtlastname_Click);
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Depth = 0;
            this.txt.Font = new System.Drawing.Font("Roboto", 11F);
            this.txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txt.Location = new System.Drawing.Point(13, 98);
            this.txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(64, 19);
            this.txt.TabIndex = 2;
            this.txt.Text = "Address";
            this.txt.Click += new System.EventHandler(this.txt_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.AutoSize = true;
            this.txtaddress.Depth = 0;
            this.txtaddress.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtaddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtaddress.Location = new System.Drawing.Point(99, 98);
            this.txtaddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(126, 19);
            this.txtaddress.TabIndex = 3;
            this.txtaddress.Text = "Porok kalamense";
            this.txtaddress.Click += new System.EventHandler(this.txtaddress_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(12, 146);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(169, 19);
            this.materialLabel1.TabIndex = 4;
            this.materialLabel1.Text = "Drivers License Number";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click_1);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(206, 146);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(80, 19);
            this.materialLabel2.TabIndex = 5;
            this.materialLabel2.Text = "Date Issue";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(337, 146);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(85, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Date Expire";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // dlnumber
            // 
            this.dlnumber.AutoSize = true;
            this.dlnumber.Depth = 0;
            this.dlnumber.Font = new System.Drawing.Font("Roboto", 11F);
            this.dlnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dlnumber.Location = new System.Drawing.Point(12, 178);
            this.dlnumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.dlnumber.Name = "dlnumber";
            this.dlnumber.Size = new System.Drawing.Size(113, 19);
            this.dlnumber.TabIndex = 7;
            this.dlnumber.Text = "Ex. 1234234324";
            this.dlnumber.Click += new System.EventHandler(this.dlnumber_Click);
            // 
            // dlissuedate
            // 
            this.dlissuedate.AutoSize = true;
            this.dlissuedate.Depth = 0;
            this.dlissuedate.Font = new System.Drawing.Font("Roboto", 11F);
            this.dlissuedate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dlissuedate.Location = new System.Drawing.Point(206, 178);
            this.dlissuedate.MouseState = MaterialSkin.MouseState.HOVER;
            this.dlissuedate.Name = "dlissuedate";
            this.dlissuedate.Size = new System.Drawing.Size(81, 19);
            this.dlissuedate.TabIndex = 8;
            this.dlissuedate.Text = "2026-01-01";
            this.dlissuedate.Click += new System.EventHandler(this.dlissuedate_Click);
            // 
            // dlexpiredate
            // 
            this.dlexpiredate.AutoSize = true;
            this.dlexpiredate.Depth = 0;
            this.dlexpiredate.Font = new System.Drawing.Font("Roboto", 11F);
            this.dlexpiredate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dlexpiredate.Location = new System.Drawing.Point(341, 178);
            this.dlexpiredate.MouseState = MaterialSkin.MouseState.HOVER;
            this.dlexpiredate.Name = "dlexpiredate";
            this.dlexpiredate.Size = new System.Drawing.Size(81, 19);
            this.dlexpiredate.TabIndex = 9;
            this.dlexpiredate.Text = "2026-01-01";
            this.dlexpiredate.Click += new System.EventHandler(this.dlexpiredate_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 234);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(104, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Rental History";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // customergrid
            // 
            this.customergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customergrid.Location = new System.Drawing.Point(18, 262);
            this.customergrid.Name = "customergrid";
            this.customergrid.Size = new System.Drawing.Size(403, 131);
            this.customergrid.TabIndex = 11;
            this.customergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellContentClick);
            this.customergrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellContentDoubleClick);
            // 
            // btblacklist
            // 
            this.btblacklist.AutoSize = true;
            this.btblacklist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btblacklist.Depth = 0;
            this.btblacklist.Location = new System.Drawing.Point(18, 402);
            this.btblacklist.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btblacklist.MouseState = MaterialSkin.MouseState.HOVER;
            this.btblacklist.Name = "btblacklist";
            this.btblacklist.Primary = false;
            this.btblacklist.Size = new System.Drawing.Size(83, 36);
            this.btblacklist.TabIndex = 12;
            this.btblacklist.Text = "BLAKCLIST";
            this.btblacklist.UseVisualStyleBackColor = true;
            this.btblacklist.Click += new System.EventHandler(this.btblacklist_Click);
            // 
            // btclose
            // 
            this.btclose.AutoSize = true;
            this.btclose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btclose.Depth = 0;
            this.btclose.Location = new System.Drawing.Point(338, 402);
            this.btclose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btclose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btclose.Name = "btclose";
            this.btclose.Primary = false;
            this.btclose.Size = new System.Drawing.Size(54, 36);
            this.btclose.TabIndex = 13;
            this.btclose.Text = "CLOSE";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // CustomerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 450);
            this.Controls.Add(this.btclose);
            this.Controls.Add(this.btblacklist);
            this.Controls.Add(this.customergrid);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.dlexpiredate);
            this.Controls.Add(this.dlissuedate);
            this.Controls.Add(this.dlnumber);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtname);
            this.Name = "CustomerDetailsForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel txtname;
        private MaterialSkin.Controls.MaterialLabel txtlastname;
        private MaterialSkin.Controls.MaterialLabel txt;
        private MaterialSkin.Controls.MaterialLabel txtaddress;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel dlnumber;
        private MaterialSkin.Controls.MaterialLabel dlissuedate;
        private MaterialSkin.Controls.MaterialLabel dlexpiredate;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridView customergrid;
        private MaterialSkin.Controls.MaterialFlatButton btblacklist;
        private MaterialSkin.Controls.MaterialFlatButton btclose;
    }
}