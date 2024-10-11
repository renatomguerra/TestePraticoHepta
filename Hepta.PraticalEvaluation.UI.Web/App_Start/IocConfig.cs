using System.Web.Mvc;
using Hepta.PraticalEvaluation.Application.DI.Configuration;

namespace Hepta.PraticalEvaluation.UI.Web.App_Start
{
    public class IocConfig
    {
        public static void RegisterDependencies()
        {
            DependencyResolver.SetResolver(new NinjectResolver(new Ioc().Kernel));
        }
    }

}