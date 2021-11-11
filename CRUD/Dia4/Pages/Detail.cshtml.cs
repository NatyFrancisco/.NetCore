using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dia4.Core;
using Dia4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Dia4.Pages
{
    public class DetailModel : PageModel
    {
        //Inyectar el servicio
        public Product Product { get; set; }

        public IProductRepository ProductRepository { get; }

        public DetailModel(IProductRepository productrepository)
        {
            ProductRepository = productrepository;
        }

        public Product product { get; set; }
        //public IActionResult OnGet(int id)
        //{
        //    product = ProductRepository.GetById(id);

        //    //Condicion por si el producto no existe

        //    if (product == null)
        //    {
        //        return RedirectToPage("./NotFound");
        //    }
        //    return Page();
        //}
    }
}
