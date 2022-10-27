using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;
namespace WinFormsUI
{
    public partial class WebSampleForm : Form
    {
        public List<string> allowedDomains = new List<string>()
        {
            "https://www.bosch.com.tr/",
            "https://www.kodlama.io/"
        };
        public WebSampleForm()
        {
            InitializeComponent();
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await webView.EnsureCoreWebView2Async();
            // webView erişilebilir kısım
            webView.NavigationStarting += WebView_NavigationStarting;
            webView.CoreWebView2.DOMContentLoaded += CoreWebView2_DOMContentLoaded;
            webView.NavigationCompleted += WebView_NavigationCompleted;
            //await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("alert('sayfa yüklendi')");
            //await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage(document.getElementsByClassName('value')[0].textContent)");
            
            await webView.CoreWebView2.AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.postMessage('merhaba')");
            await webView.CoreWebView2
                .AddScriptToExecuteOnDocumentCreatedAsync("window.chrome.webview.addEventListener('message', event => document.getElementsByName('q')[0].value = event.data)");

            // WebMessage
            webView.CoreWebView2.WebMessageReceived += CoreWebView2_WebMessageReceived;
        }

        private void WebView_NavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
        {
            // tüm navigasyon işlemleri tamamlandığında
            string url = webView.Source.AbsoluteUri;
            textBox1.Text = url;
            //if (!allowedDomains.Contains(url))
            //{
            //    MessageBox.Show("Bu siteye erişemezsiniz.");
            //    webView.CoreWebView2.Navigate(allowedDomains[0]);
            //}
        }

        private void CoreWebView2_DOMContentLoaded(object sender, CoreWebView2DOMContentLoadedEventArgs e)
        {
            MessageBox.Show("Sayfa tamamen yüklendi");
            searchTb.Enabled = true;
        }

        private void CoreWebView2_WebMessageReceived(object sender, CoreWebView2WebMessageReceivedEventArgs e)
        {
            String url = e.Source;
            String message = e.TryGetWebMessageAsString();
            MessageBox.Show(message);
        }

        private void WebView_NavigationStarting(object sender, CoreWebView2NavigationStartingEventArgs e)
        {
            // gidilen URL http ile başlıyorsa engelle.
            
            String url = e.Uri;
            if (!url.StartsWith("https"))
            {
                webView.CoreWebView2.ExecuteScriptAsync("alert('HTTP ile başlayan sitelere erişemezsiniz.')");
                e.Cancel = true;
            }
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Navigate(textBox1.Text);
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.Reload();
        }

        private void sendMsgBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.PostWebMessageAsString("Merhaba from winforms");
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            webView.CoreWebView2.PostWebMessageAsString(searchTb.Text);
        }
    }
}
