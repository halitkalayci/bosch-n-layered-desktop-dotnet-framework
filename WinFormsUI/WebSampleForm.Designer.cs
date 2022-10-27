namespace WinFormsUI
{
    partial class WebSampleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.sendMsgBtn = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)(this.webView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(954, 22);
            this.textBox1.TabIndex = 1;
            // 
            // goBtn
            // 
            this.goBtn.Location = new System.Drawing.Point(973, 24);
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(110, 23);
            this.goBtn.TabIndex = 2;
            this.goBtn.Text = "Go";
            this.goBtn.UseVisualStyleBackColor = true;
            this.goBtn.Click += new System.EventHandler(this.goBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(12, 66);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // sendMsgBtn
            // 
            this.sendMsgBtn.Location = new System.Drawing.Point(94, 65);
            this.sendMsgBtn.Name = "sendMsgBtn";
            this.sendMsgBtn.Size = new System.Drawing.Size(75, 23);
            this.sendMsgBtn.TabIndex = 4;
            this.sendMsgBtn.Text = "Send Message";
            this.sendMsgBtn.UseVisualStyleBackColor = true;
            this.sendMsgBtn.Click += new System.EventHandler(this.sendMsgBtn_Click);
            // 
            // searchTb
            // 
            this.searchTb.Enabled = false;
            this.searchTb.Location = new System.Drawing.Point(207, 66);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(156, 22);
            this.searchTb.TabIndex = 5;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(379, 66);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "Ara";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // webView
            // 
            this.webView.AllowExternalDrop = true;
            this.webView.CreationProperties = null;
            this.webView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView.Location = new System.Drawing.Point(12, 107);
            this.webView.Name = "webView";
            this.webView.Size = new System.Drawing.Size(1071, 621);
            this.webView.TabIndex = 7;
            this.webView.ZoomFactor = 1D;
            // 
            // WebSampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 740);
            this.Controls.Add(this.webView);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.sendMsgBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.goBtn);
            this.Controls.Add(this.textBox1);
            this.Name = "WebSampleForm";
            this.Text = "WebSampleForm";
            ((System.ComponentModel.ISupportInitialize)(this.webView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button sendMsgBtn;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchBtn;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}