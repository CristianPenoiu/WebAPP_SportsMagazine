using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "User,Admin")]
    public class RecenziesController : Controller
    {
        private readonly IRecenzii _recenzie;

        public RecenziesController(IRecenzii recenzie)
        {
            _recenzie = recenzie;
        }

        // GET: ContactForms
        [Route("/Recenzie")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("/Home/Recenzii")]
        public IActionResult CreateAboutUs()
        {
            var allContactForms = _recenzie.GetAllRecenzii();
            return View("Index", allContactForms);
        }

        [HttpGet]
        [Route("/recenzii")]
        public IActionResult GetAllContactForms()
        {
            var allContactForms = _recenzie.GetAllRecenzii();
            return Json(allContactForms);

        }

        [HttpPost]
        [Route("/recenzii/create")]

        public IActionResult CreateContactForm(Recenzie recenzie)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _recenzie.CreateRecenzie(recenzie);

            return Redirect("/Home/Recenzii");
        }

    }
}
