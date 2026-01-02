
using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Services; // Needed for VehicleManager
using RentalApp.Models.Vehicles; // Needed for Vehicle list

namespace RentalApp.UI.Sections
{
    public partial class VehiclesView : UserControl
    {
        private VehicleManager _vehicleManager;

        public VehiclesView()
        {
            InitializeComponent();
            
            // Initialize Manager
            _vehicleManager = new VehicleManager();

            // Load Data immediately
            LoadVehicles();

            InitializeDragAndDrop();
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
                var vehicleList = _vehicleManager.GetAllVehicles();
                
          

                // Bind to Grid using BindingSource (Better for DataGridView)
                var bindingSource = new BindingSource();
                bindingSource.DataSource = vehicleList;
                
                vehiclesGrid.AutoGenerateColumns = true;
                vehiclesGrid.DataSource = bindingSource;
                vehiclesGrid.ReadOnly = true;

                vehiclesGrid.Columns["VehicleId"].Visible = false;
                vehiclesGrid.Columns["ImageUrl"].Visible = false;
                vehiclesGrid.Columns["CategoryId"].Visible = false;
                vehiclesGrid.Columns["VIN"].Visible = false;
                vehiclesGrid.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message);
            }
        }

       

        

        private void vehiclesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void vehiclesGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            var selectedVehicle = (Vehicle)vehiclesGrid.CurrentRow.DataBoundItem;


            using (var detailsForm = new Popups.VehicleDetailsForm(selectedVehicle))
            {
                detailsForm.ShowDialog();
            }
        }
    }
}
