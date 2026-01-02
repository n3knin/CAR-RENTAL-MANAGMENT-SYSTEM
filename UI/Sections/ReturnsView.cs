using System.Windows.Forms;
using System;
using System.IO;

namespace RentalApp.UI.Sections
{
    public partial class ReturnsView : UserControl
    {
        public ReturnsView()
        {
            InitializeComponent();
            InitializeDragAndDrop();
        }

        private void InitializeDragAndDrop()
        {
            this.AllowDrop = true;
            this.DragEnter += ReturnsView_DragEnter;
            this.DragDrop += ReturnsView_DragDrop;
        }

        private void ReturnsView_DragEnter(object sender, DragEventArgs e)
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

        private void ReturnsView_DragDrop(object sender, DragEventArgs e)
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
            MessageBox.Show($"Files dropped on Returns View:\n\n{fileList}", 
                "Files Dropped", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void returnsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



