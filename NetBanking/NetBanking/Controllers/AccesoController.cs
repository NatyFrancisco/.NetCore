using Microsoft.AspNetCore.Mvc;
using NetBanking.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetBanking.Models;

namespace NetBanking.Controllers
{
    public class AccesoController : Controller
    {

        public dbBankingContext _context;

        public AccesoController(dbBankingContext master)
        {
            this._context = master;
        }


        [HttpPost]
        public IActionResult GetUsuarios(string Usuario, string Pass)
        {
            var usuario = _context.Users.Where(s => s.Usuario == Usuario && s.Passw == Pass);

            if (usuario.Any())
            {
                if (usuario.Where(s=>s.Usuario == Usuario && s.Passw == Pass).Any())
                {
                    return Redirect("~/Cuenta/Nuevo");
                }
                else
                {
                    return Json(new { status = true, message = "Contrasena incorrecta" });
                }
            }
            else
            {
                return Json(new { status = true, message = "Usuario inconrrecto" });
            }
        }
    }
}
