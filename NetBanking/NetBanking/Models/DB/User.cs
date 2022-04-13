using System;
using System.Collections.Generic;

#nullable disable

namespace NetBanking.Models.DB
{
    public partial class User
    {
        public int Id { get; set; }
        public long Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Usuario { get; set; }
        public string Passw { get; set; }
    }
}
