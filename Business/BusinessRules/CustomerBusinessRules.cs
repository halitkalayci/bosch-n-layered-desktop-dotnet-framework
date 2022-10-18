using Business.Adapters.Abstracts;
using Core.Exceptions;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.BusinessRules
{
    public class CustomerBusinessRules
    {
        ICustomerDal _customerDal;
        IIdentityAdapter _identityAdapter;

        public CustomerBusinessRules(ICustomerDal customerDal, IIdentityAdapter identityAdapter)
        {
            _customerDal = customerDal;
            _identityAdapter = identityAdapter;
        }
        public void CheckIfCustomerExist(string id)
        {
            Customer customer = _customerDal.GetById(id);
            CheckIfCustomerExist(customer);
        }

        public void CheckIfCustomerExist(Customer customer)
        {
            if (customer != null)
                throw new Exception("böyle bir müşteri zaten mevcut!");
        }

        public void CheckIfCustomerDoesNotExist(string id)
        {
            Customer customer = _customerDal.GetById(id);
            CheckIfCustomerDoesNotExist(customer);
        }

        public void CheckIfCustomerDoesNotExist(Customer customer)
        {
            if (customer == null)
                throw new Exception("Müşteri bulunamadı.");
        }

        public void ValidateIdentity(long identityNumber,string name,string surname,int birthYear)
        {
            bool isIdentityValid = _identityAdapter.CheckIdentityNumber(identityNumber,name,surname,birthYear);
            if (!isIdentityValid)
                throw new BusinessException("Kimlik bilgileri doğrulanamadı.");
        }
    }
}
