using AutoMapper;
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
using System;
using System.Collections.Generic;
using System.Linq;
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
            LoggerServiceBase[] loggers = new LoggerServiceBase[] { new MSSqlLogger() };
            _categoryService = new CategoryManager(categoryDal, new CategoryBusinessRules(categoryDal), mapper, loggers);
        }

        public ActionResult Index()
        {
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

    }
}