using Business.Abstracts;
using Business.Request.User;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public User Add(CreateUserRequest request)
        {
            User user = new User()
            {
                Username = request.Username,
                Password = request.Password,
                Roles = request.Roles
            };
            _userDal.Add(user);
            return user;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User GetById(int id)
        {
            return _userDal.Get(u => u.Id == id);
        }

        public User GetUserByUsername(string username)
        {
            var user = _userDal.Get(u => u.Username == username);
            return user;
        }

        public User GetUserByUsernameAndPassword(GetCustomerByUsernameAndPasswordRequest request)
        {
            var user = _userDal.Get(u => u.Password == request.Password && u.Username == request.Username);
            return user;
        }
    }
}
