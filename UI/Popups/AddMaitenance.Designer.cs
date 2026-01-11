namespace RentalApp.UI.Popups
{
    partial class AddMaitenance
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtcstmr = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vehicletxt = new System.Windows.Forms.Label();
            this.materialLabel4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maintenanceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.strtbtn = new System.Windows.Forms.Button();
            this.cnclbttn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.lblTitle.Location = new System.Drawing.Point(23, 22);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(169, 32);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "Maintenance ";
            // 
            // txtcstmr
            // 
            this.txtcstmr.AutoSize = true;
            this.txtcstmr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtcstmr.ForeColor = System.Drawing.Color.Black;
            this.txtcstmr.Location = new System.Drawing.Point(44, 83);
            this.txtcstmr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtcstmr.Name = "txtcstmr";
            this.txtcstmr.Size = new System.Drawing.Size(86, 19);
            this.txtcstmr.TabIndex = 18;
            this.txtcstmr.Text = "Vehicle Info";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.costTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.maintenanceTypeComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.vehicletxt);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(29, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 158);
            this.panel1.TabIndex = 19;
            // 
            // vehicletxt
            // 
            this.vehicletxt.AutoSize = true;
            this.vehicletxt.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.vehicletxt.ForeColor = System.Drawing.Color.Black;
            this.vehicletxt.Location = new System.Drawing.Point(117, 21);
            this.vehicletxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.vehicletxt.Name = "vehicletxt";
            this.vehicletxt.Size = new System.Drawing.Size(100, 19);
            this.vehicletxt.TabIndex = 21;
            this.vehicletxt.Text = "Vehicle Name";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.materialLabel4.ForeColor = System.Drawing.Color.DimGray;
            this.materialLabel4.Location = new System.Drawing.Point(21, 23);
            this.materialLabel4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(47, 15);
            this.materialLabel4.TabIndex = 20;
            this.materialLabel4.Text = "Vehicle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(117, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(21, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Service Type: ";
            // 
            // maintenanceTypeComboBox
            // 
            this.maintenanceTypeComboBox.FormattingEnabled = true;
            this.maintenanceTypeComboBox.Location = new System.Drawing.Point(24, 77);
            this.maintenanceTypeComboBox.Name = "maintenanceTypeComboBox";
            this.maintenanceTypeComboBox.Size = new System.Drawing.Size(127, 21);
            this.maintenanceTypeComboBox.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(21, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Start Date of Maintenance ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(24, 128);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 26;
            // 
            // strtbtn
            // 
            this.strtbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.strtbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.strtbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.strtbtn.ForeColor = System.Drawing.Color.White;
            this.strtbtn.Location = new System.Drawing.Point(66, 280);
            this.strtbtn.Margin = new System.Windows.Forms.Padding(2);
            this.strtbtn.Name = "strtbtn";
            this.strtbtn.Size = new System.Drawing.Size(150, 37);
            this.strtbtn.TabIndex = 20;
            this.strtbtn.Text = "Add Record";
            this.strtbtn.UseVisualStyleBackColor = false;
            this.strtbtn.Click += new System.EventHandler(this.strtbtn_Click);
            // 
            // cnclbttn
            // 
            this.cnclbttn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cnclbttn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cnclbttn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cnclbttn.ForeColor = System.Drawing.Color.DimGray;
            this.cnclbttn.Location = new System.Drawing.Point(255, 280);
            this.cnclbttn.Margin = new System.Windows.Forms.Padding(2);
            this.cnclbttn.Name = "cnclbttn";
            this.cnclbttn.Size = new System.Drawing.Size(105, 37);
            this.cnclbttn.TabIndex = 21;
            this.cnclbttn.Text = "Cancel";
            this.cnclbttn.UseVisualStyleBackColor = false;
            this.cnclbttn.Click += new System.EventHandler(this.cnclbttn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(194, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Estimated Cost:";
            // 
            // costTextBox
            // 
            this.costTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.costTextBox.Location = new System.Drawing.Point(197, 77);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(175, 25);
            this.costTextBox.TabIndex = 28;
            // 
            // AddMaitenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 346);
            this.Controls.Add(this.cnclbttn);
            this.Controls.Add(this.strtbtn);
            this.Controls.Add(this.txtcstmr);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "AddMaitenance";
            this.Text = "AddMaitenance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label txtcstmr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label vehicletxt;
        private System.Windows.Forms.Label materialLabel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox maintenanceTypeComboBox;
        private System.Windows.Forms.Button strtbtn;
        private System.Windows.Forms.Button cnclbttn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox costTextBox;
    }
}