using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaContable.Servicios
{
    public class ServicioReportes
    {
        private readonly Cuentas_Memori _memoria;

        public ServicioReportes()
        {
            
            _memoria = Cuentas_Memori.Instancia ?? new Cuentas_Memori();
        }

        private decimal SumaDebeCuenta(string codigo)
        {
            return _memoria.Asientos
                .SelectMany(a => a.Detalle)   
                .Where(d => d.CodigoCuenta == codigo)
                .Sum(d => d.Debe);
        }

        private decimal SumaHaberCuenta(string codigo)
        {
            return _memoria.Asientos
                .SelectMany(a => a.Detalle)
                .Where(d => d.CodigoCuenta == codigo)
                .Sum(d => d.Haber);
        }

        public List<dynamic> ObtenerBalanzaComprobacion()
        {
            var cuentas = _memoria.Cuentas;

            var balanza = cuentas.Select(c => new
            {
                Codigo = c.Codigo,
                Nombre = c.Nombre,
                Debe = SumaDebeCuenta(c.Codigo),
                Haber = SumaHaberCuenta(c.Codigo),
                Saldo = SumaDebeCuenta(c.Codigo) - SumaHaberCuenta(c.Codigo)
            }).ToList<dynamic>();

            return balanza;
        }

        // Estado de Resultados y Balance General: usa SumaDebeCuenta/SumaHaberCuenta
        public dynamic GenerarEstadoResultados()
        {
            var cuentas = _memoria.Cuentas;

            decimal ingresos = cuentas
                .Where(c => c.Codigo.StartsWith("4"))
                .Sum(c => SumaHaberCuenta(c.Codigo) - SumaDebeCuenta(c.Codigo));

            decimal gastos = cuentas
                .Where(c => c.Codigo.StartsWith("5"))
                .Sum(c => SumaDebeCuenta(c.Codigo) - SumaHaberCuenta(c.Codigo));

            return new
            {
                Ingresos = ingresos,
                Gastos = gastos,
                Utilidad = ingresos - gastos
            };
        }

        public dynamic GenerarBalanceGeneral()
        {
            var cuentas = _memoria.Cuentas;

            decimal activos = cuentas
                .Where(c => c.Codigo.StartsWith("1"))
                .Sum(c => SumaDebeCuenta(c.Codigo) - SumaHaberCuenta(c.Codigo));

            decimal pasivos = cuentas
                .Where(c => c.Codigo.StartsWith("2"))
                .Sum(c => SumaHaberCuenta(c.Codigo) - SumaDebeCuenta(c.Codigo));

            decimal patrimonio = cuentas
                .Where(c => c.Codigo.StartsWith("3"))
                .Sum(c => SumaHaberCuenta(c.Codigo) - SumaDebeCuenta(c.Codigo));

            return new
            {
                Activos = activos,
                Pasivos = pasivos,
                Patrimonio = patrimonio,
                Equilibrado = activos == pasivos + patrimonio
            };
        }
    }
}
    
