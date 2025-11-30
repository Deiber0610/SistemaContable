using SistemaContable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaContable.Servicios
{
    public class ServicioMayor
    {
        private readonly Cuentas_Memori _db;// inyección de dependencia
        public ServicioMayor(Cuentas_Memori db)// variable de tipo Cuentas_Memori
        {
            _db = db;
        }
        private List<Movimientos> ObtenerMovimientosPorCuenta(string cuentaCodigo)// obtener movimientos por código de cuenta
        {
            return _db.Asientos // Accedemos a la lista de asientos
                .SelectMany(a => a.Movimientos)// Seleccionamos todos los movimientos de cada asiento
                .Where(m => m.CuentaCodigo == cuentaCodigo)// Filtramos los movimientos por el código de cuenta
                .ToList();// Convertimos el resultado a una lista
        }
        private (decimal totalDebe, decimal totalHaber) CalcularTotales(List<Movimientos> movimientos)// tupla
        {
            decimal totalDebe = movimientos.Sum(m => m.Debe);// suma de todos los debe
            decimal totalHaber = movimientos.Sum(m => m.Haber);// suma de todos los haber
            return (totalDebe, totalHaber);// retornamos la tupla
        }
        private decimal CalcularSaldo(Cuenta cuenta, decimal totalDebe, decimal totalHaber)// calcular saldo según tipo de cuenta
        {
            if (cuenta.TipoId == 1 || cuenta.TipoId == 5) // Activo o Ingreso
            {
                return totalDebe - totalHaber;// saldo para activo o ingreso
            }
            else // Pasivo, Patrimonio o Gasto
            {
                return totalHaber - totalDebe;// saldo para pasivo, patrimonio o gasto
            }
        }

        public List<MayorResultado> GenerarMayor()// método principal para generar el mayor
        {
            var resultado = new List<MayorResultado>();// lista de resultados

            foreach (var cuenta in _db.Cuentas)// recorremos cada cuenta
            {
                var movimientos = ObtenerMovimientosPorCuenta(cuenta.Codigo);// obtenemos los movimientos de la cuenta

                var (totalDebe, totalHaber) = CalcularTotales(movimientos);// calculamos los totales

                var saldo = CalcularSaldo(cuenta, totalDebe, totalHaber);// calculamos el saldo

                resultado.Add(new MayorResultado// agregamos el resultado a la lista
                {
                    Codigo = cuenta.Codigo,// código de la cuenta
                    Nombre = cuenta.Nombre,// nombre de la cuenta
                    Tipo = cuenta.TipoName,// tipo de la cuenta
                    totalDebe = totalDebe,// total debe
                    totalHaber = totalHaber,// total haber
                    saldo = saldo// saldo
                });
            }
            return resultado;// retornamos la lista de resultados
        }

        public class MayorResultado// clase para representar el resultado del mayor
        {
            public string Codigo { get; set; }
            public string Nombre { get; set; }
            public string Tipo { get; set; }
            public decimal totalDebe { get; set; }
            public decimal totalHaber { get; set; }
            public decimal saldo { get; set; }
        }
    }
}