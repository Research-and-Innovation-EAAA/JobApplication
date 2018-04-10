using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JobApplication.Models;
using JobApplication.BLL;
using JobApplication.DAL;

namespace JobApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IJobDBRepository db;
        public HomeController(IJobDBRepository context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            //bare til test hurtigt.
            var all = db.AllRegions();
                return View(all);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
