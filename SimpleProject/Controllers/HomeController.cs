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
	//Строка 1.5 созданная в ветке master
	//Строка 1.6 созданная в ветке MyLocalBranch
	//Строка 1.7 созданная в ветке master
	//Строка 1.8 созданная в ветке MyLocalBranch
	//Строка 1.9 созданная в ветке master
	//Строка 1.10 созданная в ветке master
	//Строка 1.11 созданная в ветке MyLocalBranch
	//Строка 1.12 созданная в ветке master
	//Строка 1.13 созданная в ветке MyLocalBranch
	//Строка 1.14 созданная в ветке master
	//Строка 1.15 созданная в ветке LocalMasterBranch

//Строка 1.16 созданная в ветке master

//Строка 1.17 созданная в ветке NewTestBranch

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
