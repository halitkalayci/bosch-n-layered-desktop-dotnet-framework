using Business.Abstracts;
using Business.BusinessRules;
using Business.Concretes;
using Business.Response.Customer;
using DataAccess.Abstracts;
using DataAccess.Concretes.Adonet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsUI
{
    public partial class CustomerForm : Form
    {
        private ICustomerService _customerService;
        public CustomerForm()
        {
            ICustomerDal _customerDal = new AdoCustomerDal();
            _customerService = new CustomerManager(_customerDal, new CustomerBusinessRules(_customerDal));
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            // Verileri getir!
            // DataGridView'a ekle.
            // List<ListCustomerResponse> customers = _customerService.GetAll();
            // Data Source
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=Northwind;");
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Customers", sqlConnection);
            DataSet dataSet = new DataSet();
            sqlConnection.Open();
            dataAdapter.Fill(dataSet, "Customers");
            sqlConnection.Close();
            customersDataGridView.DataSource = dataSet;
            customersDataGridView.DataMember = "Customers";
        }
    }
}
