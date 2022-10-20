using AutoMapper;
using Business.Abstracts;
using Business.Adapters;
using Business.Adapters.Abstracts;
using Business.Adapters.Concretes;
using Business.BusinessRules;
using Business.Concretes;
using Business.Profiles;
using Business.Request.Customer;
using Business.Response.Customer;
using Core.Exceptions;
using DataAccess.Abstracts;
using DataAccess.Concretes.Adonet;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsUI.Helpers;

namespace WinFormsUI
{
    public partial class CustomerForm : Form
    {
        private ICustomerService _customerService;
        public CustomerForm()
        {
            ICustomerDal _customerDal = new AdoCustomerDal();
            AutoMapperProfiles autoMapperProfiles = new AutoMapperProfiles();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(autoMapperProfiles);
            });
            IMapper mapper = new Mapper(mapperConfig);
            IIdentityAdapter identityAdapter = new KPSIdentityAdapter();
            IPaymentAdapter paymentAdapter = new BoschPaymentAdapter();
            _customerService = new
                CustomerManager(_customerDal,
                new CustomerBusinessRules(_customerDal, identityAdapter, paymentAdapter),
                mapper);
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            //SqlConnection sqlConnection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDb;Initial Catalog=Northwind;");
            //SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Customers", sqlConnection);
            //DataSet dataSet = new DataSet();
            //sqlConnection.Open();
            //dataAdapter.Fill(dataSet, "Customers");
            //sqlConnection.Close();
            //customersDataGridView.DataSource = dataSet;
            //customersDataGridView.DataMember = "Customers";


            // Abstraction
            // Adapters
            getAllCustomers();
        }


        private void getAllCustomers()
        {
            customersDataGridView.DataSource = _customerService.GetAll();
        }

        //ListCustomerResponse için, tablodaki tüm alanları dahil et.
        //Ekleme, güncelleme için validatorler ekle.

        //Silmek için buton, eklemek ve update etmek için ilgili grupları ekle.

        private void customersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (customersDataGridView.SelectedRows.Count <= 0) return;
            var firstlySelectedRow = customersDataGridView.SelectedRows[0];
            Console.WriteLine(firstlySelectedRow.Cells["CustomerID"].Value);
            Console.WriteLine("Selection Changed");

            updateCompanyNameTb.Text = firstlySelectedRow.Cells["CompanyName"].Value?.ToString();
            updateCustomerIdTb.Text = firstlySelectedRow.Cells["CustomerId"].Value?.ToString();
            updateContactNameTb.Text = firstlySelectedRow.Cells["ContactName"].Value?.ToString();
            updateAddressTb.Text = firstlySelectedRow.Cells["Address"].Value?.ToString();
            updateCityTb.Text = firstlySelectedRow.Cells["City"].Value?.ToString();
            updateRegionTb.Text = firstlySelectedRow.Cells["Region"].Value?.ToString();
            updatePostalCodeTb.Text = firstlySelectedRow.Cells["PostalCode"].Value?.ToString();
            updateCountryTb.Text = firstlySelectedRow.Cells["Country"].Value?.ToString();
            updatePhoneTb.Text = firstlySelectedRow.Cells["Phone"].Value?.ToString();
            updateFaxTb.Text = firstlySelectedRow.Cells["Fax"].Value?.ToString();

        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            CreateCustomerRequest createCustomerRequest = new CreateCustomerRequest()
            {
                Name = nameTb.Text,
                Surname = surnameTb.Text,
                BirthDate = addTimePicker.Value,
                IdentityNumber = identityNumberTb.Text,
                CompanyName = companyNameTb.Text,
                ContactName = addContactNameTb.Text,
                Address = addAddressTb.Text,
                City = addCityTb.Text,
                Region = addRegionTb.Text,
                PostalCode = addPostalCodeTb.Text,
                Country = addCountryTb.Text,
                Phone = addPhoneTb.Text,
                Fax = addFaxTb.Text
            };
            _customerService.Add(createCustomerRequest);
            MessageHelper.ShowSuccessMessage("Başarıyla eklendi");
            getAllCustomers();
        }

        private void updateCustomerBtn_Click(object sender, EventArgs e)
        {
            UpdateCustomerRequest updateCustomerRequest = new UpdateCustomerRequest()
            {
                CustomerID = updateCustomerIdTb.Text,
                CompanyName = updateCompanyNameTb.Text,
                ContactName = updateContactNameTb.Text,
                Address = updateAddressTb.Text,
                City = updateCityTb.Text,
                Region = updateRegionTb.Text,
                PostalCode = updatePostalCodeTb.Text,
                Country = updateCountryTb.Text,
                Phone = updatePhoneTb.Text,
                Fax = updateFaxTb.Text
            };
            _customerService.Update(updateCustomerRequest);
            MessageHelper.ShowSuccessMessage("Başarıyla güncellendi");
            getAllCustomers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
