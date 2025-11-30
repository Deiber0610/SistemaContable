using SistemaContable.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaContable.Views
{
    public partial class Mayor : System.Web.UI.Page
    {
        private static Cuentas_Memori _db = new Cuentas_Memori();// instancia estática de Cuentas_Memori
        private ServicioMayor _servicioMayor;// variable de tipo ServicioMayor
        protected void Page_Load(object sender, EventArgs e)
        {
            
            _servicioMayor = new ServicioMayor(_db);// inicialización de ServicioMayor con la instancia estática de Cuentas_Memori
            if (!IsPostBack)// cargar datos solo la primera vez que se carga la página
            {
                CargarMayor();// método para cargar el mayor
            }
        }
        private void CargarMayor()
        {
            var mayorDatos = _servicioMayor.GenerarMayor();// obtenemos los datos del mayor
            gvMayor.DataSource = mayorDatos;// asignamos los datos al GridView
            gvMayor.DataBind();// enlazamos los datos al GridView
        }
    }
}