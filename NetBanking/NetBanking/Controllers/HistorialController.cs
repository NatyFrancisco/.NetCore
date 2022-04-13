using Microsoft.AspNetCore.Mvc;
using NetBanking.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetBanking.Controllers
{
    public class HistorialController : Controller
    {
        public ActionResult Index()
        {
            // Saca la lista
            List<Transferencium> lst = new List<Transferencium>();


            //Uso del contexto entities. Conexion a la BD
            using (var db = new Models.DB.dbBankingContext())
            {

                //Obtiene el listado de los elementos
                lst = (from d in db.Transferencia

                       select new Transferencium

                       {

                           Id = d.Id,
                           Fecha = d.Fecha,
                           NoCuenta = d.NoCuenta,
                           Monto = d.Monto


                       }).ToList();
            }
            return View(lst);

        }
    }
}
