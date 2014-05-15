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
            mockBLLClass = MockRepository.GenerateMock<BLLClass>(new BLLClass(false));
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

        }
    }
}
