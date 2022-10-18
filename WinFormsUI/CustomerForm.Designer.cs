namespace WinFormsUI
{
    partial class CustomerForm
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
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.addCustomGroup = new System.Windows.Forms.GroupBox();
            this.addCustomerBtn = new System.Windows.Forms.Button();
            this.companyNameTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthDateDp = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.identityNumberTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.updateCustomerGb = new System.Windows.Forms.GroupBox();
            this.updateCustomerBtn = new System.Windows.Forms.Button();
            this.updateCompanyNameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.updateCustomerIdTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.addCustomGroup.SuspendLayout();
            this.updateCustomerGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AllowUserToAddRows = false;
            this.customersDataGridView.AllowUserToDeleteRows = false;
            this.customersDataGridView.AllowUserToOrderColumns = true;
            this.customersDataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.customersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.customersDataGridView.MultiSelect = false;
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.ReadOnly = true;
            this.customersDataGridView.RowHeadersWidth = 51;
            this.customersDataGridView.RowTemplate.Height = 24;
            this.customersDataGridView.Size = new System.Drawing.Size(1094, 205);
            this.customersDataGridView.TabIndex = 0;
            this.customersDataGridView.SelectionChanged += new System.EventHandler(this.customersDataGridView_SelectionChanged);
            // 
            // addCustomGroup
            // 
            this.addCustomGroup.Controls.Add(this.addCustomerBtn);
            this.addCustomGroup.Controls.Add(this.companyNameTb);
            this.addCustomGroup.Controls.Add(this.label5);
            this.addCustomGroup.Controls.Add(this.birthDateDp);
            this.addCustomGroup.Controls.Add(this.label4);
            this.addCustomGroup.Controls.Add(this.surnameTb);
            this.addCustomGroup.Controls.Add(this.label3);
            this.addCustomGroup.Controls.Add(this.nameTb);
            this.addCustomGroup.Controls.Add(this.label2);
            this.addCustomGroup.Controls.Add(this.identityNumberTb);
            this.addCustomGroup.Controls.Add(this.label1);
            this.addCustomGroup.Location = new System.Drawing.Point(12, 234);
            this.addCustomGroup.Name = "addCustomGroup";
            this.addCustomGroup.Size = new System.Drawing.Size(241, 313);
            this.addCustomGroup.TabIndex = 1;
            this.addCustomGroup.TabStop = false;
            this.addCustomGroup.Text = "Add Customer";
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Location = new System.Drawing.Point(18, 261);
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(203, 34);
            this.addCustomerBtn.TabIndex = 10;
            this.addCustomerBtn.Text = "Add Customer";
            this.addCustomerBtn.UseVisualStyleBackColor = true;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // companyNameTb
            // 
            this.companyNameTb.Location = new System.Drawing.Point(121, 215);
            this.companyNameTb.Name = "companyNameTb";
            this.companyNameTb.Size = new System.Drawing.Size(100, 22);
            this.companyNameTb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Company Name";
            // 
            // birthDateDp
            // 
            this.birthDateDp.Location = new System.Drawing.Point(121, 173);
            this.birthDateDp.Name = "birthDateDp";
            this.birthDateDp.Size = new System.Drawing.Size(100, 22);
            this.birthDateDp.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Birth Date";
            // 
            // surnameTb
            // 
            this.surnameTb.Location = new System.Drawing.Point(121, 125);
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(100, 22);
            this.surnameTb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Surname";
            // 
            // nameTb
            // 
            this.nameTb.Location = new System.Drawing.Point(121, 80);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(100, 22);
            this.nameTb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // identityNumberTb
            // 
            this.identityNumberTb.Location = new System.Drawing.Point(121, 34);
            this.identityNumberTb.Name = "identityNumberTb";
            this.identityNumberTb.Size = new System.Drawing.Size(100, 22);
            this.identityNumberTb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identity Number";
            // 
            // updateCustomerGb
            // 
            this.updateCustomerGb.Controls.Add(this.updateCustomerIdTb);
            this.updateCustomerGb.Controls.Add(this.label7);
            this.updateCustomerGb.Controls.Add(this.updateCustomerBtn);
            this.updateCustomerGb.Controls.Add(this.updateCompanyNameTb);
            this.updateCustomerGb.Controls.Add(this.label6);
            this.updateCustomerGb.Location = new System.Drawing.Point(274, 234);
            this.updateCustomerGb.Name = "updateCustomerGb";
            this.updateCustomerGb.Size = new System.Drawing.Size(271, 153);
            this.updateCustomerGb.TabIndex = 2;
            this.updateCustomerGb.TabStop = false;
            this.updateCustomerGb.Text = "Update Customer";
            // 
            // updateCustomerBtn
            // 
            this.updateCustomerBtn.Location = new System.Drawing.Point(29, 103);
            this.updateCustomerBtn.Name = "updateCustomerBtn";
            this.updateCustomerBtn.Size = new System.Drawing.Size(203, 34);
            this.updateCustomerBtn.TabIndex = 21;
            this.updateCustomerBtn.Text = "Update Customer";
            this.updateCustomerBtn.UseVisualStyleBackColor = true;
            this.updateCustomerBtn.Click += new System.EventHandler(this.updateCustomerBtn_Click);
            // 
            // updateCompanyNameTb
            // 
            this.updateCompanyNameTb.Location = new System.Drawing.Point(132, 67);
            this.updateCompanyNameTb.Name = "updateCompanyNameTb";
            this.updateCompanyNameTb.Size = new System.Drawing.Size(100, 22);
            this.updateCompanyNameTb.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Company Name";
            // 
            // updateCustomerIdTb
            // 
            this.updateCustomerIdTb.Enabled = false;
            this.updateCustomerIdTb.Location = new System.Drawing.Point(132, 27);
            this.updateCustomerIdTb.Name = "updateCustomerIdTb";
            this.updateCustomerIdTb.Size = new System.Drawing.Size(100, 22);
            this.updateCustomerIdTb.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Customer ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(564, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Delete Customer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateCustomerGb);
            this.Controls.Add(this.addCustomGroup);
            this.Controls.Add(this.customersDataGridView);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.addCustomGroup.ResumeLayout(false);
            this.addCustomGroup.PerformLayout();
            this.updateCustomerGb.ResumeLayout(false);
            this.updateCustomerGb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.GroupBox addCustomGroup;
        private System.Windows.Forms.Button addCustomerBtn;
        private System.Windows.Forms.TextBox companyNameTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthDateDp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox identityNumberTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox updateCustomerGb;
        private System.Windows.Forms.Button updateCustomerBtn;
        private System.Windows.Forms.TextBox updateCompanyNameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateCustomerIdTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
    }
}