namespace RentalApp.UI.Popups
{
    partial class CustomerDetailsForm
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
            this.btblacklist = new System.Windows.Forms.Button();
            this.btclose = new System.Windows.Forms.Button();
            this.labelHistory = new System.Windows.Forms.Label();
            this.customergrid = new System.Windows.Forms.DataGridView();
            this.dlexpiredate = new System.Windows.Forms.Label();
            this.labelExpire = new System.Windows.Forms.Label();
            this.dlissuedate = new System.Windows.Forms.Label();
            this.labelIssue = new System.Windows.Forms.Label();
            this.dlnumber = new System.Windows.Forms.Label();
            this.labelDL = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.Label();
            this.labelLast = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btblacklist);
            this.panel1.Controls.Add(this.btclose);
            this.panel1.Controls.Add(this.labelHistory);
            this.panel1.Controls.Add(this.customergrid);
            this.panel1.Controls.Add(this.dlexpiredate);
            this.panel1.Controls.Add(this.labelExpire);
            this.panel1.Controls.Add(this.dlissuedate);
            this.panel1.Controls.Add(this.labelIssue);
            this.panel1.Controls.Add(this.dlnumber);
            this.panel1.Controls.Add(this.labelDL);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.labelAddress);
            this.panel1.Controls.Add(this.txtlastname);
            this.panel1.Controls.Add(this.labelLast);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.labelFirst);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 447);
            this.panel1.TabIndex = 0;
            // 
            // btblacklist
            // 
            this.btblacklist.BackColor = System.Drawing.Color.Crimson;
            this.btblacklist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btblacklist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btblacklist.ForeColor = System.Drawing.Color.White;
            this.btblacklist.Location = new System.Drawing.Point(22, 390);
            this.btblacklist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btblacklist.Name = "btblacklist";
            this.btblacklist.Size = new System.Drawing.Size(90, 32);
            this.btblacklist.TabIndex = 16;
            this.btblacklist.Text = "BLACKLIST";
            this.btblacklist.UseVisualStyleBackColor = false;
            this.btblacklist.Click += new System.EventHandler(this.btblacklist_Click);
            // 
            // btclose
            // 
            this.btclose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btclose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btclose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btclose.ForeColor = System.Drawing.Color.DimGray;
            this.btclose.Location = new System.Drawing.Point(466, 390);
            this.btclose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btclose.Name = "btclose";
            this.btclose.Size = new System.Drawing.Size(93, 32);
            this.btclose.TabIndex = 15;
            this.btclose.Text = "CLOSE";
            this.btclose.UseVisualStyleBackColor = false;
            this.btclose.Click += new System.EventHandler(this.btclose_Click);
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.labelHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.labelHistory.Location = new System.Drawing.Point(20, 219);
            this.labelHistory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(119, 21);
            this.labelHistory.TabIndex = 14;
            this.labelHistory.Text = "Rental History";
            // 
            // customergrid
            // 
            this.customergrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customergrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customergrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customergrid.Location = new System.Drawing.Point(22, 244);
            this.customergrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customergrid.Name = "customergrid";
            this.customergrid.RowHeadersWidth = 51;
            this.customergrid.RowTemplate.Height = 24;
            this.customergrid.Size = new System.Drawing.Size(537, 130);
            this.customergrid.TabIndex = 13;
            this.customergrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellContentClick);
            this.customergrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customergrid_CellContentDoubleClick);
            // 
            // dlexpiredate
            // 
            this.dlexpiredate.AutoSize = true;
            this.dlexpiredate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dlexpiredate.ForeColor = System.Drawing.Color.Black;
            this.dlexpiredate.Location = new System.Drawing.Point(464, 179);
            this.dlexpiredate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dlexpiredate.Name = "dlexpiredate";
            this.dlexpiredate.Size = new System.Drawing.Size(95, 20);
            this.dlexpiredate.TabIndex = 12;
            this.dlexpiredate.Text = "00/00/0000";
            this.dlexpiredate.Click += new System.EventHandler(this.dlexpiredate_Click);
            // 
            // labelExpire
            // 
            this.labelExpire.AutoSize = true;
            this.labelExpire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelExpire.ForeColor = System.Drawing.Color.DimGray;
            this.labelExpire.Location = new System.Drawing.Point(390, 183);
            this.labelExpire.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpire.Name = "labelExpire";
            this.labelExpire.Size = new System.Drawing.Size(68, 15);
            this.labelExpire.TabIndex = 11;
            this.labelExpire.Text = "Expiry Date:";
            // 
            // dlissuedate
            // 
            this.dlissuedate.AutoSize = true;
            this.dlissuedate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dlissuedate.ForeColor = System.Drawing.Color.Black;
            this.dlissuedate.Location = new System.Drawing.Point(464, 146);
            this.dlissuedate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dlissuedate.Name = "dlissuedate";
            this.dlissuedate.Size = new System.Drawing.Size(95, 20);
            this.dlissuedate.TabIndex = 10;
            this.dlissuedate.Text = "00/00/0000";
            this.dlissuedate.Click += new System.EventHandler(this.dlissuedate_Click);
            // 
            // labelIssue
            // 
            this.labelIssue.AutoSize = true;
            this.labelIssue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelIssue.ForeColor = System.Drawing.Color.DimGray;
            this.labelIssue.Location = new System.Drawing.Point(390, 150);
            this.labelIssue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIssue.Name = "labelIssue";
            this.labelIssue.Size = new System.Drawing.Size(63, 15);
            this.labelIssue.TabIndex = 9;
            this.labelIssue.Text = "Issue Date:";
            // 
            // dlnumber
            // 
            this.dlnumber.AutoSize = true;
            this.dlnumber.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dlnumber.ForeColor = System.Drawing.Color.Black;
            this.dlnumber.Location = new System.Drawing.Point(98, 179);
            this.dlnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dlnumber.Name = "dlnumber";
            this.dlnumber.Size = new System.Drawing.Size(80, 20);
            this.dlnumber.TabIndex = 8;
            this.dlnumber.Text = "A00-0000";
            this.dlnumber.Click += new System.EventHandler(this.dlnumber_Click);
            // 
            // labelDL
            // 
            this.labelDL.AutoSize = true;
            this.labelDL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelDL.ForeColor = System.Drawing.Color.DimGray;
            this.labelDL.Location = new System.Drawing.Point(22, 183);
            this.labelDL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDL.Name = "labelDL";
            this.labelDL.Size = new System.Drawing.Size(68, 15);
            this.labelDL.TabIndex = 7;
            this.labelDL.Text = "License No:";
            // 
            // txtaddress
            // 
            this.txtaddress.AutoSize = true;
            this.txtaddress.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtaddress.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.Location = new System.Drawing.Point(98, 146);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(66, 20);
            this.txtaddress.TabIndex = 6;
            this.txtaddress.Text = "Address";
            this.txtaddress.Click += new System.EventHandler(this.txtaddress_Click);
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelAddress.ForeColor = System.Drawing.Color.DimGray;
            this.labelAddress.Location = new System.Drawing.Point(22, 150);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(52, 15);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address:";
            // 
            // txtlastname
            // 
            this.txtlastname.AutoSize = true;
            this.txtlastname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtlastname.ForeColor = System.Drawing.Color.Black;
            this.txtlastname.Location = new System.Drawing.Point(464, 65);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(84, 20);
            this.txtlastname.TabIndex = 4;
            this.txtlastname.Text = "Last Name";
            this.txtlastname.Click += new System.EventHandler(this.txtlastname_Click);
            // 
            // labelLast
            // 
            this.labelLast.AutoSize = true;
            this.labelLast.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLast.ForeColor = System.Drawing.Color.DimGray;
            this.labelLast.Location = new System.Drawing.Point(390, 69);
            this.labelLast.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLast.Name = "labelLast";
            this.labelLast.Size = new System.Drawing.Size(66, 15);
            this.labelLast.TabIndex = 3;
            this.labelLast.Text = "Last Name:";
            // 
            // txtname
            // 
            this.txtname.AutoSize = true;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtname.ForeColor = System.Drawing.Color.Black;
            this.txtname.Location = new System.Drawing.Point(98, 65);
            this.txtname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(86, 20);
            this.txtname.TabIndex = 2;
            this.txtname.Text = "First Name";
            this.txtname.Click += new System.EventHandler(this.txt_Click);
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelFirst.ForeColor = System.Drawing.Color.DimGray;
            this.labelFirst.Location = new System.Drawing.Point(22, 69);
            this.labelFirst.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(67, 15);
            this.labelFirst.TabIndex = 1;
            this.labelFirst.Text = "First Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblTitle.Location = new System.Drawing.Point(19, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(209, 32);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Customer Details";
            // 
            // CustomerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 447);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Customer Details";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customergrid)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label txtname;
        private System.Windows.Forms.Label labelLast;
        private System.Windows.Forms.Label txtlastname;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label txtaddress;
        private System.Windows.Forms.Label labelDL;
        private System.Windows.Forms.Label dlnumber;
        private System.Windows.Forms.Label labelIssue;
        private System.Windows.Forms.Label dlissuedate;
        private System.Windows.Forms.Label labelExpire;
        private System.Windows.Forms.Label dlexpiredate;
        private System.Windows.Forms.DataGridView customergrid;
        private System.Windows.Forms.Button btblacklist;
        private System.Windows.Forms.Button btclose;
        private System.Windows.Forms.Label labelHistory;
    }
}
