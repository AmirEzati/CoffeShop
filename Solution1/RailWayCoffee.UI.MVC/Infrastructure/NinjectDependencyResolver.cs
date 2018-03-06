using NinjectDependencyResolver;
using Ninject;
using Ninject.Syntax;
using RailWayCoffee.Services.Concretes;
using RailWayCoffee.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Ninject.Modules;

namespace RailWayCoffee.UI.MVC.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;
        public NinjectDependencyResolver()
        {
            kernel = new StandardKernel();
            AddBindings();
        }
        public IKernel Kernel
        {
            get
            {
                return kernel;
            }
        }
        public IBindingToSyntax<T> Bind<T>() {
            return kernel.Bind<T>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            //put additional bindings here
            // Bind<>().To<>();
            var modules = new List<INinjectModule>() {
               new ServiceModule(),
               new RepositoryModule(),
           };
            kernel.Load(modules);
        }
    }
}