using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaContable.Models
{
    public class DetalleAsiento
    {
        public int AsientoDetalleId { get; set; }
        public int AsientoId { get; set; }
        public int CuentaId { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }

    }
}