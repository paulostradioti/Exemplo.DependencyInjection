using Exemplo.DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo.DependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientService transientService1;
        private readonly ITransientService transientService2;
        private readonly IScopedService scopedService1;
        private readonly IScopedService scopedService2;
        private readonly ISingletonService singletonService1;
        private readonly ISingletonService singletonService2;

        public HomeController(ITransientService transientService1,
                      ITransientService transientService2,
                      IScopedService scopedService1,
                      IScopedService scopedService2,
                      ISingletonService singletonService1,
                      ISingletonService singletonService2)
        {
            this.transientService1 = transientService1;
            this.transientService2 = transientService2;
            this.scopedService1 = scopedService1;
            this.scopedService2 = scopedService2;
            this.singletonService1 = singletonService1;
            this.singletonService2 = singletonService2;
        }

        public IActionResult Index()
        {

            ViewBag.message1 = "First Instance " + transientService1.GetID().ToString();
            ViewBag.message2 = "Second Instance " + transientService2.GetID().ToString();


            ViewBag.message3 = "First Instance " + scopedService1.GetID().ToString();
            ViewBag.message4 = "Second Instance " + scopedService2.GetID().ToString();

            ViewBag.message5 = "First Instance " + singletonService1.GetID().ToString();
            ViewBag.message6 = "Second Instance " + singletonService2.GetID().ToString();


            return View();
        }
    }
}
