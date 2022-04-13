using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppMigracion0._1.Models.BD
{
    public partial class ListTablaPersona
    {
        public ListTablaPersona()
        {
            Modeloequipos = new HashSet<Modeloequipo>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public long Pasaporte { get; set; }
        public string Direccion { get; set; }
        public string Sexo { get; set; }

        public string Foto { get; set; }

        public virtual ICollection<Modeloequipo> Modeloequipos { get; set; }
    }

    
}
