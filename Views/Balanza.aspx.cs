using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SistemaContable.Servicios;

namespace SistemaContable.Views
{
    public partial class Balanza : System.Web.UI.Page
    {
        private readonly ServicioReportes _servicio = new ServicioReportes();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                gridBalanza.DataSource = _servicio.ObtenerBalanzaComprobacion();
                gridBalanza.DataBind();
            }
        }
    }
}