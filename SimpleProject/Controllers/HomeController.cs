using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using SimpleProject.Models;

namespace SimpleProject.Controllers
{
    public class HomeController : Controller
    {
	//Строка созданная в ветке NewTestMaster

	//Строка созданная в ветке master

	//Новая строка созданная в ветке NewTestMaster


	//Новая строка созданная в ветке master

	//Строка 1.1 созданная в ветке master

	//Строка 1.2 созданная в ветке master

	//Строк 1.3 созданная в ветке MyLocalBrunch
	//Строк 1.4 созданная в ветке MyLocalBrunch

	//Строка 1.5 созданная в ветке master
	//Строка 1.6 созданная в ветке MyLocalBrunch
	//Строка 1.7 созданная в ветке master


        public ActionResult Index()
        {
            var mvcName = typeof(Controller).Assembly.GetName();
            var isMono = Type.GetType("Mono.Runtime") != null;

            ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
            ViewData["Runtime"] = isMono ? "Mono" : ".NET";

            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";


            return View();
        }
        [HttpGet]
        public  ViewResult RsvpForm()
        {
            return View();
        }
	
	[HttpGet]
	public string TestMethod()
	{
		return @"Строка созданная в мастере";
	}

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }
        }
    }
}
