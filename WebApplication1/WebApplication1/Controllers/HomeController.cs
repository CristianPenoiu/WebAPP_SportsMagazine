using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "User,Admin")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public ActionResult Home()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult Map()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult Mens()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult Pants()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult PrivacyAgreement()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult ProductPage()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult Shirts()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult Shoes()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult UserPage()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult Women()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult Cart()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult AboutUs()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        public ActionResult Recenzii()
        {
            return View(); // Specificăm numele fișierului .cshtml pentru pagina de acasă
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }

}
