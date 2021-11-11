using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dia4.Core;
using Dia4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Dia4.Pages
{
   

    public class EditModel : PageModel
    {
        private readonly IProductRepository productRepository;
        private readonly IHtmlHelper htmlHelper;
        [BindProperty]

        public Product Product { get; set; }

        public IEnumerable<SelectListItem> Categories;

        public EditModel(IProductRepository productRepository, IHtmlHelper htmlHelper)
        {
            this.productRepository = productRepository;
            this.htmlHelper = htmlHelper;
        }
        public IActionResult OnGet(int id)
        {

            //Se llama al metodo GetEnumSelectList para general un SelectList basado en las especificaciones de un tipo enumerados
            this.Categories = htmlHelper.GetEnumSelectList<Category>();

            Product = productRepository.GetById(id);

            if(Product != null)
            {
                return Page();
            }
            return RedirectToPage("./NotFound");
        }

        //Recibe la informacion
        public IActionResult OnPost(int id)
        {
            this.Categories = htmlHelper.GetEnumSelectList<Category>();
            this.Product = productRepository.Update(Product);
            return RedirectToPage("./Detail", new  { id = Product.Id });
        }
    }
}
