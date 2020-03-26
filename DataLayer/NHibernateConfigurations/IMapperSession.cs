
using Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.NHibernateConfigurations
{

    public interface IMapperSession
    {
        void BeginTransaction();
        System.Threading.Tasks.Task Commit();
        System.Threading.Tasks.Task Rollback();
        void CloseTransaction();
        System.Threading.Tasks.Task Save(List<Class1> entity);
        System.Threading.Tasks.Task Delete(Class1 entity);
        IQueryable<Class1> clas { get; }
    }
}

