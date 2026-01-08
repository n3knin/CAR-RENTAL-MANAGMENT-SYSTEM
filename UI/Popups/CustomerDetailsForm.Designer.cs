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
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Depth = 0;
            this.txtname.Font = new System.Drawing.Font("Roboto", 11F);
            this.txtname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtname.Location = new System.Drawing.Point(16, 94);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(104, 24);
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
            this.txtlastname.Location = new System.Drawing.Point(161, 94);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtlastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(93, 24);
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
            this.txt.Location = new System.Drawing.Point(17, 151);
            this.txt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(80, 24);
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
            this.txtaddress.Location = new System.Drawing.Point(132, 151);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtaddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(157, 24);
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
            this.materialLabel1.Location = new System.Drawing.Point(16, 210);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(211, 24);
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
            this.materialLabel2.Location = new System.Drawing.Point(275, 210);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(98, 24);
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
            this.materialLabel3.Location = new System.Drawing.Point(449, 210);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(105, 24);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Date Expire";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // dlnumber
            // 
            this.dlnumber.AutoSize = true;
            this.dlnumber.Depth = 0;
            this.dlnumber.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dlnumber.Location = new System.Drawing.Point(16, 249);
            this.dlnumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dlnumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.dlnumber.Name = "dlnumber";
            this.dlnumber.Size = new System.Drawing.Size(138, 25);
            this.dlnumber.TabIndex = 7;
            this.dlnumber.Text = "Ex. 1234234324";
            this.dlnumber.Click += new System.EventHandler(this.dlnumber_Click);
            // 
            // dlissuedate
            // 
            this.dlissuedate.AutoSize = true;
            this.dlissuedate.Depth = 0;
            this.dlissuedate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlissuedate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dlissuedate.Location = new System.Drawing.Point(275, 249);
            this.dlissuedate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dlissuedate.MouseState = MaterialSkin.MouseState.HOVER;
            this.dlissuedate.Name = "dlissuedate";
            this.dlissuedate.Size = new System.Drawing.Size(106, 25);
            this.dlissuedate.TabIndex = 8;
            this.dlissuedate.Text = "2026-01-01";
            this.dlissuedate.Click += new System.EventHandler(this.dlissuedate_Click);
            // 
            // dlexpiredate
            // 
            this.dlexpiredate.AutoSize = true;
            this.dlexpiredate.Depth = 0;
            this.dlexpiredate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dlexpiredate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dlexpiredate.Location = new System.Drawing.Point(455, 249);
            this.dlexpiredate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dlexpiredate.MouseState = MaterialSkin.MouseState.HOVER;
            this.dlexpiredate.Name = "dlexpiredate";
            this.dlexpiredate.Size = new System.Drawing.Size(106, 25);
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
            this.materialLabel4.Location = new System.Drawing.Point(16, 318);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(129, 24);
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
            this.customergrid.Location = new System.Drawing.Point(24, 352);
            this.customergrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.customergrid.Name = "customergrid";
            this.customergrid.RowHeadersWidth = 51;
            this.customergrid.Size = new System.Drawing.Size(537, 161);
            this.customergrid.TabIndex = 11;
            this.customergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellContentClick);
            this.customergrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellContentDoubleClick);
            // 
            // btblacklist
            // 
            this.btblacklist.AutoSize = true;
            this.btblacklist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btblacklist.Depth = 0;
            this.btblacklist.Location = new System.Drawing.Point(24, 525);
            this.btblacklist.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btblacklist.MouseState = MaterialSkin.MouseState.HOVER;
            this.btblacklist.Name = "btblacklist";
            this.btblacklist.Primary = false;
            this.btblacklist.Size = new System.Drawing.Size(102, 36);
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
            this.btclose.Location = new System.Drawing.Point(460, 524);
            this.btclose.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btclose.MouseState = MaterialSkin.MouseState.HOVER;
            this.btclose.Name = "btclose";
            this.btclose.Primary = false;
            this.btclose.Size = new System.Drawing.Size(65, 36);
            this.btclose.TabIndex = 13;
            this.btclose.Text = "CLOSE";
            this.btclose.UseVisualStyleBackColor = true;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(13, 26);
            this.materialLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(241, 38);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Customer Details";
            // 
            // CustomerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 593);
            this.Controls.Add(this.materialLabel5);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}