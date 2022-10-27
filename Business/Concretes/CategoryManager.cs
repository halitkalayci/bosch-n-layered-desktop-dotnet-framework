using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using AutoMapper;
using Business.Abstracts;
using Business.BusinessRules;
using Business.Request;
using Business.Response;
using Business.ValidationResolvers.FluentValidation.Category;
using Core.CrossCuttingConcerns.Logging;
using Core.Utilities.Logging;
using Core.Validation;
using DataAccess.Abstracts;
using Entities.Concretes;
using FluentValidation;
using Newtonsoft.Json;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        private LoggerServiceBase[] _loggers;
        private ICategoryDal _categoryDal;
        private CategoryBusinessRules _businessRules;
        private IMapper _mapper;
        public CategoryManager(ICategoryDal category, CategoryBusinessRules businessRules, IMapper mapper, LoggerServiceBase[] loggers)
        {
            _categoryDal = category;
            _businessRules = businessRules;
            _mapper = mapper;
            _loggers = loggers;
        }

        public void Add(CreateCategoryRequest request)
        {

            using(AuthService.AuthServiceSoapClient client = new AuthService.AuthServiceSoapClient())
            {
                var response = client.SayHi(new AuthService.AuthUser() 
                { Username = "halit", Password = "123" }, 
                "Halit");
            }
       
            /// LOGLAMA
            string logAsJson = LogDetailHelper
                .GetLogDetails(nameof(Add), typeof(CreateCategoryRequest).GetProperties(), request);
            foreach (var logger in _loggers)
            {
                logger.Info(logAsJson);
            }
            ///

            /// Validasyon
            ValidationHelper<CreateCategoryRequest>
                .Validate(typeof(CreateCategoryRequestValidator),request);
            ///

            /// MAPLEME
            Category category = _mapper.Map<Category>(request);
            ///

            /// DATABASE ACTION
            _categoryDal.Add(category); 
            ///
        }

        public void Delete(DeleteCategoryRequest request)
        {
            string logAsJson = LogDetailHelper
            .GetLogDetails(System.Reflection.MethodBase.GetCurrentMethod().Name, typeof(DeleteCategoryRequest).GetProperties(), request);
            foreach (var logger in _loggers)
            {
                logger.Info(logAsJson);
            }

            _businessRules.CheckIfCategoryNotExist(request.Id);
            Category category = _mapper.Map<Category>(request); // yeni bir instance üretir, ID olmak zorunda!
            //Category category = _categoryDal.GetById(request.Id); // databasede obje instance'i
            _categoryDal.Delete(category);
        }

        public List<ListCategoryResponse> GetAll()
        {
            List<Category> categories = _categoryDal.GetAll();
            List<ListCategoryResponse> list = _mapper.Map<List<ListCategoryResponse>>(categories);
            return list;
        }

        public GetCategoryResponse GetById(int id)
        {
            var result = _categoryDal.Get(i=>i.CategoryID == id);
            _businessRules.CheckIfCategoryNotExist(result);
            var response = _mapper.Map<GetCategoryResponse>(result);
            return response;
        }

        public void Update(UpdateCategoryRequest request)
        {
            _businessRules.CheckIfCategoryNotExist(request.Id);
            Category entity = _mapper.Map<Category>(request);
            _categoryDal.Update(entity);
        }
    }
}
