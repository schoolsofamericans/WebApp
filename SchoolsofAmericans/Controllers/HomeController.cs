using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SchoolDBLib;
using SchoolModel;
using SchoolsofAmericans.Models;

namespace SchoolsofAmericans.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View("PreRegistration", new PreRegistration { EmailId="", SchoolName ="", UserName = "" });
        }


        [HttpPost]

        public IActionResult Index(PreRegistration preRegistration)
        {
           ViewBag.Result = InsertPreRegistratio(preRegistration);
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

        public void PreRegistrationAction(PreRegistration preRegistration)
        {
        }

        private static string InsertPreRegistratio(PreRegistration preRegistration)
        {
            PreRegistrationModel preRegistrationModel = new PreRegistrationModel
            {
                EmailId = preRegistration.EmailId,
                UserName = preRegistration.UserName,
                SchoolName = preRegistration.SchoolName
            };

            PreRegistrationCurd preRegistrationCurd = new PreRegistrationCurd();

            return  preRegistrationCurd.AddPreRegistration(preRegistrationModel);
        }
    }
}
