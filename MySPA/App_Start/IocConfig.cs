using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using MySPA.Data.Contracts;
using MySPA.Data.Helpers;
using Ninject;
using Ninject.Web.Mvc;


namespace MySPA.App_Start
{
    public class IocConfig
    {
        public static void RegisterIoc(HttpConfiguration config)
        {
            //var kernel = new StandardKernel();

            //kernel.Bind<IMySpaUow>().To<IMySpaUow>();

            //kernel.Bind<RepositoryFactories>().To<RepositoryFactories>().InSingletonScope();

            //kernel.Bind<IRepositoryProvider>().To<RepositoryProvider>();
            //Ninject.
            //config.DependencyResolver = new NinjectDependencyResolver
        }
    }
}