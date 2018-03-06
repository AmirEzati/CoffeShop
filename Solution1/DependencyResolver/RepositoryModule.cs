using Ninject.Modules;
using RailWayCoffee.DAL;
using RailWayCoffee.DAL.EntiryFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectDependencyResolver
{
   public class RepositoryModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<SqlUnitOfWork>()
             .WithConstructorArgument("databaseContext", new RailWayCoffee.Models.DatabaseContext());
        }
    }
}
