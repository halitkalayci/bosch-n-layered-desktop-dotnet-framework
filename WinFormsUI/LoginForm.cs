using Business.Adapters.Abstracts;
using Business.Adapters.Concretes;
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
    public partial class LoginForm : Form
    {
        private IAuthAdapter _authAdapter;
        private bool IsLoggedIn = false;
        public LoginForm()
        {
            InitializeComponent();
            _authAdapter = new BoschAuthAdapter();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            // AuthService
            Login(true);
        }

        private void Login(bool fromForm)
        {
            try
            {
                _authAdapter.Login(userNameTb.Text, passwordTb.Text);
                // Doğru giriş yapıldı..
                // Giriş bilgilerini sakla..
                // Storage, UserConfigurations
                // credentials.txt
                if (fromForm)
                    TrySaveCredentials();


                IsLoggedIn = true;
                Form1 form1 = new Form1();
                form1.Show();
            }
            catch (Exception ex)
            {
                // Girişte hata var..
                MessageBox.Show("Hatalı giriş..");
            }
        }
        private void TrySaveCredentials()
        {
            if (rememberMeCb.Checked)
            {
                Properties.Settings.Default.Username = userNameTb.Text;
                Properties.Settings.Default.Password = passwordTb.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = String.Empty;
                Properties.Settings.Default.Password = String.Empty;
                Properties.Settings.Default.Save();
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            var savedUsername = Properties.Settings.Default.Username;   
            var savedPassword = Properties.Settings.Default.Password;

            if(!string.IsNullOrEmpty(savedUsername) && !string.IsNullOrEmpty(savedPassword))
            {
                userNameTb.Text = savedUsername;
                passwordTb.Text = savedPassword;
                Login(false);
            }
        }

        private void LoginForm_Shown(object sender, EventArgs e)
        {
            if (IsLoggedIn)
                this.Hide();
        }
    }
}
