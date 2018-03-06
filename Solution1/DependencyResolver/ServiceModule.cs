using Ninject.Modules;
using RailWayCoffee.Services.Interfaces;
using RailWayCoffee.Services.Concretes;

namespace NinjectDependencyResolver
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IOrderService>()
                .To<OrderService>();
        }
    }
}
