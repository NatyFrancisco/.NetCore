using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppMigracion0._1.Models;
using WebAppMigracion0._1.Models.BD;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace WebAppMigracion0._1.Controllers
{
    public class SolicitudController : Controller 
    {
        public IActionResult Index()
        {


            //Saca la lista
            List<ListTablaSolicitud> lst;

            //Uso del contexto entities. Conexion a la BD
            using (var db = new Models.BD.dbMigracionContext())
            {
               
                //Obtiene el listado de los elementos
                lst = (from d in db.Solicituds

                       select new ListTablaSolicitud

                       {
                           Id = d.Id,
                           NombreEstado=d.NombreEstado,
                           FechaCreacion=d.FechaCreacion

            }).ToList();
            }
           

            //Manda la lista como modelo a su vista
            return View(lst);
        }

        //Metodo nuevo
        public ActionResult Nuevo()
{

    return View();

}


//Metodo nuevo que ejecuta el boton guardar
[HttpPost]
public ActionResult Nuevo(ListTablaSolicitud model)
{
    //El try regresa el error si existe
    try
    {

        //Valida que son requeridos y ahi empieza la programacion
        if (ModelState.IsValid)
        {


            using (var db = new Models.BD.dbMigracionContext())
            {

                //Creacion del objeto tabla(o)
                var oSolictud = new ListTablaSolicitud();

                oSolictud.Id = model.Id;
                oSolictud.NombreEstado = model.NombreEstado;
                oSolictud.FechaCreacion = model.FechaCreacion;



                //Guarda en la BD la informacion
                db.Solicituds.Add(oSolictud);
                db.SaveChanges();

            }

            //Regresa a la vista donde esta el listado
            return Redirect("~/Solicitud/");

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
    ListTablaSolicitud model = new ListTablaSolicitud();

    using (var db = new Models.BD.dbMigracionContext())

    {
        //Se obtienen los elementos de ID
        var oSolicitud = db.Solicituds.Find(Id);

        //Llena los modelos ID, NOMBRE, CORREO Y FECHA

        //Se manda el ID al modelo para saber cual se va a editar


        model.Id = oSolicitud.Id;
        model.NombreEstado = oSolicitud.NombreEstado;
        model.FechaCreacion = oSolicitud.FechaCreacion;



    }

    return View(model);

}


//Metodo editar con cod. programacion
[HttpPost]
public ActionResult Editar(ListTablaSolicitud model)
{
    try
    {
        if (ModelState.IsValid)
        {
            using (var db = new Models.BD.dbMigracionContext())
            {
                var oSolictud = db.Solicituds.Find(model.Id);


                oSolictud.NombreEstado = model.NombreEstado;
                oSolictud.FechaCreacion = model.FechaCreacion;




            

                db.SaveChanges();
            }
            return Redirect("~/Solicitud/");
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

        var oSolicitud = db.Solicituds.Find(Id);

        //Elimina la entidad (tabla)
        db.Solicituds.Remove(oSolicitud);
        //Guarda
        db.SaveChanges();
    }

    //Redirect al listado
    return Redirect("~/Solicitud/");


}
    }
}
