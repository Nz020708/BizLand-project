using BizLand.DAL;
using BizLand.Models;
using BizLand.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BizLand.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;

        }

        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Team = _db.Team.ToList(),
                Settings=_db.Settings.ToList()
            };
            return View(home);
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
