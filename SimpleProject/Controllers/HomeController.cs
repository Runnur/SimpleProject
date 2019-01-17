using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using System.Web.Mvc.Html;
using SimpleProject.Models;
using Ninject;
using MySql.Data.MySqlClient;

namespace SimpleProject.Controllers
{
    public class HomeController : Controller
    {

        Product p1 = new Product();

        private Product[] products = {
            new Product {Name = "Kayak", Category = "Watersports", Price = 275M},
            new Product {Name = "Lifejacket", Category = "Watersports", Price = 48.95M},
            new Product {Name = "Soccer ball", Category = "Soccer", Price = 17.95M},
            new Product {Name = "Corner flag", Category = "Soccer", Price = 34.95M},
        };

        private IValueCalculator calc;
        public HomeController(IValueCalculator calcParam)
        {
            calc = calcParam;
        }
        public HomeController()
        {

        }
        //Строк 1.3 созданная в ветке MyLocalBranch
        //Строк 1.4 созданная в ветке MyLocalBranch

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

        //Строка 1.17 созданная в ветке LocalMasterBranch
        //Строка

        private MobileContext db = new MobileContext();

    public ActionResult Index()
    {

        var mvcName = typeof(Controller).Assembly.GetName();
        var isMono = Type.GetType("Mono.Runtime") != null;

        ViewData["Version"] = mvcName.Version.Major + "." + mvcName.Version.Minor;
        ViewData["Runtime"] = isMono ? "Mono" : ".NET";

        int hour = DateTime.Now.Hour;
        ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";

        IKernel ninjectKernel = new StandardKernel();
        ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();
        //IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();
        ShoppingCart cart = new ShoppingCart(calc) { Products = products };
        decimal totalValue = cart.CalculateProductTotal();
        ViewBag.TotalValue = totalValue.ToString();

            string connectionString = "";
            MySqlConnection cnn = new MySqlConnection(connectionString);
            try
            {
                cnn.Open();
                ViewBag.Connect = "Connection Open !";
            }
            catch (Exception ex)
            {
                ViewBag.Connect = "Can not open connection!";
                ViewBag.Connect = ex.Message; //shows what error actually occurs
            }
            finally
            {
                cnn.Close();
            }

            ViewBag.Phones = db.Phones.ToList();

            return View(totalValue);
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
