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
            this.recentActivityPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.sectionHeaderTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblRecent = new System.Windows.Forms.Label();
            this.lblQuick = new System.Windows.Forms.Label();
            this.quickActionsPanel = new System.Windows.Forms.Panel();
            this.sectionHeaderTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.headerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(32)))), ((int)(((byte)(43)))));
            this.headerLabel.Location = new System.Drawing.Point(0, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(321, 32);
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
            // recentActivityPanel
            // 
            this.recentActivityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.recentActivityPanel.AutoScroll = true;
            this.recentActivityPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.recentActivityPanel.Location = new System.Drawing.Point(0, 316);
            this.recentActivityPanel.Name = "recentActivityPanel";
            this.recentActivityPanel.Size = new System.Drawing.Size(920, 474);
            this.recentActivityPanel.TabIndex = 3;
            this.recentActivityPanel.WrapContents = false;
            // 
            // sectionHeaderTable
            // 
            this.sectionHeaderTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sectionHeaderTable.ColumnCount = 2;
            this.sectionHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.sectionHeaderTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.sectionHeaderTable.Controls.Add(this.lblRecent, 0, 0);
            this.sectionHeaderTable.Controls.Add(this.lblQuick, 1, 0);
            this.sectionHeaderTable.Location = new System.Drawing.Point(0, 270);
            this.sectionHeaderTable.Name = "sectionHeaderTable";
            this.sectionHeaderTable.RowCount = 1;
            this.sectionHeaderTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sectionHeaderTable.Size = new System.Drawing.Size(1426, 40);
            this.sectionHeaderTable.TabIndex = 2;
            // 
            // lblRecent
            // 
            this.lblRecent.AutoSize = true;
            this.lblRecent.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblRecent.ForeColor = System.Drawing.Color.DimGray;
            this.lblRecent.Location = new System.Drawing.Point(3, 0);
            this.lblRecent.Name = "lblRecent";
            this.lblRecent.Size = new System.Drawing.Size(120, 21);
            this.lblRecent.TabIndex = 0;
            this.lblRecent.Text = "Recent Activity";
            // 
            // lblQuick
            // 
            this.lblQuick.AutoSize = true;
            this.lblQuick.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuick.ForeColor = System.Drawing.Color.DimGray;
            this.lblQuick.Location = new System.Drawing.Point(929, 0);
            this.lblQuick.Name = "lblQuick";
            this.lblQuick.Size = new System.Drawing.Size(110, 21);
            this.lblQuick.TabIndex = 1;
            this.lblQuick.Text = "Quick Actions";
            // 
            // quickActionsPanel
            // 
            this.quickActionsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quickActionsPanel.Location = new System.Drawing.Point(926, 316);
            this.quickActionsPanel.Name = "quickActionsPanel";
            this.quickActionsPanel.Size = new System.Drawing.Size(500, 474);
            this.quickActionsPanel.TabIndex = 4;
            // 
            // DashboardView
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.quickActionsPanel);
            this.Controls.Add(this.recentActivityPanel);
            this.Controls.Add(this.sectionHeaderTable);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.cardsPanel);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(1446, 794);
            this.sectionHeaderTable.ResumeLayout(false);
            this.sectionHeaderTable.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label headerLabel;
        public System.Windows.Forms.FlowLayoutPanel cardsPanel;
        private System.Windows.Forms.FlowLayoutPanel recentActivityPanel;
        private System.Windows.Forms.TableLayoutPanel sectionHeaderTable;
        private System.Windows.Forms.Label lblRecent;
        private System.Windows.Forms.Label lblQuick;
        private System.Windows.Forms.Panel quickActionsPanel;
    }
}
