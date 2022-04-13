using Microsoft.AspNetCore.Mvc;
using NetBanking.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetBanking.Controllers
{
    public class CuentaController : Controller
    {
        public ActionResult Index()
        {
            //Saca la lista
            List<Cuentum> lst = new List<Cuentum>();


            //Uso del contexto entities. Conexion a la BD
            using (var db = new Models.DB.dbBankingContext())
            {

                //Obtiene el listado de los elementos
                lst = (from d in db.Cuenta

                       select new Cuentum

                       {

                           Id = d.Id,
                           NoCuenta = d.NoCuenta,
                           Balance = d.Balance

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
        public ActionResult Nuevo(Cuentum model)
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
                        var oTabla = new Cuentum();


                        oTabla.Id = model.Id;
                        oTabla.NoCuenta = model.NoCuenta;
                        oTabla.Balance = model.Balance;



                        //Guarda en la BD la informacion
                        db.Cuenta.Add(oTabla);
                        db.SaveChanges();

                    }

                    //Regresa a la vista donde esta el listado
                    return Redirect("~/Cuenta/Index");

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
