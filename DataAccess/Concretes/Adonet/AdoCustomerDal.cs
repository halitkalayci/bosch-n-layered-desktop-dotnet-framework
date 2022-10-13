using Core.DataAccess.Adonet.Helpers;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.Adonet
{
    public class AdoCustomerDal : ICustomerDal
    {
        public void Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter = null)
        {
            List<Customer> _customer = DbHelper.CreateReadConnection<Customer>("select * from Customers");
            return filter != null ? _customer.AsQueryable().FirstOrDefault(filter) : _customer.FirstOrDefault();
        }


        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            List<Customer> _customer = DbHelper.CreateReadConnection<Customer>("select * from Customers");
            return filter != null ? _customer = _customer.AsQueryable().Where(filter).ToList()  : _customer;
        }

        public Customer GetById(string id)
        {
            Customer customer = DbHelper.CreateReadConnection<Customer>($"select * from Customers where CustomerID='{id}'").FirstOrDefault();
            return customer;
        }

 

        public void Update(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
