
using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Services; // Needed for VehicleManager
using RentalApp.Models.Vehicles; // Needed for Vehicle list
using System.Collections.Generic;
using RentalApp.UI.Popups;
using RentalApp.Models.Core;

namespace RentalApp.UI.Sections
{
    public partial class VehiclesView : UserControl
    {
        private VehicleManager _vehicleManager;
        private RentalManager _rentalManager;
        private List<Vehicle> _allVehicles;

        public VehiclesView()
        {
            InitializeComponent();
            
            // Make columns stretch to fill width
            vehiclesGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            // Initialize Manager
            _vehicleManager = new VehicleManager();
            _rentalManager = new RentalManager();

            // Load Data immediately
            LoadVehicles();

            InitializeDragAndDrop();

            // Link search event
            searchTextBox.TextChanged += searchTextBox_TextChanged;
        }



        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += VehiclesView_DragEnter;
            this.DragDrop += VehiclesView_DragDrop;
        }

        private void VehiclesView_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void VehiclesView_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                HandleDroppedFiles(files);
            }
        }

        private void HandleDroppedFiles(string[] files)
        {
            string fileList = string.Join("\n", files);
            MessageBox.Show($"Files dropped on Vehicles View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void LoadVehicles()
        {
            try 
            {
                // Fetch data from DB
                _allVehicles = _vehicleManager.GetAllVehicles();
                UpdateGrid(_allVehicles);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
        }

        private void UpdateGrid(List<Vehicle> list)
        {
            var bindingSource = new BindingSource();
            bindingSource.DataSource = list;
            
            vehiclesGrid.AutoGenerateColumns = true;
            vehiclesGrid.DataSource = bindingSource;
            vehiclesGrid.ReadOnly = true;

            if (vehiclesGrid.Columns["VehicleId"] != null) vehiclesGrid.Columns["VehicleId"].Visible = false;
            if (vehiclesGrid.Columns["ImageUrl"] != null) vehiclesGrid.Columns["ImageUrl"].Visible = false;
            if (vehiclesGrid.Columns["CategoryId"] != null) vehiclesGrid.Columns["CategoryId"].Visible = false;
            if (vehiclesGrid.Columns["VehicleType"] != null) vehiclesGrid.Columns["VehicleType"].Visible = false;
            if (vehiclesGrid.Columns["VIN"] != null) vehiclesGrid.Columns["VIN"].Visible = false;
            if (vehiclesGrid.Columns["VehicleName"] != null) vehiclesGrid.Columns["VehicleName"].Visible = false;
            if (vehiclesGrid.Columns["LicensePlate"] != null) vehiclesGrid.Columns["LicensePlate"].HeaderText = "License Plate";
            if (vehiclesGrid.Columns["SeatingCapacity"] != null) vehiclesGrid.Columns["SeatingCapacity"].HeaderText = "Seating Capacity";
            vehiclesGrid.Refresh();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_allVehicles == null) return;

            string searchText = searchTextBox.Text.ToLower();
            
            if (string.IsNullOrWhiteSpace(searchText))
            {
                UpdateGrid(_allVehicles);
                return;
            }

            var filteredList = _allVehicles.FindAll(v => 
                v.Make.ToLower().Contains(searchText) || 
                v.Model.ToLower().Contains(searchText) || 
                v.LicensePlate.ToLower().Contains(searchText) ||
                v.Year.ToString().Contains(searchText)
            );

            UpdateGrid(filteredList);
        }

        private void vehiclesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void vehiclesGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var selectedVehicle = (Vehicle)vehiclesGrid.Rows[e.RowIndex].DataBoundItem;

            using (var detailsForm = new Popups.VehicleDetailsForm(selectedVehicle))
            {
                detailsForm.ShowDialog();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(Session.CurrentUserRole != "Admin")
            {
                MessageBox.Show("You do not have permission to add a vehicle.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var addForm = new Popups.AddVehicleForm())
            {
                addForm.ShowDialog();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(Session.CurrentUserRole != "Admin")
            {
                MessageBox.Show("You do not have permission to edit a vehicle.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(vehiclesGrid.CurrentRow != null && vehiclesGrid.CurrentRow.Index >= 0)
            {
                var selectedVehicle = (Vehicle)vehiclesGrid.CurrentRow.DataBoundItem;
                
                // Restriction: Can only edit Available vehicles (to prevent messing up active rentals/reservations)
                if (selectedVehicle.Status != RentalApp.Models.Vehicles.VehicleStatus.Available)
                {
                    MessageBox.Show($"You can only edit a vehicle when its status is 'Available'.\nCurrent Status: {selectedVehicle.Status}", 
                                    "Edit Restricted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (var editForm = new Popups.EditVehicle(selectedVehicle))
                {
                   if(editForm.ShowDialog() == DialogResult.OK)
                   {
                       LoadVehicles();
                   }
                }
            }
            else
            {
                MessageBox.Show("Please select a vehicle to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void headerLabel_Click(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void searchLabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if(Session.CurrentUserRole != "Admin")
            {
                MessageBox.Show("You do not have permission to delete a vehicle.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(vehiclesGrid.CurrentRow != null && vehiclesGrid.CurrentRow.Index >= 0)
            {
                var selectedVehicle = (Vehicle)vehiclesGrid.CurrentRow.DataBoundItem;
                
                // Check if vehicle is currently rented
                if (_rentalManager.IsVehicleRented(selectedVehicle.VehicleId))
                {
                    MessageBox.Show("Cannot remove vehicle. It is currently associated with an ACTIVE RENTAL.\nPlease complete the return process before removing this vehicle.", 
                        "Action Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to remove this vehicle from the active fleet?", "Retire Vehicle", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    _vehicleManager.RetireVehicle(selectedVehicle.VehicleId);
                    LoadVehicles();
                }   
            }
            else
            {
                MessageBox.Show("Please select a vehicle to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            if(Session.CurrentUserRole != "Admin")
            {
                MessageBox.Show("You do not have permission to add a vehicle.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (vehiclesGrid.CurrentRow != null && vehiclesGrid.CurrentRow.Index >= 0)
            {
                var selectedVehicle = (Vehicle)vehiclesGrid.CurrentRow.DataBoundItem;
                using (var addMaintenanceForm = new Popups.MaintenaceHistory(selectedVehicle))
                {
                    if (addMaintenanceForm.ShowDialog() == DialogResult.OK)
                    {
                        LoadVehicles();
                    }
                }
            }
        }
    }
}
