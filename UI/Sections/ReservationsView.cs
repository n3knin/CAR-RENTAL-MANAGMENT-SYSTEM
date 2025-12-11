using System.Windows.Forms;
using System;
using System.IO;
using RentalApp.Models.Services;
using RentalApp.Models.Core;
namespace RentalApp.UI.Sections
{
    public partial class ReservationsView : UserControl
    {
        private ReservationManager _reservationManager;
        public ReservationsView()
        {
            InitializeComponent();
            _reservationManager = new ReservationManager();
            
            // Fix 1: Load data on startup
            LoadReservations();
            
            InitializeDragAndDrop();
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += ReservationsView_DragEnter;
            this.DragDrop += ReservationsView_DragDrop;
        }

        private void ReservationsView_DragEnter(object sender, DragEventArgs e)
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

        private void ReservationsView_DragDrop(object sender, DragEventArgs e)
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
            MessageBox.Show($"Files dropped on Reservations View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void LoadReservations()
        {
            try{
                var reservations = _reservationManager.GetAllReservations();
                var bindingSource = new BindingSource();
                bindingSource.DataSource = reservations;

                reservationsGrid.AutoGenerateColumns = true;
                reservationsGrid.DataSource = bindingSource;
                reservationsGrid.Refresh();
            }
            catch(Exception ex){
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fix 2: Added missing event handler
        private void reservationsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}



