using AutoMapper;
using Business.Abstracts;
using Business.BusinessRules;
using Business.Concretes;
using Business.Loggers.Serilog;
using Business.Profiles;
using Business.Request;
using Core.CrossCuttingConcerns.Logging;
using Core.Exceptions;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bosch.MVC.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryService _categoryService;

        public CategoriesController()
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
            var categories = _categoryService.GetAll();
            return View(categories);
        }
        public ActionResult Details(int id)
        {
            var category = _categoryService.GetById(id);
            string msg = null;
            ViewBag.Length = msg.Length;
            return View(category);
        }
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(CreateCategoryRequest request)
        {
            _categoryService.Add(request);
            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Update(UpdateCategoryRequest request)
        {
            _categoryService.Update(request);
            return RedirectToAction("Details", new { Id = request.Id });
        }

        public ActionResult Delete(int id)
        {
            DeleteCategoryRequest request = new DeleteCategoryRequest()
            {
                Id = id
            };
            _categoryService.Delete(request);
            return RedirectToAction("Index");
        }


        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;


            string message = "Unhandled exception";
            Exception e = filterContext.Exception;

            if(e is CustomValidationException)
            {
                var ex = e as CustomValidationException;
                message = ex.ToString();
            }
            
            filterContext.Result = Redirect($"/Home/Error?Message={message}");
        }
    }
}