[assembly: WebActivator.PostApplicationStartMethod(typeof(WebAPI.Boilerplate.DependencyResolver.App_Start.SimpleInjectorWebApiInitializer), "Initialize")]

namespace WebAPI.Boilerplate.DependencyResolver.App_Start
{
    using System.Web.Http;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using WebAPI.Boilerplate.BusinessService.Interface;
    using WebAPI.Boilerplate.BusinessService.Service;
    using WebAPI.Boilerplate.DataService;
    using WebAPI.Boilerplate.DataService.Interface;
    using WebAPI.Boilerplate.Logger;
    
    public static class SimpleInjectorWebApiInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            // Did you know the container can diagnose your configuration? Go to: https://bit.ly/YE8OJj.
            var container = new Container();
            
            InitializeContainer(container);

            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);
       
            container.Verify();
            
            GlobalConfiguration.Configuration.DependencyResolver =
                new SimpleInjectorWebApiDependencyResolver(container);
        }
     
        private static void InitializeContainer(Container container)
        {
             container.RegisterWebApiRequest<IEmployeeService, EmployeeService>();
             container.RegisterWebApiRequest<IEmployeeRespository, EmployeeRepository>();
             container.RegisterWebApiRequest<BaseLogger, CoreLogger>();
        }
    }
}