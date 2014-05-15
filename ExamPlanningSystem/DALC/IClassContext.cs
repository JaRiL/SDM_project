using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALC
{
    public interface IClassContext
    {
        IDbSet<Class> Class { get;}

        int SaveChanges();
    }
}
