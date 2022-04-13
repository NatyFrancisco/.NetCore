using System;
using System.Collections.Generic;

#nullable disable

namespace WebAppMigracion0._1.Models.BD
{
    public partial class Modeloequipo
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public string EstadoId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual ListTablaEstado Estado { get; set; }
        public virtual ListTablaPersona Persona { get; set; }
    }
}
