using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data.Entity;

namespace DALC
{
    #region ClassContext
    public class FakeClassContext : IClassContext
    {
        public FakeClassContext()
        {
            this.Class = new FakeClassContextSet();
        }

        public IDbSet<Class> Class
        {
            get;
            private set;
        }
        public int SaveChanges()
        {
            return 0;
        }

    }

    public class FakeClassContextSet : FakeDbSet<Class>
    {
        public override Class Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.ClassID == (int)keyValues.Single());
        }
    }
    #endregion

    #region TeacherContext
    public class FakeTeacherContext : ITeacherContext
    {
        public FakeTeacherContext()
        {
            this.Teacher = new FakeTeacherContextSet();
        }

        public IDbSet<Teachers> Teacher
        {
            get;
            private set;
        }
        public int SaveChanges()
        {
            return 0;
        }

    }

    public class FakeTeacherContextSet : FakeDbSet<Teachers>
    {
        public override Teachers Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.Id == (int)keyValues.Single());
        }
    }
    #endregion

    #region CensorContext
    public class FakeCensorContext : ICensorContext
    {
        public FakeCensorContext()
        {
            this.Censor = new FakeCensorContextSet();
        }

        public IDbSet<Censor> Censor
        {
            get;
            private set;
        }
        public int SaveChanges()
        {
            return 0;
        }

    }

    public class FakeCensorContextSet : FakeDbSet<Censor>
    {
        public override Censor Find(params object[] keyValues)
        {
            return this.SingleOrDefault(d => d.Id == (int)keyValues.Single());
        }
    }
    #endregion
}
