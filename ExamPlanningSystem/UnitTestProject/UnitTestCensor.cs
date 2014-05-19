using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using BE;
using Rhino.Mocks;

namespace UnitTestProject
{
    [TestClass]
    class UnitTestCensor
    {
        private BLLCensor mockBLLTeacher;
        private Censor mockCensor;
        private MockRepository mock;

        [TestInitialize]
        public void Initialize()
        {
            mock = new MockRepository();
            mockBLLTeacher = mock.StrictMock<BLLCensor>(false);
            mockCensor = mock.StrictMock<Censor>();
        }

        [TestCleanup]
        public void TearDown()
        {
            mockBLLTeacher = null;
            mockCensor = null;
        }

        [TestMethod]
        public void addCensorIDTest()
        {
            mockCensor.Id = 1;

            mockBLLTeacher.addCensor(mockCensor);

            Assert.AreEqual(1, mockBLLTeacher.getCensor(mockCensor.Id).Id);
        }

        [TestMethod]
        public void addFirstNameTest()
        {
            mockCensor.Id = 1;
            mockCensor.FirstName = "MyCensor";

            mockBLLTeacher.addCensor(mockCensor);

            Assert.AreEqual("MyCensor", mockBLLTeacher.getCensor(mockCensor.Id).FirstName);
        }

        [TestMethod]
        public void addLastNameTest()
        {
            mockCensor.Id = 1;
            mockCensor.LastName = "MyCensorLastName";

            mockBLLTeacher.addCensor(mockCensor);

            Assert.AreEqual("MyCensorLastName", mockBLLTeacher.getCensor(mockCensor.Id).LastName);
        }


        [TestMethod]
        public void addEmailTest()
        {
            mockCensor.Id = 1;
            mockCensor.Email = "test@test.dk";

            mockBLLTeacher.addCensor(mockCensor);

            Assert.AreEqual("test@test.dk", mockBLLTeacher.getCensor(mockCensor.Id).Email);
        }

        [TestMethod]
        public void addPhoneNumberTest()
        {
            mockCensor.Id = 1;
            mockCensor.PhoneNumber = "88 88 88 88";

            mockBLLTeacher.addCensor(mockCensor);

            Assert.AreEqual("88 88 88 88", mockBLLTeacher.getCensor(mockCensor.Id).PhoneNumber);
        }
    }
}
