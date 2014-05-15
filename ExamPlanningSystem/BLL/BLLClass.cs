﻿using System;
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
        private IClassContext fakeContext;
        private bool _realDBAccess;

        public BLLClass(bool realDBAccess = true)
        {
            entities = new ExamPlanningSystemSDMEntities();
            fakeContext = new FakeClassContext();
            _realDBAccess = realDBAccess;
        }

        public void addClass(Class _class)
        {
            if (_realDBAccess)
                addClassReal(_class);
            else
                addClassFake(_class);
        }

        public Class getClass(int classID)
        {
            if (_realDBAccess)
                return getClassReal(classID);
            else
                return getClassFake(classID);
        }



        public void addClassReal(Class _class)
        {
            entities.Class.Add(_class);
            entities.SaveChanges();
        }

        public void addClassFake(Class _class)
        {
            fakeContext.Class.Add(_class);
            fakeContext.SaveChanges();
        }

        public Class getClassReal(int classID)
        {
            return entities.Class.Single(c => c.ClassID == classID);
        }

        public Class getClassFake(int classID)
        {
            return fakeContext.Class.Single(c => c.ClassID == classID);
        }

    }
}
