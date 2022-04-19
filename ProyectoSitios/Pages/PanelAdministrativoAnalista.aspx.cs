using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
namespace ProyectoSitios.Pages
{
    public partial class PanelAdministrativo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string user = UsuarioLogin.Usuario1;
          string pass=  UsuarioLogin.Contrasena1;
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {

        }
    }
}