using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Bosch.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumShouldBeTrue()
        {
            /// AAA 
            /// Arrange: Eylemleri hazırlamak.
            // DeleteCategoryRequest request = new.....
            int number1 = 1;
            int number2 = 2;

            int expected = 3;

            /// Action: Eylemleri gerçekleştirdiğimiz kısım.
            // _categoryManager.Delete();
            int actual = number1 + number2;


            /// Assert: Testin sonucunun bağlı olduğu koşul/koşullar
            Assert.IsTrue(actual == expected);
        }
    }
}
