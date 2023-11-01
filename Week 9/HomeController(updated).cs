using Microsoft.AspNetCore.Mvc;
using NaomiRetroCloset.Models;
using System.Diagnostics;
using System.Xml.Linq;
using Newtonsoft.Json;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Newtonsoft.Json.Linq;
using NuGet.Configuration;

namespace NaomiRetroCloset.Controllers
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
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult FAQ()
        {
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

        /*
        public ViewResult Tools(MySession model)
        {
            /*string FirstName = HttpContext.Session.GetString("Naomi");
            HttpContext.Session.SetString("Naomi", FirstName);

            string LastName = HttpContext.Session.GetString("Perryman");
            HttpContext.Session.SetString("Perryman", LastName);

            string Course = HttpContext.Session.GetString("IT2030");
            HttpContext.Session.SetString("IT2030", Course);*/

        //int FavNum = HttpContext.Session.GetInt32("724");
        //HttpContext.Session.SetInt32("724", FavNum);
        // return View(model);
        //  }


        /*public IActionResult Tools(MySession model)
        {
            return View();
        }*/

        //Updated Tools action methods
        [HttpGet]
        public IActionResult Tools(MySession s)
        {
            HttpContext.Session.GetString("FirstName");
            HttpContext.Session.GetString("LastName");
            HttpContext.Session.GetString("Course");
            HttpContext.Session.GetInt32("FavNum");
            return View();
        }

        [HttpPost]
        public IActionResult Tools()
        {
            MySession model = new MySession()
            { FirstName = "Naomi", LastName = "Perryman", Course = "IT2030", FavNum = 724 };
            
            HttpContext.Session.SetString("FirstName", model.FirstName );
            HttpContext.Session.SetString("LastName", model.LastName);
            HttpContext.Session.SetString("Course", model.Course);
            HttpContext.Session.SetInt32("FavNum", model.FavNum);

            return View(model);
        }  
    }
}

