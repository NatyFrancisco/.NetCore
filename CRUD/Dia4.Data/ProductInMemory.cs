using Dia4.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia4.Data
{
   public class ProductInMemory : IProductRepository

    {
        //CREACION DE LA LISTA
        List<Product> products;

        //Constructor de mi clase con CTOR
        public ProductInMemory()
        {
            products = new List<Product>(){
                new Product(){Id=1, productName="Laptop Hp 15inch", UnitPrice=28900},
                new Product(){Id=2, productName="Mouse inalambrico", UnitPrice=780.99},
                new Product(){Id=3, productName="Bocinas Logitec Z1000", UnitPrice=4000},
            };
        }

        //Es una coleccion
        public IEnumerable<Product> GetAll()
        {
            //Retorna la lista de producto
            return products; 
        }


        //ES EL METODO DE DETALLES
        public Product GetById(int id)
        {
          foreach(var p in products)
            {
                if (p.Id==id)
                {
                    return p;
                }
            }

            return null;
        }

        //ES EL METODO EDITAR
        public Product Update (Product product)
        {

            //Recorre un producto buscando el ID del producto que corresponde con el parametro para modificarlo
            foreach(var p in products)
            {
                if (p.Id == product.Id)
                {
                    p.productName = product.productName;
                        p.Category = product.Category;
                    p.UnitPrice = product.UnitPrice;
                    return p;
                       
                }
            }
            return product;
        }

    }
}
