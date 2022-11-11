using AutoMapper;
using Bosch.MVC.Models;
using Bosch.MVC.ViewModels;
using Business.Abstracts;
using Business.Adapters.Abstracts;
using Business.Adapters.Concretes;
using Business.BusinessRules;
using Business.Concretes;
using Business.Loggers.Serilog;
using Business.Profiles;
using Core.CrossCuttingConcerns.Logging;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Bosch.MVC.Controllers
{

    public class HomeController : Controller
    {
        private ICategoryService _categoryService;

        public HomeController()
        {
            ICategoryDal categoryDal = new EfCategoryDal();
            AutoMapperProfiles autoMapperProfiles = new AutoMapperProfiles();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(autoMapperProfiles);
            });
            IMapper mapper = new Mapper(mapperConfig);
            LoggerServiceBase[] loggers = new LoggerServiceBase[] {  };
            _categoryService = new CategoryManager(categoryDal, new CategoryBusinessRules(categoryDal), mapper, loggers);
        }


        [Authorize]
        public async Task<ActionResult> Index()
        {
           
            var identity = (ClaimsIdentity)User.Identity;
            List<Claim> claims = identity.Claims.ToList();
            // Index.cshtml viewını yönettiğim kısım..
            HomepageViewModel model = new HomepageViewModel();
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);

            List<int> numbers2 = new List<int>();
            numbers2.Add(15);
            numbers2.Add(25);

            model.Numbers1 = numbers;
            model.Numbers2 = numbers2;
            ViewBag.Count = 10;
            return View(model);
        }
        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

    
        public ActionResult Error(string message)
        {
            ViewBag.Message = message;
            return View();
        }

        public async Task<ActionResult> Posts()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                var uri = new Uri("https://jsonplaceholder.typicode.com/posts");

                var response = await httpClient.GetAsync(uri);
                var content = await response.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<List<Post>>(content);
                return View(json);
            }
        }

        public async Task<ActionResult> Details(int id)
        {
            using(HttpClient httpClient=new HttpClient())
            {
                var stringUrl = $"https://jsonplaceholder.typicode.com/posts/{id}";
                httpClient.DefaultRequestHeaders.Add("User-Agent","Bosch");
                var post = new Post()
                {
                    UserId = 1,
                    Title = "MVCden gönderilen post",
                    Body = "MVC örnek"
                };
                var jsonToPost = JsonConvert.SerializeObject(post);

                var contentToAddBody = new StringContent(jsonToPost,Encoding.UTF8,"application/json");
                var postResponse = await httpClient.PostAsync("https://jsonplaceholder.typicode.com/posts", contentToAddBody);

                var response = await httpClient.GetAsync(stringUrl);
                var content = await response.Content.ReadAsStringAsync();

                var json = JsonConvert.DeserializeObject<Post>(content);

                return View(json);
            }
        }

    }
}