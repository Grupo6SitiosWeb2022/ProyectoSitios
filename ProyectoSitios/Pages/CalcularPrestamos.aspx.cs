using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Controls;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace ProyectoSitios.Pages
{
    public partial class CalcularPrestamos : System.Web.UI.Page
    {
        Prestamos prestamos = new Prestamos();
        NCalculadora calc = new NCalculadora();
        NIndicadores ni = new NIndicadores();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarprestamos();
            }
        }

        protected void ddlTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            calc.CargarDatos(ddlTipoPrestamo.SelectedValue);
            lblTasa.Text = calc.tasa.ToString() + "%";
        }

        protected void ddlMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtMonto_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            

            double tasa = calc.tasa / 100;
            int montoTotal = int.Parse(txtMonto.Text);
            double montoMensual = 0;
            string rango = Request.Form["slider"];
            int plazo = int.Parse(rango);
            int meses = plazo * 12;
           // Response.AddHeader("uno", rango);

            double parte1 = montoTotal * tasa;
            double parte2 = montoTotal + parte1;
            double parte3 = parte2 / meses;
            montoMensual = parte3;

            //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" +
            //    rango + "');", true);
            if (ddlMoneda.SelectedValue.Equals("Dolares"))
            {

                lblCuotaMensual.Text = "$" + montoMensual.ToString();
            }
            else
            {
                lblCuotaMensual.Text = "₡" + montoMensual.ToString();
            }

            if (string.IsNullOrEmpty(UsuarioLogin.Usuario1))
            {
                ni.AgregarIndicador(Convert.ToInt32(ddlTipoPrestamo.SelectedValue), 4);
            }
            else{
                ni.AgregarIndicador(Convert.ToInt32(ddlTipoPrestamo.SelectedValue), 3);
            }
        }

        public void cargarprestamos()
        {
            List<Prestamos> prest = calc.ListarPrestamos();
            ListItem i;
            foreach (Prestamos prestamo in prest)
            {

                i = new ListItem(prestamo.NombrePrestamo, prestamo.CodigoPrestamo.ToString());
                ddlTipoPrestamo.Items.Add(i);
            }
        }

       
    }
}