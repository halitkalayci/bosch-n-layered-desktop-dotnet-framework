using Business.Request.User;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        User GetById(int id);   
        List<User> GetAll();
        User GetUserByUsernameAndPassword(GetCustomerByUsernameAndPasswordRequest request);
        User GetUserByUsername(string username);

        User Add(CreateUserRequest request);
    }
}
