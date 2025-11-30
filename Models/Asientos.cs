using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaContable.Models
{
    public class Asientos
    {
        [Required]
        public string Numero { get; set; }


        [Required]
        public DateTime Fecha { get; set; }


        public string Descripcion { get; set; }


        public List<Movimientos> Movimientos { get; set; } = new List<Movimientos>();// Inicializar la lista para evitar null reference



        public decimal TotalDebe => Movimientos?.Sum(m => m.Debe) ?? 0;// Suma de todos los debe
        public decimal TotalHaber => Movimientos?.Sum(m => m.Haber) ?? 0;// Suma de todos los haber


        public bool IsBalanced => TotalDebe == TotalHaber;// Verificar si el asiento está balanceado



    }
}