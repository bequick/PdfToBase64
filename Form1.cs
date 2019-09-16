using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace PdbBase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = @"c:\",
                Title = "Agregar archivo PDF",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "pdf",
                Filter = "pdf files (*.pdf) | *.pdf",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPathFile.Text = openFileDialog.FileName;
            }
        }

        private void BtnToBase64_Click(object sender, EventArgs e)
        {
            byte[] pdfBytes = File.ReadAllBytes(txtPathFile.Text);
            string pdfBase64 = Convert.ToBase64String(pdfBytes);
            txtEditor.Text = pdfBase64;
        }

        private void BtnToTxt_Click(object sender, EventArgs e)
        {
            string path = Path.GetFullPath(txtPathFile.Text);
            string fileName = Path.GetFileName(txtPathFile.Text);
            string fileNameTxt = path + fileName.Replace("pdf", "txt");
            string saveText = txtEditor.Text;
            File.WriteAllText(fileNameTxt, saveText);
        }

        private void BtnToPdf_Click(object sender, EventArgs e)
        {
            byte[] bytes = Convert.FromBase64String(txtEditor.Text);
            string pathPdf = @"c:\Temp\resultado.pdf";

            FileStream stream = new FileStream(pathPdf, FileMode.CreateNew);
            BinaryWriter writer = new BinaryWriter(stream);
            writer.Write(bytes,0,bytes.Length);
            writer.Close();
        }
    }
}
