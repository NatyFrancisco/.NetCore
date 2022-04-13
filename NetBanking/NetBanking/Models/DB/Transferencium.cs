using System;
using System.Collections.Generic;

#nullable disable

namespace NetBanking.Models.DB
{
    public partial class Transferencium
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string TipoCuenta { get; set; }
        public string Banco { get; set; }
        public long NoCuenta { get; set; }
        public long Monto { get; set; }
    }
}
