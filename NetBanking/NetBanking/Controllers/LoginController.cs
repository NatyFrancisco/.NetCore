using Microsoft.AspNetCore.Mvc;
using NetBanking.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetBanking.Controllers
{
    public class LoginController : Controller
    {
        public dbBankingContext _context;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Entrada(User model ,string Usuario, string Pass)
        {
            
                var usuario = _context.Users.Where(s => s.Usuario == Usuario && s.Passw == Pass);


                if (usuario.Where(s => s.Usuario == Usuario && s.Passw == Pass).Any())
                {
                    return Redirect("~/Cuenta/Nuevo");
                }
                

            return View(model);

        }
    }
}


