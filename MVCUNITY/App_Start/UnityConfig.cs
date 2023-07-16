using MVCUNITY.Models.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVCUNITY
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IProductRep, ProductRepository>();

           // container.RegisterType<IOrderRep, OrderRepository>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}