using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class SuccessForm : Form
    {
        private string _successForm;
        public SuccessForm(string errorMessage)
        {
            _successForm = errorMessage;
            InitializeComponent();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            successLabel.Text = _successForm;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
