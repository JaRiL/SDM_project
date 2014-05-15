using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    class UnitTestTeacher
    {

        [TestMethod]

        public void addBookingOfTeahcerTest()
        {

            m_beTeacherMock = new m_beTeacherMock();

            
            m_beTeacherMock.("Ole");
            m_Teacher.setTeacherID(1);
            m_teacher.setTeacherLastName("Eriksen");
            m_teacher.setTeacherEmail("OE@easv.dk");
            m_teacher.setTeacherPhone("35 48 69 22");
            m_bllTeacher.addNewTeacher(m_teacher);

            Assert.AreEqual("Ole", m_teacher.getTeacherName());
            Assert.AreEqual("Eriksen", m_teacher.getTeacherLastName());
            Assert.AreEqual("OE@easv.dk", m_teacher.getTeacherEmail());
            Assert.AreEqual("35 48 69 22", m_teacher.getTeacherPhone());
        
        }   
    }
}
