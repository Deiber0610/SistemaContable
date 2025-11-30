using SistemaContable.Models;
using System.Collections.Generic;

namespace SistemaContable.Servicios
{
    public class Cuentas_Memori
    {

        public List<Cuenta> Cuentas { get; } = new List<Cuenta>(); // Lista de cuentas en memoria
        public List<Asientos> Asientos { get; } = new List<Asientos>();// Lista de asientos en memoria


        public Cuentas_Memori()
        {
            SeedCuentas();// Llenar la lista de cuentas al inicializar
        }


        private void SeedCuentas()// Método para llenar la lista de cuentas
        {
            // ACTIVOS CORRIENTES
            Cuentas.Add(new Cuenta { Codigo = "1100", Nombre = "Caja", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1105", Nombre = "Caja Chica", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1110", Nombre = "Bancos", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1120", Nombre = "Clientes", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1130", Nombre = "Cuentas por Cobrar", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1140", Nombre = "Inventarios", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1150", Nombre = "Anticipos a Proveedores", TipoId = 1 });

            // ACTIVOS NO CORRIENTES
            Cuentas.Add(new Cuenta { Codigo = "1200", Nombre = "Propiedad Planta y Equipo", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1210", Nombre = "Mobiliario y Equipo", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1220", Nombre = "Vehículos", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1230", Nombre = "Edificios", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1240", Nombre = "Terrenos", TipoId = 1 });
            Cuentas.Add(new Cuenta { Codigo = "1250", Nombre = "Depreciación Acumulada", TipoId = 1 });

            // PASIVOS CORRIENTES
            Cuentas.Add(new Cuenta { Codigo = "2100", Nombre = "Proveedores", TipoId = 2 });
            Cuentas.Add(new Cuenta { Codigo = "2110", Nombre = "Cuentas por Pagar", TipoId = 2 });
            Cuentas.Add(new Cuenta { Codigo = "2120", Nombre = "Acreedores Diversos", TipoId = 2 });
            Cuentas.Add(new Cuenta { Codigo = "2130", Nombre = "Impuestos por Pagar", TipoId = 2 });
            Cuentas.Add(new Cuenta { Codigo = "2140", Nombre = "Salarios por Pagar", TipoId = 2 });
            Cuentas.Add(new Cuenta { Codigo = "2150", Nombre = "Gastos Acumulados", TipoId = 2 });

            // PASIVOS NO CORRIENTES
            Cuentas.Add(new Cuenta { Codigo = "2200", Nombre = "Préstamos Bancarios LP", TipoId = 2 });
            Cuentas.Add(new Cuenta { Codigo = "2210", Nombre = "Hipotecas por Pagar", TipoId = 2 });
            Cuentas.Add(new Cuenta { Codigo = "2220", Nombre = "Documentos por Pagar", TipoId = 2 });

            // PATRIMONIOS
            Cuentas.Add(new Cuenta { Codigo = "3100", Nombre = "Capital Social", TipoId = 3 });
            Cuentas.Add(new Cuenta { Codigo = "3110", Nombre = "Aportes de Socios", TipoId = 3 });
            Cuentas.Add(new Cuenta { Codigo = "3120", Nombre = "Utilidades Acumuladas", TipoId = 3 });
            Cuentas.Add(new Cuenta { Codigo = "3130", Nombre = "Pérdidas Acumuladas", TipoId = 3 });
            Cuentas.Add(new Cuenta { Codigo = "3140", Nombre = "Reserva Legal", TipoId = 3 });

            // INGRESOS
            Cuentas.Add(new Cuenta { Codigo = "4100", Nombre = "Ventas", TipoId = 4 });
            Cuentas.Add(new Cuenta { Codigo = "4110", Nombre = "Ingresos por Servicios", TipoId = 4 });
            Cuentas.Add(new Cuenta { Codigo = "4120", Nombre = "Ingresos Financieros", TipoId = 4 });
            Cuentas.Add(new Cuenta { Codigo = "4130", Nombre = "Descuentos Obtenidos", TipoId = 4 });
            Cuentas.Add(new Cuenta { Codigo = "4140", Nombre = "Ganancias Cambiarias", TipoId = 4 });

            // GASTOS
            // GASTOS OPERATIVOS
            Cuentas.Add(new Cuenta { Codigo = "5100", Nombre = "Gastos Administrativos", TipoId = 5 });
            Cuentas.Add(new Cuenta { Codigo = "5110", Nombre = "Gastos de Venta", TipoId = 5 });
            Cuentas.Add(new Cuenta { Codigo = "5120", Nombre = "Gastos Generales", TipoId = 5 });
            Cuentas.Add(new Cuenta { Codigo = "5130", Nombre = "Publicidad", TipoId = 5 });
            Cuentas.Add(new Cuenta { Codigo = "5140", Nombre = "Servicios Públicos", TipoId = 5 });
            Cuentas.Add(new Cuenta { Codigo = "5150", Nombre = "Alquileres", TipoId = 5 });

            // GASTOS NO OPERATIVOS
            Cuentas.Add(new Cuenta { Codigo = "5200", Nombre = "Gastos Financieros", TipoId = 5 });
            Cuentas.Add(new Cuenta { Codigo = "5210", Nombre = "Pérdidas Cambiarias", TipoId = 5 });
            Cuentas.Add(new Cuenta { Codigo = "5220", Nombre = "Intereses por Pagar", TipoId = 5 });
        }
    }
}