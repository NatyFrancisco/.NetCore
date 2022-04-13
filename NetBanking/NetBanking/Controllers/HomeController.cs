using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetBanking.Models;
using NetBanking.Models.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;



namespace NetBanking.Controllers
    
{
    public class HomeController : Controller
    {

        public dbBankingContext _context;

        private readonly ILogger<HomeController> _logger;

        

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(User model, string Usuario, string Pass)
        {
            var usuario = _context.Users.Where(s => s.Usuario == Usuario && s.Passw == Pass);


            if (usuario.Where(s => s.Usuario == Usuario && s.Passw == Pass).Any())
            {
                return Redirect("~/Cuenta/Nuevo");
            }
            else
            {
                ViewBag.error("Datos invalidos");
            }
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
    }
}
