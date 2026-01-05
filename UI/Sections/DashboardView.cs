using System;
using System.Drawing;
using System.Windows.Forms;

namespace RentalApp.UI.Sections
{
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
            InitializeCards();
        }

        private void InitializeCards()
        {
            // Cards
            AddCard("Today's Pickups", "6", Color.FromArgb(21, 32, 43));
            AddCard("Today's Returns", "3", Color.FromArgb(21, 32, 43));
            AddCard("Fleet Available", "20", Color.FromArgb(21, 32, 43));
            AddCard("Overdue Return", "1", Color.Red);
            AddCard("Active Rentals", "20", Color.FromArgb(21, 32, 43));
            AddCard("Pending Reservations", "2", Color.FromArgb(21, 32, 43));
            AddCard("Revenue Today", "₱10.5k", Color.LimeGreen);
            
            //AddQuickActions();
        }

        private void AddCard(string title, string value, Color valueColor)
        {
            Panel p = new Panel();
            p.BackColor = Color.White;
            p.Size = new Size(250, 90);
            p.Margin = new Padding(0, 0, 15, 15);
            
            Label lblTitle = new Label();
            lblTitle.Text = title;
            lblTitle.Font = new Font("Segoe UI", 8F);
            lblTitle.ForeColor = Color.Gray;
            lblTitle.Location = new Point(20, 15);
            lblTitle.AutoSize = true;
            
            Label lblValue = new Label();
            lblValue.Text = value;
            lblValue.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            lblValue.ForeColor = valueColor;
            lblValue.Location = new Point(20, 35);
            lblValue.AutoSize = true;
            
            p.Controls.Add(lblTitle);
            p.Controls.Add(lblValue);
            
            p.Resize += (s, e) => {
               // Center if needed
            };
            
            cardsPanel.Controls.Add(p);
        }

        //private void AddQuickActions()
        //{
        //    Panel p = new Panel();
        //    p.BackColor = Color.White;
        //    p.Size = new Size(350, 90);
        //    p.Margin = new Padding(0, 0, 15, 15);
            
        //    Label lbl = new Label();
        //    lbl.Text = "Quick Actions";
        //    lbl.Font = new Font("Segoe UI", 9F);
        //    lbl.ForeColor = Color.Gray;
        //    lbl.Location = new Point(15, 10);
        //    lbl.AutoSize = true;
            
        //    Button btnNew = new Button();
        //    btnNew.Text = "New Reservation";
        //    btnNew.BackColor = Color.LimeGreen;
        //    btnNew.ForeColor = Color.White;
        //    btnNew.FlatStyle = FlatStyle.Flat;
        //    btnNew.FlatAppearance.BorderSize = 0;
        //    btnNew.Location = new Point(15, 40);
        //    btnNew.Size = new Size(110, 30);
            
        //    Button btnCust = new Button();
        //    btnCust.Text = "Add Customer";
        //    btnCust.BackColor = Color.Navy;
        //    btnCust.ForeColor = Color.White;
        //    btnCust.FlatStyle = FlatStyle.Flat;
        //    btnCust.FlatAppearance.BorderSize = 0;
        //    btnCust.Location = new Point(135, 40);
        //    btnCust.Size = new Size(110, 30);
            
        //    p.Controls.Add(lbl);
        //    p.Controls.Add(btnNew);
        //    p.Controls.Add(btnCust);
            
        //    cardsPanel.Controls.Add(p);
        //}

        private void cardsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
