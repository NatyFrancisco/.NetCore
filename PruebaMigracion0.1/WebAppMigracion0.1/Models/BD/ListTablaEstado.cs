using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppMigracion0._1.Models.BD
{
    public partial class ListTablaEstado
    {
        public ListTablaEstado()
        {
            Modeloequipos = new HashSet<Modeloequipo>();
        }

        public string Estado1  { get; set; }

        public virtual ICollection<Modeloequipo> Modeloequipos { get; set; }
    }
}
