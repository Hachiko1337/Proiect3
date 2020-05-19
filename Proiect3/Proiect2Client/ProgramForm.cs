using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Proiect2ObjectWCF;

namespace Proiect2Client
{
    public partial class ProgramForm : Form
    {
        private FileMetadataPropertyClient fileService = new FileMetadataPropertyClient();


        public ProgramForm()
        {
            InitializeComponent();
        }

        private void addImageVideoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> acceptedTypes = new List<string>();
            acceptedTypes.Add(".png");
            acceptedTypes.Add(".jpg");
            acceptedTypes.Add(".jpeg");
            acceptedTypes.Add(".mp4");
            acceptedTypes.Add(".avi");
            var fileDialog = new OpenFileDialog();
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if (System.IO.File.Exists(fileDialog.FileName) && acceptedTypes.Contains(new FileInfo(fileDialog.FileName).Extension))
                    {
                        var fileToSave = new FileDTO() { FilePath = fileDialog.FileName, Properties = new PropertyDTO[1] };
                        fileService.SaveFile(fileToSave);
                        //MessageBox.Show("Debug.");
                        reloadImages();

                    }
                    else
                    {
                        throw new Exception("File doesn't exist or is not the appropriate type.");
                    }
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reloadImages();
        }

        private void reloadImages()
        {
            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            imageColumn.Name = "Image";
            imageColumn.HeaderText = "Image";
            ImageGridView.Columns.Insert(0, imageColumn);

            fileService.GetAllFiles().ToList().ForEach(file =>
            {
                //MessageBox.Show(file.FilePath);
                if (System.IO.File.Exists(file.FilePath))
                {
                    ImageGridView.Rows.Add(Image.FromFile(file.FilePath));
                }
            });
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
