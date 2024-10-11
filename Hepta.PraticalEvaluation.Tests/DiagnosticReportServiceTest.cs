using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Hepta.PraticalEvaluation.Application.Interfaces;
using Hepta.PraticalEvaluation.Application.Services;
using Hepta.PraticalEvaluation.Application.DI.Configuration;
using Hepta.PraticalEvaluation.Application.DI.Modules;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories;
using Hepta.PraticalEvaluation.Infrastructure.Data.Repositories.Interfaces;
using Hepta.PraticalEvaluation.Domain;
using Ninject;
using Hepta.PraticalEvaluation.Application.Extensions;

namespace Hepta.PraticalEvaluation.Tests
{
    [TestClass]
    public class DiagnosticReportServiceTest
    {
        [TestMethod]
        public void CalcularConsumoEnergia()
        {
            Ioc ioc = new Ioc();
            IDiagnosticService service = ioc.Kernel.Get<IDiagnosticService>();
            var list = service.GetAll();

            var result = service.CalcularConsumoEnergia(list);
            Assert.AreEqual(198, result);
        }
    }
}
