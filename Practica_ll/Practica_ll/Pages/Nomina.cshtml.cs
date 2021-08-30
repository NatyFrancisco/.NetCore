using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Practica_ll.Pages
{
    public class NominaModel : PageModel
    {




        //Los datos de nombre, apellido, cargo y salario

        public string Nombre { get; set; } = "Naty";

     


    
        public string Apellido  { get; set; } = "Francisco";


        public string Cargo { get; set; } = "Desarrollador de software";

        public double Salario { get; set; } = 60000;

        






        public void OnGet()
        {
            
        }
    }
}
