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
        private DepositManager _depositManager;
        private Rental _rental;
        private VehicleCategory _category;
        private DamageReportManager _damageReportManager;
        private VehicleInspectionManager _inspectionManager;

        public InvoiceForm(Rental rental)
        {
            InitializeComponent();
            _billingManager = new BillingManager();
            _vehicleManager = new VehicleManager();
            _categoryManager = new CategoryManager();
            _rentalManager = new RentalManager();
            _depositManager = new DepositManager();
            _rental = rental;
            _damageReportManager = new DamageReportManager();
            _inspectionManager = new VehicleInspectionManager();

            InitializeForm();
        }

        private void InitializeForm()
        {
            // Set data
            textBox1.Text = _rental.CustomerName;
            textBox2.Text = _rental.VehicleInfo;
            
            
            // Configure DateTimePickers to show time
            dtpSRD.Format = DateTimePickerFormat.Custom;
            dtpSRD.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpSRD.ShowUpDown = false;
            dtpSRD.Value = _rental.ActualPickupDate;
            
            dtpERD.Format = DateTimePickerFormat.Custom;
            dtpERD.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpERD.ShowUpDown = false;
            dtpERD.Value = _rental.ActualReturnDate ?? DateTime.Now;

            // Load Category
            var vehicle = _vehicleManager.GetVehicleById(_rental.VehicleId);
            if (vehicle != null)
            {
                _category = _categoryManager.GetCategoryById(vehicle.CategoryId);
            }
            var deposit = _depositManager.GetDepositByRentalId(_rental.Id);
            var inspection = _inspectionManager.GetInspectionByRentalId(_rental.Id);
            var damageReport = inspection != null ? _damageReportManager.GetReportForInspection(inspection.Id) : null;
            cmbVT.DataSource = Enum.GetValues(typeof(RateType));
            cmbPM.DataSource = Enum.GetValues(typeof(PaymentMethod));

            
            decimal depositAmount = deposit != null ? deposit.Amount : 0;
            if (depositAmount >= 70 && depositAmount < 1000)
            {
                cmbVT.SelectedItem = RateType.Daily;
            }
            else if (depositAmount >= 1000 && depositAmount < 7000)
            {
                cmbVT.SelectedItem = RateType.Weekly;
            }
            else if (depositAmount >= 7000 && depositAmount < 20000)
            {
                cmbVT.SelectedItem = RateType.Monthly;
            }
            else
            {
                cmbVT.SelectedItem = RateType.Hourly;
            }

            // Default values for fees
            txtLF.Text = "0.00";    
            txtCF.Text = "0.00";
            txtFC.Text = "0.00";
            txtdeposit.Text = (deposit != null ? deposit.Amount : 0).ToString("N2");
            textBox3.Text = (damageReport != null ? damageReport.EstimatedCost : 0).ToString("N2");
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
            if (_category == null || cmbVT.SelectedItem == null) return;

            RateType selectedType;
            if (!Enum.TryParse(cmbVT.SelectedItem.ToString(), out selectedType)) return;

            TimeSpan duration = dtpERD.Value - dtpSRD.Value;
            
            // Simple check: if duration is zero or negative, no charge
            if (duration.TotalMinutes <= 0)
            {
                txtBC.Text = "0.00";
                CalculateTotal();
                return;
            }

            decimal units = 0;
            decimal rate = 0;

            switch (selectedType)
            {
                case RateType.Hourly:
                    rate = _category.HourlyRate;
                    units = (decimal)Math.Ceiling(duration.TotalHours);
                    break;
                case RateType.Daily:
                    rate = _category.DailyRate;
                    units = (decimal)Math.Ceiling(duration.TotalDays);
                    break;
                case RateType.Weekly:
                    rate = _category.WeeklyRate;
                    units = (decimal)Math.Ceiling(duration.TotalDays / 7.0);
                    break;
                case RateType.Monthly:
                    rate = _category.MonthlyRate;
                    units = (decimal)Math.Ceiling(duration.TotalDays / 30.0);
                    break;
            }

            // Ensure at least 1 unit is charged
            if (units < 1) units = 1;

            txtAR.Text = rate.ToString("F2"); // Format as plain number for parsing safety
            decimal baseCharge = units * rate;
            txtBC.Text = baseCharge.ToString("F2");

            // Calculate Late Fees (150 per hour for Daily rentals)
            decimal lateFee = 0;
            if (_rental.ExpectedReturnDate.HasValue && dtpERD.Value > _rental.ExpectedReturnDate.Value)
            {
                TimeSpan overdue = dtpERD.Value - _rental.ExpectedReturnDate.Value;
                if (selectedType == RateType.Daily)
                {
                    lateFee = (decimal)overdue.TotalHours * 150;
                }
            }
            txtLF.Text = lateFee.ToString("F2");

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            decimal baseCharge = TryParseDecimal(txtBC.Text);
            decimal lateFee = TryParseDecimal(txtLF.Text);
            decimal damageFee = TryParseDecimal(textBox3.Text);
            decimal cleaningFee = TryParseDecimal(txtCF.Text);
            decimal fuelCharge = TryParseDecimal(txtFC.Text);
            decimal deposit = TryParseDecimal(txtdeposit.Text);
            decimal total = baseCharge + lateFee + damageFee + cleaningFee + fuelCharge - deposit;
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

                // 3. Mark Deposit as Applied (so it's not refunded later)
                var deposit = _depositManager.GetDepositByRentalId(_rental.Id);
                if (deposit != null)
                {
                    _depositManager.ApplyToInvoice(deposit.Id);
                }

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbPM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel17_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFC_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel13_Click(object sender, EventArgs e)
        {

        }

        private void txtCF_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void materialLabel11_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel10_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel9_Click(object sender, EventArgs e)
        {

        }

        private void txtLF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBC_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel8_Click(object sender, EventArgs e)
        {

        }

        private void txtAR_TextChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel7_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel6_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel5_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btcancel_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel16_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel15_Click_1(object sender, EventArgs e)
        {

        }

        private void materialLabel14_Click(object sender, EventArgs e)
        {

        }
    }
}

