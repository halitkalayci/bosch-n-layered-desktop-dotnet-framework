using Business.Constants;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class UploadContentForm : Form
    {
        string filePath;
        public UploadContentForm()
        {
            InitializeComponent();
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image | *.png;*.jpg";
            DialogResult result = fileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(fileDialog.FileName);
                filePath = fileDialog.FileName;
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            selectBtn.Enabled = false;
            uploadBtn.Enabled = false;
            backgroundWorker1.RunWorkerAsync();
        }

        private void DoUpload()
        {
            string cloudName = ConfigurationManager
                .AppSettings[ConfigKeyContants.CloudinaryCloudName];

            string apiKey = ConfigurationManager
                .AppSettings[ConfigKeyContants.CloudinaryApiKey];

            string apiSecret = ConfigurationManager
                .AppSettings[ConfigKeyContants.CloudinaryApiSecret];


            Account cloudinaryAccount = new Account(cloudName,apiKey,apiSecret);

            Cloudinary cloudinary = new Cloudinary(cloudinaryAccount);
            if (!string.IsNullOrEmpty(filePath))
            {
                ImageUploadParams imageUploadParams = new ImageUploadParams();
                imageUploadParams.File = new FileDescription(filePath);
                imageUploadParams.UseFilename = true;
                imageUploadParams.UseFilenameAsDisplayName = true;
                cloudinary.Upload(imageUploadParams);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DoUpload();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Dosya yüklemesi başarılı!");
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }
    }
}
