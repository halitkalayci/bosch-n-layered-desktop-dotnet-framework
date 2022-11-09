using Business.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class UploadDbForm : Form
    {
        private IDocumentService _documentService;
        public UploadDbForm()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();

            if(result == DialogResult.OK)
            {
                filePathTb.Text = openFileDialog.FileName;
            }
        }

        private void uploadBtn_Click(object sender, EventArgs e)
        {
            // Document entitysi oluştur.
            // Document.Data = dosyayı oku byte[]'e çevir.
            using(Stream stream = File.OpenRead(filePathTb.Text))
            {
                byte[] data = new byte[stream.Length];
                stream.Read(data,0,data.Length);

                var fileInfo = new FileInfo(filePathTb.Text);

                // TODO: Mapping..
                Document document = new Document()
                {
                    Data=data,
                    Extension = fileInfo.Extension,
                    FileName = fileInfo.Name
                };
                //DB'Ye ekleme gerçekleşmeli..
            }
        }
    }
}
