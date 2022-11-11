using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryUserDal : IUserDal
    {
        private List<User> users = new List<User>();
      

        public void Add(User entity)
        {
            this.users.Add(entity);
        }

        public void Delete(User entity)
        {
            this.users.Remove(entity);
        }

        public User Get(Expression<Func<User, bool>> filter = null)
        {
            var user = users.AsQueryable().FirstOrDefault(filter);
            return user;
        }

        public List<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            if (filter == null) return users;
            return users.AsQueryable().Where(filter).ToList();
        }

        public void Update(User entity)
        {
            //TODO
            throw new NotImplementedException();
        }
    }
}
