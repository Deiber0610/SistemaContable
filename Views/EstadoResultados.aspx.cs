using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaContable.Servicios;

namespace SistemaContable.Views
{
    public partial class EstadoResultados : System.Web.UI.Page
    {
        ServicioReportes servicio = new ServicioReportes();
        protected void Page_Load(object sender, EventArgs e)
        {
            var er = servicio.GenerarEstadoResultados();

            lblIngresos.Text = er.Ingresos.ToString("N2");
            lblGastos.Text = er.Gastos.ToString("N2");
            lblUtilidad.Text = er.Utilidad.ToString("N2");
        }
    }
}