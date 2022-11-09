using AutoMapper;
using Business.BusinessRules;
using Business.Concretes;
using Business.Profiles;
using Business.Request;
using Business.Response;
using Core.CrossCuttingConcerns.Logging;
using Core.Exceptions;
using DataAccess.Abstracts;
using DataAccess.Concretes.Adonet;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Bosch.UnitTests
{
    [TestClass]
    public class CategoryTests
    {
        private CategoryManager _categoryManager;
        private Mock<ICategoryDal> _categoryDalMock;
        private IMapper _mapper;

        [TestInitialize]
        public void TestSetup()
        {
            _categoryDalMock = new Mock<ICategoryDal>();


            AutoMapperProfiles autoMapperProfiles = new AutoMapperProfiles();
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(autoMapperProfiles);
            });
            _mapper = new Mapper(mapperConfig);


            CategoryBusinessRules categoryBusinessRules = new CategoryBusinessRules(_categoryDalMock.Object);
            LoggerServiceBase[] loggers = new LoggerServiceBase[0];

            _categoryManager =
                new CategoryManager(_categoryDalMock.Object, categoryBusinessRules, _mapper, loggers);
        }
        [TestCleanup]
        public void TestCleanup()
        {
        }

        [TestMethod]
        public void CategoryWithNameTwoLettersShouldThrowException()
        {
            #region Arrange
            CreateCategoryRequest request = new CreateCategoryRequest()
            {
                Name = "as",
                Description = "A1"
            };
            #endregion

            #region Action
            Action action = () => _categoryManager.Add(request);
            #endregion

            #region Assert
            Assert.ThrowsException<CustomValidationException>(action);
            #endregion
        }


        [TestMethod]
        public void CategoryWithSameNameShouldThrowException()
        {
            CreateCategoryRequest request = new CreateCategoryRequest() { Name = "Kategori 1", Description = "A Kategori 1 desc" };


            // Mock methodunun setup

            List<Category> categories = new List<Category>();
            categories.Add(new Category() { CategoryName = "Kategori 1", Description = "A Kategori 1 desc" });

            _categoryDalMock
                .Setup(c=>c.GetAll(It.IsAny<Expression<Func<Category, bool>>>()))
                .Returns(categories);

            Action action = () => _categoryManager.Add(request);

            Assert.ThrowsException<BusinessException>(action,"Business Exception fırlatılmadı.");
        }

        [TestMethod]
        public void CategoriesShouldBeListedCorrectly()
        {
            var categoryList = new List<Category>()
            {
                new Category(){ CategoryID=1,CategoryName="Kategori 1",Description="1"},
                new Category(){ CategoryID=2,CategoryName="Kategori 2",Description="2"},
                new Category(){ CategoryID=3,CategoryName="Kategori 3",Description="3"},
                new Category(){ CategoryID=4,CategoryName="Kategori 4",Description="4"},
                new Category(){ CategoryID=5,CategoryName="Kategori 5",Description="5"},
            };

            _categoryDalMock.Setup(c => c.GetAll(It.IsAny<Expression<Func<Category, bool>>>()))
                .Returns(categoryList);

            var expectedList = new List<ListCategoryResponse>()
            {
                new ListCategoryResponse(){Name="Kategori 1",Id=1,Description="1"},
                new ListCategoryResponse(){Name="Kategori 2",Id=2,Description="2"},
                new ListCategoryResponse(){Name="Kategori 3",Id=3,Description="3"},
                new ListCategoryResponse(){Name="Kategori 4",Id=4,Description="4"},
                new ListCategoryResponse(){Name="Kategori 5",Id=5,Description="5"},
            };

            var actualList = _categoryManager.GetAll();

            var expectedJson = JsonConvert.SerializeObject(expectedList);
            var actualJson = JsonConvert.SerializeObject(actualList);
            Assert.AreEqual(expectedJson, actualJson);
        }
    }
}
