using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;

namespace DALC
{
    public class FakeClassContext : IClassContext
    {
        public FakeClassContext()
        {
            this.Class = new FakeClassContextSet();
        }

        public int SaveChanges()
        {
            return 0;
        }

        public IDbSet<Class> Class
        {
            get;
            private set;
        }

        int IClassContext.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }

    public class FakeClassContextSet : FakeDbSet<Class>
    {
        public override Class Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.ClassID == (int)keyValues.Single());
        }
    }
}
