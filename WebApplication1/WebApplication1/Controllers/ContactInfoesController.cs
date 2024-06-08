using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers
{
    [Authorize(Roles = "User,Admin")]
    public class ContactInfoesController : Controller
    {
        private readonly IContactInfo _contactInfoService;

        public ContactInfoesController(IContactInfo contactInfoService)
        {
            _contactInfoService = contactInfoService;
        }


        // GET: ContactForms
        [Route("/Contact")]
        public IActionResult Create()
        {
            return View();
        }

        [Route("/Home/AboutUs")]
        public IActionResult CreateAboutUs()
        {
            var allContactForms = _contactInfoService.GetAllContacts();
            return View("Index", allContactForms);
        }


        // POST: ContactInfoes/Create
        [HttpGet]
        [Route("/contacts")]
        public IActionResult GetAllContactForms()
        {
            var allContactForms = _contactInfoService.GetAllContacts();
            return Json(allContactForms);

        }

        [HttpPost]
        [Route("/contacts/create")]

        public IActionResult CreateContactForm(ContactInfo contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _contactInfoService.CreateContact(contact);

            return Redirect("/Home/AboutUs");
        }
        
        // Other action methods (Edit, Delete, Details) follow the same pattern...
    }
}
