using Microsoft.AspNetCore.Mvc;
using NetBanking.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetBanking.Controllers
{
    public class TransferenciaController : Controller
    {


        public IActionResult Index()
        {

            //Saca la lista
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
                           TipoCuenta = d.TipoCuenta,
                           Banco = d.Banco,
                           NoCuenta = d.NoCuenta,
                           Monto = d.Monto

                       }).ToList();
            }


            return View(lst);
        }

        //Metodo nuevo
        public ActionResult Nuevo()
        {

            return View();

        }


        //Metodo nuevo que ejecuta el boton guardar
        [HttpPost]
        public ActionResult Nuevo(Transferencium model)
        {
            //El try regresa el error si existe
            try
            {

                //Valida  que son requeridos y ahi empieza la programacion
                if (ModelState.IsValid)
                {


                    using (var db = new Models.DB.dbBankingContext())
                    {

                        //Creacion del objeto tabla(o)
                        var oTabla = new Transferencium();


                        oTabla.Id = model.Id;
                        oTabla.Fecha = model.Fecha;
                        oTabla.TipoCuenta = model.TipoCuenta;
                        oTabla.Banco = model.Banco;
                        oTabla.NoCuenta = model.NoCuenta;
                        oTabla.Monto = model.Monto;



                        //Guarda en la BD la informacion
                        db.Transferencia.Add(oTabla);
                        db.SaveChanges();

                    }

                    //Regresa a la vista donde esta el listado
                    return Redirect("~/Transferencia/Nuevo");

                }
                return View(model);

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}