using Dia4.Core;
using Dia4.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dia4.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ILogger<IndexModel> _logger;
        //Campo para cargar la dependencia
        private readonly IProductRepository productRepository;

        public List<Product> products { get; set; }
        

        //Inyeccion del servicio
        public IndexModel(ILogger<IndexModel> logger, IProductRepository productRepository)
        {
            _logger = logger;
            this.productRepository = productRepository;
        }

        public void OnGet()
        {
            //Llenamos la lista. Devuelve un IEnumerable
            //Lista generica. No se puede convertir una lista directamente con enumerable
            this.products = productRepository.GetAll().ToList();
        }
    }
}
