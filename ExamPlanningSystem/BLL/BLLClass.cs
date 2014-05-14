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

        public void addClass(BEClass _class)
        {
            entities.Class.Add(_class);
        }

        public BEClass getClass(int classID)
        {
            return entities.Class.Single(c => c.ClassID == classID);
        }
    }
}
