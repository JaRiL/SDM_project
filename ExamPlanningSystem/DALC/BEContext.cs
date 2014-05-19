using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC
{
    public class ClassContext : DbContext, IClassContext
    {
        public IDbSet<Class> Class { get; set; }
    }
    public class CensorContext : DbContext, ICensorContext
    {
        public IDbSet<Censor> Censor { get; set; }
    }

    public class TeacherContext : DbContext, ITeacherContext
    {
        public IDbSet<Teachers> Teacher { get; set; }
    }

}
