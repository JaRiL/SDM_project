using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DALC;
using BE;

namespace BLL
{
    public class BLLClass
    {
        private ExamPlanningSystemSDMEntities entities;
        private bool _realDBAccess;

        public BLLClass(bool realDBAccess)
        {
            entities = new ExamPlanningSystemSDMEntities();
            _realDBAccess = realDBAccess;
        }

        public void addClass(Class _class)
        {
            entities.Class.Add(_class);
            if (_realDBAccess)
                SaveChangesToDB();
        }

        public Class getClass(int classID)
        {
            return entities.Class.Single(c => c.ClassID == classID);
        }

        private void SaveChangesToDB()
        {
            entities.SaveChanges();
        }
    }
}
