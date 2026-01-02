namespace RentalApp.UI.Popups
{
    partial class AddnewCustomer
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
            this.dafas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.textxtlastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdlnumber = new System.Windows.Forms.TextBox();
            this.dtdateissue = new System.Windows.Forms.DateTimePicker();
            this.dtdateexpire = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.dadf = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtlicensestate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbcustomertype = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dafas
            // 
            this.dafas.AutoSize = true;
            this.dafas.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dafas.Location = new System.Drawing.Point(12, 19);
            this.dafas.Name = "dafas";
            this.dafas.Size = new System.Drawing.Size(142, 19);
            this.dafas.TabIndex = 1;
            this.dafas.Text = "Customer First Name:";
            this.dafas.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(224, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer LastName:";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(16, 41);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(158, 20);
            this.txtfirstname.TabIndex = 3;
            this.txtfirstname.Text = "q";
            this.txtfirstname.TextChanged += new System.EventHandler(this.txtfirstname_TextChanged);
            // 
            // textxtlastname
            // 
            this.textxtlastname.Location = new System.Drawing.Point(228, 41);
            this.textxtlastname.Name = "textxtlastname";
            this.textxtlastname.Size = new System.Drawing.Size(158, 20);
            this.textxtlastname.TabIndex = 4;
            this.textxtlastname.TextChanged += new System.EventHandler(this.textxtlastname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(12, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "License Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(188, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date Issue";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(313, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Date Expire";
            // 
            // txtdlnumber
            // 
            this.txtdlnumber.Location = new System.Drawing.Point(12, 248);
            this.txtdlnumber.Name = "txtdlnumber";
            this.txtdlnumber.Size = new System.Drawing.Size(158, 20);
            this.txtdlnumber.TabIndex = 8;
            this.txtdlnumber.TextChanged += new System.EventHandler(this.txtdlnumber_TextChanged);
            // 
            // dtdateissue
            // 
            this.dtdateissue.Location = new System.Drawing.Point(192, 248);
            this.dtdateissue.Name = "dtdateissue";
            this.dtdateissue.Size = new System.Drawing.Size(88, 20);
            this.dtdateissue.TabIndex = 9;
            this.dtdateissue.ValueChanged += new System.EventHandler(this.dtdateissue_ValueChanged);
            // 
            // dtdateexpire
            // 
            this.dtdateexpire.Location = new System.Drawing.Point(317, 248);
            this.dtdateexpire.Name = "dtdateexpire";
            this.dtdateexpire.Size = new System.Drawing.Size(88, 20);
            this.dtdateexpire.TabIndex = 10;
            this.dtdateexpire.ValueChanged += new System.EventHandler(this.dtdateexpire_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(12, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(16, 110);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(158, 20);
            this.txtaddress.TabIndex = 12;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // dadf
            // 
            this.dadf.AutoSize = true;
            this.dadf.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dadf.Location = new System.Drawing.Point(224, 88);
            this.dadf.Name = "dadf";
            this.dadf.Size = new System.Drawing.Size(41, 19);
            this.dadf.TabIndex = 13;
            this.dadf.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(16, 169);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(158, 20);
            this.phone.TabIndex = 16;
            this.phone.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label7.Location = new System.Drawing.Point(224, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Emergency Contact";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(228, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.Text = "Ex. Jane Williams 555-0102";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label8.Location = new System.Drawing.Point(427, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "License State:";
            // 
            // txtlicensestate
            // 
            this.txtlicensestate.Location = new System.Drawing.Point(431, 251);
            this.txtlicensestate.Name = "txtlicensestate";
            this.txtlicensestate.Size = new System.Drawing.Size(87, 20);
            this.txtlicensestate.TabIndex = 20;
            this.txtlicensestate.TextChanged += new System.EventHandler(this.txtlicensestate_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label9.Location = new System.Drawing.Point(427, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Customer Type:";
            // 
            // cmbcustomertype
            // 
            this.cmbcustomertype.FormattingEnabled = true;
            this.cmbcustomertype.Location = new System.Drawing.Point(431, 109);
            this.cmbcustomertype.Name = "cmbcustomertype";
            this.cmbcustomertype.Size = new System.Drawing.Size(121, 21);
            this.cmbcustomertype.TabIndex = 22;
            this.cmbcustomertype.SelectedIndexChanged += new System.EventHandler(this.cmbcustomertype_SelectedIndexChanged);
            // 
            // AddnewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 450);
            this.Controls.Add(this.cmbcustomertype);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtlicensestate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dadf);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtdateexpire);
            this.Controls.Add(this.dtdateissue);
            this.Controls.Add(this.txtdlnumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textxtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dafas);
            this.Name = "AddnewCustomer";
            this.Text = "AddnewCustomer";
            this.Load += new System.EventHandler(this.AddnewCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dafas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox textxtlastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtdlnumber;
        private System.Windows.Forms.DateTimePicker dtdateissue;
        private System.Windows.Forms.DateTimePicker dtdateexpire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label dadf;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtlicensestate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbcustomertype;
    }
}