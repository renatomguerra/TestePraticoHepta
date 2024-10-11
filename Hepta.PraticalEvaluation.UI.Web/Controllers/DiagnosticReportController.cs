using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hepta.PraticalEvaluation.UI.Web.Controllers.Generic;
using Hepta.PraticalEvaluation.Domain;
using Hepta.PraticalEvaluation.Application.Extensions;
using Hepta.PraticalEvaluation.Application.Interfaces;
using Hepta.PraticalEvaluation.Application.Services;
using System.Web.Services.Description;

namespace Hepta.PraticalEvaluation.UI.Web.Controllers
{
    public class DiagnosticReportController : CrudController<int, BinaryNumber>
    {
        private IDiagnosticService _service;
        public DiagnosticReportController(IDiagnosticService service): base(service)
        {
            _service = service;
        }
        // GET: DiagnosticReport
        public override ActionResult Index()
        {
            var list = _service.GetAll();

            ViewData["TaxaGama"] = _service.CalcularTaxaGama(list).ToString().FromBinaryNumberToDecimal();
            ViewData["TaxaEpsilon"] = _service.CalcularTaxaEpsilon(list).ToString().FromBinaryNumberToDecimal();
            ViewData["ConsumoEnergia"] = _service.CalcularConsumoEnergia(list);

            return View(list);
        }
    }
}