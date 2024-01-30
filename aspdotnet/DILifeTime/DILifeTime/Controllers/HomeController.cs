using DILifeTime.Models;
using DILifeTime.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DILifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ISingletonGuid singletonGuid; //createand assgn
        private readonly IScopednGuid scopednGuid;
        private readonly ITransientnGuid transientnGuid;
        private readonly GuidService guidService;

        public HomeController(ILogger<HomeController> logger, ISingletonGuid singletonGuid, IScopednGuid scopednGuid, ITransientnGuid transientnGuid, GuidService guidService )
        {
            _logger = logger;
            this.singletonGuid = singletonGuid;
            this.scopednGuid = scopednGuid;
            this.transientnGuid = transientnGuid;
            this.guidService = guidService;
        }

        public IActionResult Index()
        {

            ViewBag.SingletonValue= singletonGuid.Guid.ToString();
            ViewBag.TransientValue= transientnGuid.Guid.ToString();
            ViewBag.ScopedValue= scopednGuid.Guid.ToString();

            //servisin içnde guidler alınıyor
            ViewBag.SingletonScope =  guidService.SingletonGuid.Guid.ToString();
            ViewBag.TransientScope =  guidService.TransientnGuid.Guid.ToString();
            ViewBag.ScopedScope =  guidService.ScopednGuid.Guid.ToString();



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
