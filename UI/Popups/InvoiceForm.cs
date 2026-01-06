using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalApp.Models.Core;
using RentalApp.Models.Services;
using RentalApp.Models.Vehicles;

namespace RentalApp.UI.Popups
{
    public partial class InvoiceForm : Form
    {
        private BillingManager _billingManager;
        private VehicleManager _vehicleManager;
        private CategoryManager _categoryManager;
        private RentalManager _rentalManager;
        private Rental _rental;
        private VehicleCategory _category;

        public InvoiceForm(Rental rental)
        {
            InitializeComponent();
            _billingManager = new BillingManager();
            _vehicleManager = new VehicleManager();
            _categoryManager = new CategoryManager();
            _rentalManager = new RentalManager();
            _rental = rental;

            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set data
            textBox1.Text = _rental.CustomerName;
            textBox2.Text = _rental.VehicleInfo;
            dtpSRD.Value = _rental.ActualPickupDate;
            dtpERD.Value = _rental.ActualReturnDate ?? DateTime.Now;

            // Load Category
            var vehicle = _vehicleManager.GetVehicleById(_rental.VehicleId);
            if (vehicle != null)
            {
                _category = _categoryManager.GetCategoryById(vehicle.CategoryId);
            }

            // Setup combo boxes
            cmbVT.DataSource = Enum.GetValues(typeof(RateType));
            cmbPM.DataSource = Enum.GetValues(typeof(PaymentMethod));

            // Default values for fees
            txtLF.Text = "0.00";
            textBox3.Text = "0.00";
            txtCF.Text = "0.00";
            txtFC.Text = "0.00";

            // Wire up events for real-time total update
            txtLF.TextChanged += (s, e) => CalculateTotal();
            textBox3.TextChanged += (s, e) => CalculateTotal();
            txtCF.TextChanged += (s, e) => CalculateTotal();
            txtFC.TextChanged += (s, e) => CalculateTotal();
            txtBC.TextChanged += (s, e) => CalculateTotal();

            btcancel.Click += (s, e) => this.Close();

            CalculateCharges();
        }

        private void CalculateCharges()
        {
            if (_category == null) return;

            RateType selectedType = (RateType)cmbVT.SelectedItem;
            TimeSpan duration = dtpERD.Value - dtpSRD.Value;
            decimal baseCharge = 0;

            switch (selectedType)
            {
                case RateType.Hourly:
                    txtAR.Text = _category.HourlyRate.ToString("C");
                    baseCharge = (decimal)Math.Ceiling(duration.TotalHours) * _category.HourlyRate;
                    break;
                case RateType.Daily:
                    txtAR.Text = _category.DailyRate.ToString("C");
                    baseCharge = (decimal)Math.Ceiling(duration.TotalDays) * _category.DailyRate;
                    break;
                case RateType.Weekly:
                    txtAR.Text = _category.WeeklyRate.ToString("C");
                    baseCharge = (decimal)Math.Ceiling(duration.TotalDays / 7.0) * _category.WeeklyRate;
                    break;
                case RateType.Monthly:
                    txtAR.Text = _category.MonthlyRate.ToString("C");
                    baseCharge = (decimal)Math.Ceiling(duration.TotalDays / 30.0) * _category.MonthlyRate;
                    break;
            }

            txtBC.Text = baseCharge.ToString("N2");
            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal baseCharge = TryParseDecimal(txtBC.Text);
            decimal lateFee = TryParseDecimal(txtLF.Text);
            decimal damageFee = TryParseDecimal(textBox3.Text);
            decimal cleaningFee = TryParseDecimal(txtCF.Text);
            decimal fuelCharge = TryParseDecimal(txtFC.Text);

            decimal total = baseCharge + lateFee + damageFee + cleaningFee + fuelCharge;
            materialLabel16.Text = total.ToString("N2");
        }

        private decimal TryParseDecimal(string text)
        {
            decimal.TryParse(text, out decimal result);
            return result;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalculateCharges();
        }

        private void dtpSRD_ValueChanged(object sender, EventArgs e)
        {
            CalculateCharges();
        }

        private void dtpERD_ValueChanged(object sender, EventArgs e)
        {
            CalculateCharges();
        }

        private void btcheckout_Click(object sender, EventArgs e)
        {
            if (!btcheckout.Enabled) return; // Guard
            btcheckout.Enabled = false;

            try
            {
                // 1. Create Invoice
                Invoice invoice = new Invoice
                {
                    RentalId = _rental.Id,
                    IssueDate = DateTime.Now,
                    RentalCharge = TryParseDecimal(txtBC.Text),
                    AppliedRateType = (RateType)cmbVT.SelectedItem,
                    LateFee = TryParseDecimal(txtLF.Text),
                    DamageFee = TryParseDecimal(textBox3.Text),
                    FuelCharge = TryParseDecimal(txtFC.Text),
                    CleaningFee = TryParseDecimal(txtCF.Text),
                    IsPaid = true
                };

                invoice.CalculateTotal();
                _billingManager.CreateInvoice(invoice);

                // 2. Create Payment record (Optional but good for history)
                Payment payment = new Payment
                {
                    InvoiceId = invoice.Id,
                    Amount = invoice.TotalAmount,
                    PaymentDate = DateTime.Now,
                    Method = (PaymentMethod)cmbPM.SelectedItem
                };
                _billingManager.ProcessPayment(payment);


                MessageBox.Show("Invoice processed and payment recorded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing checkout: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialLabel2_Click(object sender, EventArgs e) { }
        private void materialLabel1_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void materialLabel15_Click(object sender, EventArgs e) { }
    }
}

