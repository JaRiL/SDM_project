using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALC;

namespace BLL
{
    public class BLLClass
    {
        private ExamPlanningSystemSDMEntities entities;

        public BLLClass()
        {
            entities = new ExamPlanningSystemSDMEntities();
        }

        public void addClass(Class _class)
        {
            entities.Class.Add(_class);
        }

        public Class getClass(int classID)
        {
            return ConvertDALCtoBLL(entities.Class.Single(c => c.ClassID == classID));
        }

        private BLL.Class ConvertDALCtoBLL(DALC.Class oldClass) 
        {
            return new BLL.Class
            {
                ClassID = oldClass.ClassID,
                ClassName = oldClass.ClassName,
                RoomID = oldClass.RoomID
            };
        }
    }
}
