using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using BLL;
using BE;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestClass
    {
        private BLLClass mockBLLClass;
        private Class mockClass;

        [TestInitialize]
        public void Initialize()
        {
            mockBLLClass = MockRepository.GenerateMock<BLLClass>(true);
            mockClass = MockRepository.GenerateMock<Class>();

        }

        [TestCleanup]
        public void TearDown()
        {
            mockBLLClass = null;
            mockClass = null;
        }

        [TestMethod]
        public void addBookingOfClassTest()
        {
            mockClass.ClassName = "CS2011";
            mockClass.ClassID = 1;

            mockBLLClass.addClass(mockClass);

            Assert.AreEqual(1, mockBLLClass.getClass(mockClass.ClassID));
            Assert.AreEqual("CS2011", mockBLLClass.getClass(mockClass.ClassID));
        }
    }
}
