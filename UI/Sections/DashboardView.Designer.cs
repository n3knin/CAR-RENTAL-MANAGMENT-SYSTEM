using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace RentalApp.UI.Sections
{
    partial class DashboardView
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.cardsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.fleetSectionPanel = new System.Windows.Forms.Panel();
            this.lblFleetTitle = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSearch = new System.Windows.Forms.Label();
            this.gridPanel = new System.Windows.Forms.Panel();
            this.fleetSectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(0, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(404, 41);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Dashboard - Welcome, Nino";
            // 
            // cardsPanel
            // 
            this.cardsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cardsPanel.Location = new System.Drawing.Point(0, 60);
            this.cardsPanel.Name = "cardsPanel";
            this.cardsPanel.Size = new System.Drawing.Size(1426, 200);
            this.cardsPanel.TabIndex = 1;
            this.cardsPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cardsPanel_Paint);
            // 
            // fleetSectionPanel
            // 
            this.fleetSectionPanel.Controls.Add(this.lblFleetTitle);
            this.fleetSectionPanel.Controls.Add(this.txtSearch);
            this.fleetSectionPanel.Controls.Add(this.btnAdd);
            this.fleetSectionPanel.Controls.Add(this.btnEdit);
            this.fleetSectionPanel.Controls.Add(this.btnDelete);
            this.fleetSectionPanel.Controls.Add(this.lblSearch);
            this.fleetSectionPanel.Location = new System.Drawing.Point(0, 280);
            this.fleetSectionPanel.Name = "fleetSectionPanel";
            this.fleetSectionPanel.Size = new System.Drawing.Size(1328, 80);
            this.fleetSectionPanel.TabIndex = 2;
            // 
            // lblFleetTitle
            // 
            this.lblFleetTitle.AutoSize = true;
            this.lblFleetTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lblFleetTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFleetTitle.Name = "lblFleetTitle";
            this.lblFleetTitle.Size = new System.Drawing.Size(160, 32);
            this.lblFleetTitle.TabIndex = 0;
            this.lblFleetTitle.Text = "Vehicles Fleet";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(60, 45);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(300, 22);
            this.txtSearch.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(133)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1013, 40);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.White;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(1103, 40);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(1193, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(0, 48);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(50, 16);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search";
            // 
            // gridPanel
            // 
            this.gridPanel.BackColor = System.Drawing.Color.White;
            this.gridPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gridPanel.Location = new System.Drawing.Point(0, 360);
            this.gridPanel.Name = "gridPanel";
            this.gridPanel.Size = new System.Drawing.Size(1273, 311);
            this.gridPanel.TabIndex = 3;
            // 
            // DashboardView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cardsPanel);
            this.Controls.Add(this.fleetSectionPanel);
            this.Controls.Add(this.gridPanel);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1446, 800);
            this.fleetSectionPanel.ResumeLayout(false);
            this.fleetSectionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.FlowLayoutPanel cardsPanel;
        private System.Windows.Forms.Panel fleetSectionPanel;
        private System.Windows.Forms.Label lblFleetTitle;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel gridPanel;
        private System.Windows.Forms.Label lblSearch;
    }
}
