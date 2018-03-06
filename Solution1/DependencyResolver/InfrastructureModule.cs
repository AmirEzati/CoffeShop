using Ninject.Modules;
using RailWayCoffee.Infrastructure.Logging;

namespace NinjectDependencyResolver
{
  public  class InfrastructureModule:NinjectModule
    {
        public override void Load()
        {
            Bind<ILogger>().To<NLogLogger>();
        }
    }
}
