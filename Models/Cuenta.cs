using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaContable.Models
{
    public class Cuenta
    {
        [Required]
        public string Codigo { get; set; } // e.g. "1001"


        [Required]
        public string Nombre { get; set; }


        [Required]
        [Range(1, 5)]
        public int TipoId { get; set; } // 1..5 según convención


        // Reemplazar el switch expression por un switch statement compatible con C# 7.3
        public string TipoName
        {
            get
            {
                switch (TipoId)
                {
                    case 1:
                        return "Activo";
                    case 2:
                        return "Pasivo";
                    case 3:
                        return "Patrimonio";
                    case 4:
                        return "Ingreso";
                    case 5:
                        return "Gasto";
                    default:
                        return "Desconocido";
                }
            }
        }
    }
}