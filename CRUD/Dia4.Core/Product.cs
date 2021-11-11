using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia4.Core
{
    //CREACION DE LAS CATEGORIAS

    //Tipo enumerado. Enum Category permite crear enumeraciones para crear uno de los posibles valores contemplados 
    public enum Category
    {
        //Listado de enumeracion
        None,
        Electronic,
        Computer,
        Hardware,
        Software
    }

    //DECLARACION DE LAS PROPIEDADES
    public class Product
    {
        public int Id { get; set; }
        //Validaciones
        [Required, MaxLength(20)]
        public string productName { get; set; }
        [Required]
        public double UnitPrice { get; set; }

        public Category Category { get; set; } 
    }
}
