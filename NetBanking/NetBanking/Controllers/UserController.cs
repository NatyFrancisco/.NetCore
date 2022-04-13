using Microsoft.AspNetCore.Mvc;
using NetBanking.Models.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetBanking.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            // Saca la lista
            List<User> lst = new List<User>();


            //Uso del contexto entities. Conexion a la BD
            using (var db = new Models.DB.dbBankingContext())
            {

                //Obtiene el listado de los elementos
                lst = (from d in db.Users

                       select new User

                       {

                           Id = d.Id,
                           Cedula = d.Cedula,
                           Nombre = d.Nombre,
                           Apellido = d.Apellido,
                           Usuario = d.Usuario,
                           Passw = d.Passw



                       }).ToList();
            }
            return View(lst);

        }

        public ActionResult Nuevo()
        {

            return View();

        }


        //Metodo nuevo que ejecuta el boton guardar
        [HttpPost]
        public ActionResult Nuevo(User model)
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
                        var oTabla = new User();


                        oTabla.Id = model.Id;
                        oTabla.Cedula = model.Cedula;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido = model.Apellido;
                        oTabla.Usuario = model.Usuario;
                        oTabla.Passw = model.Passw;



                        //Guarda en la BD la informacion
                        db.Users.Add(oTabla);
                        db.SaveChanges();

                    }

                    //Regresa a la vista donde esta el listado
                    return Redirect("~/Cuenta/Nuevo");

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
