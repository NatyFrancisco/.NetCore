using Dia4.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dia4.Data
{
   public interface IProductRepository
    {

        //METODO PARA OBTENER LA LISTA COMPLETA
        public IEnumerable<Product> GetAll();


        //METODO DE EDITAR
        public Product GetById(int id);


        //METODO DE ACTUALIZAR
        public Product Update(Product product);
    }
}
