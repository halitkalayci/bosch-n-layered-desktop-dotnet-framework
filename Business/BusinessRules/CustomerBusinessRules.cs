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
        IPaymentAdapter _paymentAdapter;
        public CustomerBusinessRules(ICustomerDal customerDal, IIdentityAdapter identityAdapter, IPaymentAdapter paymentAdapter)
        {
            _customerDal = customerDal;
            _identityAdapter = identityAdapter;
            _paymentAdapter = paymentAdapter;
        }
        public void CheckIfCustomerExist(string id)
        {
            Customer customer = _customerDal.GetById(id);
            CheckIfCustomerExist(customer);
        }

        public void CheckIfCustomerExist(Customer customer)
        {
            if (customer != null)
                throw new BusinessException("böyle bir müşteri zaten mevcut!");
        }

        public void CheckIfCustomerDoesNotExist(string id)
        {
            Customer customer = _customerDal.GetById(id);
            CheckIfCustomerDoesNotExist(customer);
        }

        public void CheckIfCustomerDoesNotExist(Customer customer)
        {
            if (customer == null)
                throw new BusinessException("Müşteri bulunamadı.");
        }

        public void CheckIfCustomerAcceptedTermsAndConditions(bool accepted)
        {
            if (accepted == false)
                throw new BusinessException("Müşteri kayıt etmek için şartları kabul etmelisiniz.");
        }

        public void ValidateIdentity(long identityNumber, string name, string surname, int birthYear)
        {
            bool isIdentityValid = _identityAdapter.CheckIdentityNumber(identityNumber, name, surname, birthYear);
            if (!isIdentityValid)
                throw new BusinessException("Kimlik bilgileri doğrulanamadı.");
        }

        public void CheckIfPaymentSuccess(string cardNumber, string expireDate, int cvv, decimal price)
        {
            bool isPaymentSuccess = _paymentAdapter.Pay(cardNumber, expireDate, cvv, price);
            if (!isPaymentSuccess)
                throw new BusinessException("Ödeme yapılamadı.");
        }
    }
}
