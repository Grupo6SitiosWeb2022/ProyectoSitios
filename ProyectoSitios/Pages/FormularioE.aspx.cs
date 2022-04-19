using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;


namespace ProyectoSitios.Pages
{
    public partial class FormularioE : System.Web.UI.Page
    {
        NFormularios nsolicitudes = new NFormularios();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFormulario_Click(object sender, EventArgs e)
        {
            PrestamoSolcitudCreditoClass scp = new PrestamoSolcitudCreditoClass()
            {
                NumSolicitud = 2,
                TipoIdentificacion = Convert.ToInt32(ddlTiposIdentificacion.SelectedValue),
                Identificacion = txtIdetificacion.Text,
                NombreCompleto = txtNombreC.Text,
                CorreoElectronico = txtcorreo.Text,
                Telefono = txtTelefono.Text,
                Moneda = Convert.ToInt32(ddlTipoMoneda.SelectedValue),
                Direccion = txtDireccion.Text,
                MontoSolicitado = Convert.ToInt32(txtMonto.Text),
                Plazo = Convert.ToInt32(txtPlazo.Text),
                SalarioLiquido = Convert.ToInt32(txtSalario.Text),
                CodigoPrestamo = 9,
                Tasainteresactual = 3,
                PorcentajeEndeudamiento = 20,
                EstadoSolicitud = "Pendiente",

            };
            nsolicitudes.CrearFormulario(scp);

        }
    }
}