using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaContable.Servicios;

namespace SistemaContable.Views
{
    public partial class BalanceGeneral : System.Web.UI.Page
    {
        ServicioReportes servicio = new ServicioReportes();
        protected void Page_Load(object sender, EventArgs e)
        {
            var bg = servicio.GenerarBalanceGeneral();

            lblActivos.Text = bg.Activos.ToString("N2");
            lblPasivos.Text = bg.Pasivos.ToString("N2");
            lblPatrimonio.Text = bg.Patrimonio.ToString("N2");
            lblEquilibrio.Text = bg.Equilibrado ? "Sí" : "No";
        }
    }
}