using Ninject;
using Ninject.Modules;
using Hepta.PraticalEvaluation.Application.Interfaces;
using Hepta.PraticalEvaluation.Application.Services;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories.Interfaces;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories;

namespace Hepta.PraticalEvaluation.Application.DI.Modules
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDiagnosticService>().To<DiagnosticService>();
        }
    }
}
