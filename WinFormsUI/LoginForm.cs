using Business.Adapters.Abstracts;
using Business.Adapters.Concretes;
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
    public partial class LoginForm : Form
    {
        private IAuthAdapter _authAdapter;
        public LoginForm()
        {
            InitializeComponent();
            _authAdapter = new BoschAuthAdapter();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // AuthService
            try
            {
                _authAdapter.Login(userNameTb.Text, passwordTb.Text);
                // Doğru giriş yapıldı..
                // Giriş bilgilerini sakla..
                // Storage, UserConfigurations
                // credentials.txt

                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            catch(Exception ex)
            {
                // Girişte hata var..
                MessageBox.Show("Hatalı giriş..");
            }
        }
    }
}
