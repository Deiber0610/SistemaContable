using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaContable.Models
{
    public class Movimientos
    {
        public string CuentaCodigo { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }
    }
}