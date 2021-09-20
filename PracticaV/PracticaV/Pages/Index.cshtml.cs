using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaV.Pages
{
    public class IndexModel : PageModel
    {
        

        private readonly ILogger<IndexModel> _logger;

        //Cree una entidad llamada Producto, con propiedades id, nombre, categoriaId, marca, modelo y precio.
        //Haga una lista genérica con al menos 10 productos y llámala productos
        public Product producto  { get; set; }
        public List<Product> Productos { get; set; }
        public List<ProdCat> prodCat { get; set; }


        // Cree una entidad llamada Categoría, con propiedades id, nombre.
        //Haga una lista genérica con al menos 5 categorías y llámala Categorías.

        public Category categoria { get; set; }
        public List<Category> Categorias { get; set; }


        public IndexModel(ILogger<IndexModel> logger)
        {
            //Instancia del producto
            producto = new Product();

            //Instancia de la categoria
            categoria = new Category();

            _logger = logger;

            this.Productos = new List<Product>() {

               new Product() { Id = 1, Nombre = "Globos R9", CategoriaId = 1, Marca="Buffon", Modelo="Latex", Precio=5},
               new Product() { Id = 2, Nombre = "Bomba manual", CategoriaId = 2, Marca="Sermpertex", Modelo="Bomba", Precio=650},
               new Product() { Id = 3, Nombre = "Confetis", CategoriaId = 3, Marca="JPACO", Modelo="Confeti metalico", Precio=75},
               new Product() { Id = 4, Nombre = "Globos metalicos", CategoriaId = 4, Marca="Qualatex", Modelo="Metalicos", Precio=3000},
               new Product() { Id = 5, Nombre = "Globos numericos", CategoriaId = 5, Marca="Qualatex", Modelo="Numeros", Precio=4000},
               new Product() { Id = 6, Nombre = "Cinta curling", CategoriaId = 6, Marca="Yuli", Modelo="Metalicas", Precio=35},
               new Product() { Id = 7, Nombre = "Velas magicas", CategoriaId = 7, Marca="Vengala", Modelo="Magicas", Precio=45},
               new Product() { Id = 8, Nombre = "Foami", CategoriaId = 8, Marca="Eva", Modelo="Goma eva", Precio=15},
               new Product() { Id = 9, Nombre = "Letreros en globos", CategoriaId = 9, Marca="Qualatex", Modelo="Globos", Precio=5550},
               new Product() { Id = 10, Nombre = "Globos mil figuras", CategoriaId = 10, Marca="Buffon", Modelo="Latex", Precio=10},

            };

               this.Categorias = new List<Category>() {

               new Category() { Id = 1, Nombre = "Globos R9"},
               new Category() { Id = 2, Nombre = "Bomba manual"},
               new Category() { Id = 3, Nombre = "Confetis"},
               new Category() { Id = 4, Nombre = "Globos metalicos"},
               new Category() { Id = 5, Nombre = "Globos numericos"},
            };


            var conjunto = from p in this.Productos
                           //Productos por una categoria en especifico
                               //Los nombres de las categorías de los productos registrados (usar join)
                           join c in this.Categorias on p.CategoriaId equals c.Id
                            // Los productos con precios mayores de 3,000 pesos pero menores de 5000 pesos, ordenados descendente mente
                           where this.producto.Precio > 3000 || this.producto.Precio < 5000
                           orderby this.producto.Precio descending
                           select new ProdCat 
                            {
                                ProductoId = p.Id,
                                CategoriaId = c.Id,
                                NombreDelProducto = p.Nombre,
                                NombreDeLaCategoria = c.Nombre,
                                Marca = p.Marca,
                                Modelo = p.Modelo,
                                Precio = p.Precio
                            };


            this.prodCat = conjunto.ToList();

        }

        public void OnGet()
        {

        }
    }
}
