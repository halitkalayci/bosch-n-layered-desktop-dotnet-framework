using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class SamplesForm : Form
    {
        public SamplesForm()
        {
            InitializeComponent();
        }

        private void SamplesForm_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "CategoryName";
            comboBox1.ValueMember = "CategoryID";
            List<Category> categories = new List<Category>()
            {
                new Category(){CategoryName="Kategori 1", CategoryID=1},
                new Category(){CategoryName="Kategori 2", CategoryID=2},
            };
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(categories.ToArray());

            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipTitle = "Bildirim örneği";
            notifyIcon1.BalloonTipText = "Bu bir ballon bildirim örneğidir.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;

            notifyIcon1.ShowBalloonTip(2000);

            // Çalıştığınız marka imagelarını listeye depola

            progressBar1.Value += 50;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Console.WriteLine($"Şartların kabul edilme durumu: {checkBox1.Checked}");
            progressBar1.Value += 50;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category selectedCategory = (Category)comboBox1.SelectedItem;
            Console.WriteLine($"Seçilen kategori: {selectedCategory.CategoryName}");
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Müşterinin siparişlerini içeren formu render et..

        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Load Progress" + sender);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
