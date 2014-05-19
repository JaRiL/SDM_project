using DALC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BLL
{
    public class BLLCensor
    {
        private ExamPlanningSystemSDMEntities1 entities;
        private ICensorContext fakeContext;
        private bool _realDBAccess;

        public BLLCensor(bool realDBAccess = true)
        {
            entities = new ExamPlanningSystemSDMEntities1();
            fakeContext = new FakeCensorContext();
            _realDBAccess = realDBAccess;
        }

        public void addCensor(Censor _censor)
        {
            if (_realDBAccess)
                addCensorReal(_censor);
            else
                addCensorFake(_censor);
        }

        public Censor getCensor(int censorID)
        {
            if (_realDBAccess)
                return getCensorReal(censorID);
            else
                return getCensorFake(censorID);
        }



        private void addCensorReal(Censor _censor)
        {
            entities.Censor.Add(_censor);
            entities.SaveChanges();
        }

        private void addCensorFake(Censor _censor)
        {
            fakeContext.Censor.Add(_censor);
            fakeContext.SaveChanges();
        }

        private Censor getCensorReal(int censorID)
        {
            return entities.Censor.Single(c => c.Id == censorID);
        }

        private Censor getCensorFake(int censorID)
        {
            return fakeContext.Censor.Single(c => c.Id == censorID);
        }
    }
}
