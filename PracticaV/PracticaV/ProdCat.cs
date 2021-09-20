using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaV
{
    public class ProdCat
    {

        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }
        public string NombreDelProducto { get; set; }
        public string NombreDeLaCategoria { get; set; }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public double Precio { get; set; }
    }
}
