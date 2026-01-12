using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RentalApp.Models.Vehicles;
using RentalApp.Models.Core;
using RentalApp.Models.Services;

namespace RentalApp.UI.Popups
{
    public partial class EditVehicle : Form
    {
        private Vehicle _vehicle;
        private VehicleManager _vehicleManager;
        private RentalManager _rentalManager;
        public EditVehicle(Vehicle vehicle)
        {
            InitializeComponent();
            _vehicle = vehicle;

            txtyr.Text = _vehicle.Year.ToString(); 
            txtmake.Text = _vehicle.Make;
            txtmodel.Text = _vehicle.Model;
            txtLP.Text = _vehicle.LicensePlate;
            txtVIN.Text = _vehicle.VIN;
            txtmileage.Text = _vehicle.Mileage.ToString();
            txtcolor.Text = _vehicle.Color;
            txtSC.Text = _vehicle.SeatingCapacity.ToString();
            
            cmbTT.Text = _vehicle.Transmission.ToString();
            cmbVT.Text = _vehicle.GetVehicleType();
            cmbStatus.Text = _vehicle.Status.ToString();
            
            txtmake.ReadOnly = true;
            txtmodel.ReadOnly = true;
            txtyr.ReadOnly = true;
            txtLP.ReadOnly = true;
            txtVIN.ReadOnly = true;
            txtmileage.ReadOnly = true;
            txtcolor.ReadOnly = true;

            
            cmbTT.Enabled = false; 
            cmbVT.Enabled = false;

            cmbStatus.DataSource = Enum.GetValues(typeof(VehicleStatus));
            cmbStatus.SelectedItem = _vehicle.Status;
            
            _vehicleManager = new VehicleManager();
            _rentalManager = new RentalManager();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    
        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void svbt_Click(object sender, EventArgs e)
        {
   
            if(int.TryParse(txtyr.Text, out int y)) _vehicle.Year = y;
            _vehicle.Make = txtmake.Text;
            _vehicle.Model = txtmodel.Text;
            _vehicle.Color = txtcolor.Text;
            
            if(int.TryParse(txtmileage.Text, out int m)) _vehicle.Mileage = m;
            if(int.TryParse(txtSC.Text, out int sc)) _vehicle.SeatingCapacity = sc;

            // Save the selected status
            // Save the selected status
            if (cmbStatus.SelectedItem != null)
            {
                var newStatus = (VehicleStatus)cmbStatus.SelectedItem;
                
                // Check if attempting to change status while rented
                if (_vehicle.Status == VehicleStatus.Rented && newStatus != VehicleStatus.Rented)
                {
                    // Double check with DB to be sure
                    if (_rentalManager.IsVehicleRented(_vehicle.VehicleId))
                    {
                        MessageBox.Show("Cannot change status. This vehicle is currently associated with an ACTIVE RENTAL.\nPlease complete the return process first.", 
                            "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
                
                _vehicle.Status = newStatus;
            }

            _vehicleManager.UpdateVehicle(_vehicle);
            this.DialogResult = DialogResult.OK;
            MessageBox.Show("Vehicle updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void cnclbt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbVT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbTT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcolor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmileage_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVIN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmake_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmodel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
