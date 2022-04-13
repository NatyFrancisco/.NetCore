using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMigracion0._1.Models;
using WebAppMigracion0._1.Models.BD;
using Microsoft.EntityFrameworkCore;

namespace WebAppMigracion0._1.Controllers
{
    public class PersonaController : Controller
    {
        public IActionResult Index()
        {
            //Saca la lista
            List<ListTablaPersona> lst = new List<ListTablaPersona>();


            //Uso del contexto entities. Conexion a la BD
            using (var db = new Models.BD.dbMigracionContext())
            {

                //Obtiene el listado de los elementos
                lst = (from d in db.Personas

                       select new ListTablaPersona

                       {
                           Id = d.Id,
                           Nombre = d.Nombre,
                           Apellido = d.Apellido,
                           FechaNacimiento = d.FechaNacimiento,
                           Pasaporte = d.Pasaporte,
                           Direccion = d.Direccion,
                           Sexo = d.Sexo

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
        public ActionResult Nuevo(ListTablaPersona model)
        {
            //El try regresa el error si existe
            try
            {

                //Valida  que son requeridos y ahi empieza la programacion
                if (ModelState.IsValid)
                {


                    using (var db = new Models.BD.dbMigracionContext())
                    {

                        //Creacion del objeto tabla(o)
                        var oTabla = new ListTablaPersona();


                        oTabla.Id = model.Id;
                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido = model.Apellido;
                        oTabla.FechaNacimiento = model.FechaNacimiento;
                        oTabla.Pasaporte = model.Pasaporte;
                        oTabla.Direccion = model.Direccion;
                        oTabla.Sexo = model.Sexo;


                        //Guarda en la BD la informacion
                        db.Personas.Add(oTabla);
                        db.SaveChanges();

                    }

                    //Regresa a la vista donde esta el listado
                    return Redirect("~/Persona/");

                }
                return View(model);

            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }




        //Metodo editar

        //int ID recibe al ID
        public ActionResult Editar(int Id)

        {
            //Se manda el modelo a partir de la BD
            ListTablaPersona model = new ListTablaPersona();

            using (var db = new Models.BD.dbMigracionContext())

            {
                //Se obtienen los elementos de ID
                var oTabla = db.Personas.Find(Id);

                //Llena los modelos ID, NOMBRE, CORREO Y FECHA

                //Se manda el ID al modelo para saber cual se va a editar


                model.Id = oTabla.Id;
                model.Nombre = oTabla.Nombre;
                model.Apellido = oTabla.Apellido;
                model.FechaNacimiento = oTabla.FechaNacimiento;
                model.Pasaporte = oTabla.Pasaporte;
                model.Direccion = oTabla.Direccion;
                model.Sexo = oTabla.Sexo;



            }

            return View(model);

        }


        //Metodo editar con cod. programacion
        [HttpPost]
        public ActionResult Editar(ListTablaPersona model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (var db = new Models.BD.dbMigracionContext())
                    {
                        var oTabla = db.Personas.Find(model.Id);

                        oTabla.Nombre = model.Nombre;
                        oTabla.Apellido = model.Apellido;
                        oTabla.FechaNacimiento = model.FechaNacimiento;
                        oTabla.Pasaporte = model.Pasaporte;
                        oTabla.Direccion = model.Direccion;
                        oTabla.Sexo = model.Sexo;



                        

                        db.SaveChanges();
                    }
                    return Redirect("~/Persona/");
                }
                return View(model);
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



        //Solicitud para eliminar
        [HttpGet]

        public ActionResult Eliminar(int Id)

        {

            using (var db = new Models.BD.dbMigracionContext())
            {

                var oTabla = db.Personas.Find(Id);

                //Elimina la entidad (tabla)
                db.Personas.Remove(oTabla);
                //Guarda
                db.SaveChanges();
            }

            //Redirect al listado
            return Redirect("~/Persona/");


        }
    }
}
