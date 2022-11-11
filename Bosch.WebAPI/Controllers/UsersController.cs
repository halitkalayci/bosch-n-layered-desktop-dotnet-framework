using Business.Abstracts;
using Business.Concretes;
using Business.Request.User;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Concretes.InMemory;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using HttpDeleteAttribute = System.Web.Mvc.HttpDeleteAttribute;
using HttpGetAttribute = System.Web.Mvc.HttpGetAttribute;
using HttpPostAttribute = System.Web.Mvc.HttpPostAttribute;

namespace Bosch.WebAPI.Controllers
{
    public class UsersController : ApiController
    {
        private IUserService _userService;
        private IUserDal _userDal;
        public UsersController()
        {
            _userDal = new EfUserDal();
            _userService = new UserManager(_userDal);
        }

        [HttpGet]
        public List<User> Get()
        {
            return _userService.GetAll();
        }
        [HttpGet]
        public User GetById(int id)
        {
            return _userService.GetById(id);
        }
        //[HttpGet]
        //public User GetById()
        //{
        //    var id = int.Parse(Request.Headers.FirstOrDefault(c => c.Key == "Id").Value.FirstOrDefault());
        //    return _userService.GetById(id);
        //}
        [HttpPost]
        public IHttpActionResult Add([FromBody] CreateUserRequest request)
        {
            var user = _userService.Add(request);
            return Created("", user);
        }
        //[HttpPost]
        //public IHttpActionResult Add([FromBody] CreateUserRequest request)
        //{
        //    var headers = Request.Headers;
        //    var userId = headers.FirstOrDefault(h => h.Key == "UserId").Value.FirstOrDefault();
        //    var user = _userService.Add(request);
        //    return Created("", user);
        //}
    }
}
