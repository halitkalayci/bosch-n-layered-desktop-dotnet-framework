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
    public partial class ErrorForm : Form
    {
        private string _errorMessage;
        public ErrorForm(string errorMessage)
        {
            _errorMessage = errorMessage;
            InitializeComponent();
        }

        private void ErrorForm_Load(object sender, EventArgs e)
        {
            errorLabel.Text = _errorMessage;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
