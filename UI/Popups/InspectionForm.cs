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
        public partial class InspectionForm : Form
        {
            private Rental _rental;
            private RentalManager _rentalManager;
            private VehicleManager _vehicleManager;
            private VehicleInspectionManager _inspectionManager;
            private ReservationManager _reservationManager;

            public InspectionForm()
            {
                InitializeComponent();
                _rentalManager = new RentalManager();
                _vehicleManager = new VehicleManager();
                _inspectionManager = new VehicleInspectionManager();
                _reservationManager = new ReservationManager();
            
                ConfigureDatePickers();
                GroupRadioButtons();
                PopulateComboBoxes();
            }

            private void ConfigureDatePickers()
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm tt";
            
                dateTimePicker2.Format = DateTimePickerFormat.Custom;
                dateTimePicker2.CustomFormat = "MM/dd/yyyy hh:mm tt";
            }

            private void GroupRadioButtons()
            {
                Panel smokingPanel = new Panel();
                smokingPanel.Location = new Point(svYesbt.Left - 5, svYesbt.Top - 5);
                smokingPanel.Size = new Size(svNobt.Right - svYesbt.Left + 10, svYesbt.Height + 10);
                smokingPanel.BackColor = this.BackColor;
            
                this.Controls.Remove(svYesbt);
                this.Controls.Remove(svNobt);
            
                svYesbt.Location = new Point(5, 5);
                svNobt.Location = new Point(svNobt.Left - smokingPanel.Left + 5, 5);
            
                smokingPanel.Controls.Add(svYesbt);
                smokingPanel.Controls.Add(svNobt);
                this.Controls.Add(smokingPanel);

                Panel accessoriesPanel = new Panel();
                accessoriesPanel.Location = new Point(caYesbt.Left - 5, caYesbt.Top - 5);
                accessoriesPanel.Size = new Size(caNobt.Right - caYesbt.Left + 10, caYesbt.Height + 10);
                accessoriesPanel.BackColor = this.BackColor;
            
                this.Controls.Remove(caYesbt);
                this.Controls.Remove(caNobt);
            
                caYesbt.Location = new Point(5, 5);
                caNobt.Location = new Point(caNobt.Left - accessoriesPanel.Left + 5, 5);
            
                accessoriesPanel.Controls.Add(caYesbt);
                accessoriesPanel.Controls.Add(caNobt);
                this.Controls.Add(accessoriesPanel);
            }
        
            private void PopulateComboBoxes()
            {
                //   Condition
                cmbIC.Items.Clear();
                foreach (Condition condition in Enum.GetValues(typeof(Condition)))
                {
                    cmbIC.Items.Add(condition);
                }
                cmbIC.SelectedIndex = 0;
            
                // Exterior Condition
                cmbEC.Items.Clear();
                foreach (Condition condition in Enum.GetValues(typeof(Condition)))
                {
                    cmbEC.Items.Add(condition);
                }
                cmbEC.SelectedIndex = 0;
            
                // Fuel Level
                cmbFL.Items.Clear();
                foreach (FuelLevel fuel in Enum.GetValues(typeof(FuelLevel)))
                {
                    cmbFL.Items.Add(fuel);
                }
                cmbFL.SelectedIndex = 0;
            }

            public void LoadData(Rental rental)
            {
                _rental = rental;
                this.Text = "Vehicle Inspection - Return";
            
                txtrsv.Text = rental.Id.ToString();
                txtcstmr.Text = rental.CustomerName;
                txtsm.Text = rental.StartMileage.ToString(); 
            
                if (rental.ExpectedReturnDate.HasValue)
                {
                    dateTimePicker1.Value = rental.ExpectedReturnDate.Value;
                    dateTimePicker1.Enabled = false; 
                }
            
                dateTimePicker2.Value = DateTime.Now;
            }

            private void svbt_Click(object sender, EventArgs e)
            {

                if (int.Parse(txtsm.Text)>int.Parse(txtem.Text))
                {
                    MessageBox.Show("End mileage cannot be less than start mileage.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                
                    if (string.IsNullOrWhiteSpace(txtem.Text))
                    {
                        MessageBox.Show("Please enter the end mileage.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                
                    if (cmbIC.SelectedItem == null || cmbEC.SelectedItem == null || cmbFL.SelectedItem == null)
                    {
                        MessageBox.Show("Please select all inspection conditions.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                
                    var inspection = new VehicleInspection
                    {
                        RentalId = _rental.Id,
                        Type = InspectionType.Return,
                        InspectedBy = Session.CurrentUserId,
                        InspectionDate = dateTimePicker2.Value,
                        InteriorCondition = (Condition)Enum.Parse(typeof(Condition), cmbIC.SelectedItem.ToString()),
                        ExteriorCondition = (Condition)Enum.Parse(typeof(Condition), cmbEC.SelectedItem.ToString()),
                        Fuel = (FuelLevel)Enum.Parse(typeof(FuelLevel), cmbFL.SelectedItem.ToString()),
                        HasSmokingViolation = svYesbt.Checked,
                        AllAccessoriesReturned = caYesbt.Checked,
                        Mileage = int.Parse(txtem.Text),
                        Notes = textBox1.Text,
                    };
                    _inspectionManager.AddInspection(inspection);


                    _rental.ActualReturnDate = dateTimePicker2.Value;
                    _rental.EndMileage = int.Parse(txtem.Text);
                    _rental.Status = RentalStatus.Completed;
                    _rentalManager.UpdateRental(_rental);


                    var vehicle = _vehicleManager.GetVehicleById(_rental.VehicleId);
                    vehicle.Mileage = int.Parse(txtem.Text);
                    vehicle.Status = VehicleStatus.Available;
                    _vehicleManager.UpdateVehicle(vehicle);

                    if (_rental.ReservationId.HasValue)
                    {
                        _reservationManager.UpdateReservationStatus(_rental.ReservationId.Value, ReservationStatus.Completed);
                    }

                
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error processing return: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void txtrsv_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtcstmr_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtsm_TextChanged(object sender, EventArgs e)
            {

            }

            private void txtem_TextChanged(object sender, EventArgs e)
            {

            }

            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
            {

            }

            private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
            {

            }

            private void cmbIC_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void cmbEC_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void cmbFL_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void svYesbt_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void svNobt_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void caYesbt_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void caNobt_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void cnbt_Click(object sender, EventArgs e)
            {
                this.Close();
            }
        }
    }
