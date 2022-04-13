using System;
using System.Collections.Generic;

#nullable disable

namespace NetBanking.Models.DB
{
    public partial class Cuentum
    {
        public int Id { get; set; }
        public long NoCuenta { get; set; }
        public long Balance { get; set; }
    }
}
