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
        private MockRepository mock;

        [TestInitialize]
        public void Initialize()
        {
            mock = new MockRepository();
            mockBLLClass = mock.StrictMock<BLLClass>(false);
            mockClass = mock.StrictMock<Class>();
        }

        [TestCleanup]
        public void TearDown()
        {
            mockBLLClass = null;
            mockClass = null;
        }

        [TestMethod]
        public void addClassIDTest()
        {
            mockClass.ClassID = 1;

            mockBLLClass.addClass(mockClass);
            
            Assert.AreEqual(1, mockBLLClass.getClass(mockClass.ClassID).ClassID);
        }

        [TestMethod]
        public void addClassNameTest()
        {
            mockClass.ClassName = "CS2011";

            mockBLLClass.addClass(mockClass);

            Assert.AreEqual("CS2011", mockBLLClass.getClass(mockClass.ClassID).ClassName);
        }
    }
}
