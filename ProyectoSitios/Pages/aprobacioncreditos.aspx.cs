using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;
using CapaDatos;

namespace ProyectoSitios.Pages
{
    public partial class aprobacioncreditos : System.Web.UI.Page
    {

        Nsolicitudes soli = new Nsolicitudes();
        string auxprestamo = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
            if (!IsPostBack)
            {
                cargarSolicitudes();
            }
        }
        public void cargarSolicitudes()
        {
            List<PrestamoSolcitudCredito> solcitudCreditos = soli.ListarVistas();

            if (auxprestamo.Equals(" "))
            {

                foreach (PrestamoSolcitudCredito solcitud in solcitudCreditos)
                {
                    if (solcitud.EstadoSolicitud.Contains("Analizando"))
                    {
                        string numSoli = solcitud.NumSolicitud.ToString();
                        string identificacion = solcitud.Identificacion;
                        string telefono = solcitud.Telefono.ToString();
                        string moneda = solcitud.Moneda.ToString();
                        string monto = solcitud.MontoSolicitado.ToString();

                        string salario = solcitud.SalarioLiquido.ToString();
                        string plazo = solcitud.Plazo.ToString();
                        string codigoprestamo = solcitud.CodigoPrestamo.ToString();
                        string endudamiento = solcitud.PorcentajeEndeudamiento.ToString();

                        string auxmoneda = "";
                        string auxtipopres = "";
                        if (moneda == "1")
                        {
                            auxmoneda = "Dolares";
                        }
                        else if (moneda == "2")
                        {
                            auxmoneda = "Colones";
                        }

                        if (codigoprestamo == "2")
                        {
                            auxtipopres = "Personal";
                        }
                        else if (codigoprestamo == "5")
                        {
                            auxtipopres = "Salud";
                        }
                        else if (codigoprestamo == "6")
                        {
                            auxtipopres = "Vehiculo";
                        }
                        else if (codigoprestamo == "7")
                        {
                            auxtipopres = "Vivienda";
                        }
                        TableRow row = new TableRow();
                        TableCell[] cell = new TableCell[] { new TableCell { Text = numSoli }, new TableCell { Text = identificacion }
                ,  new TableCell { Text = telefono } , new TableCell { Text = auxmoneda }
                , new TableCell { Text = monto } , new TableCell { Text = salario }
                , new TableCell { Text = plazo }
                , new TableCell { Text = auxtipopres } , new TableCell { Text = endudamiento }};
                        //cell.Text = word.ToString();
                        row.Cells.AddRange(cell);
                        tablesolicitudes.Rows.Add(row);

                    }
                }
            }
            else
            {
                foreach (PrestamoSolcitudCredito solcitud in solcitudCreditos)
                {
                    if (solcitud.CodigoPrestamo.ToString().Contains(auxprestamo) && solcitud.EstadoSolicitud.Contains("Analizando"))
                    {
                        string numSoli = solcitud.NumSolicitud.ToString();
                        string identificacion = solcitud.Identificacion;
                        string telefono = solcitud.Telefono.ToString();
                        string moneda = solcitud.Moneda.ToString();
                        string monto = solcitud.MontoSolicitado.ToString();

                        string salario = solcitud.SalarioLiquido.ToString();
                        string plazo = solcitud.Plazo.ToString();
                        string codigoprestamo = solcitud.CodigoPrestamo.ToString();
                        string endudamiento = solcitud.PorcentajeEndeudamiento.ToString();

                        string auxmoneda = "";
                        string auxtipopres = "";
                        if (moneda == "1")
                        {
                            auxmoneda = "Dolares";
                        }
                        else if (moneda == "2")
                        {
                            auxmoneda = "Colones";
                        }

                        if (codigoprestamo == "2")
                        {
                            auxtipopres = "Personal";
                        }
                        else if (codigoprestamo == "5")
                        {
                            auxtipopres = "Salud";
                        }
                        else if (codigoprestamo == "6")
                        {
                            auxtipopres = "Vehiculo";
                        }
                        else if (codigoprestamo == "7")
                        {
                            auxtipopres = "Vivienda";
                        }

                        TableRow row = new TableRow();
                        TableCell[] cell = new TableCell[] { new TableCell { Text = numSoli }, new TableCell { Text = identificacion }
                ,  new TableCell { Text = telefono } , new TableCell { Text = auxmoneda }
                , new TableCell { Text = monto } , new TableCell { Text = salario }
                , new TableCell { Text = plazo }
                , new TableCell { Text = auxtipopres } , new TableCell { Text = endudamiento }};
                        //cell.Text = word.ToString();
                        row.Cells.AddRange(cell);
                        tablesolicitudes.Rows.Add(row);

                    }
                }
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            string estado = "Denegada";
            string resultado = soli.Modificar(Convert.ToInt32(txtnumsoli.Text), estado);

            if (resultado.Equals("OK"))
            {
                cargarSolicitudes();
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Error: " + resultado;
                txtnumsoli.Text = "";
            }
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {

            List<PrestamoSolcitudCredito> solcitudCreditos = soli.ListarEndeudamiento(Convert.ToInt32(txtnumsoli.Text));
            string aux = "";
                foreach (PrestamoSolcitudCredito solcitud in solcitudCreditos)
                {
                    if (solcitud.EstadoSolicitud.Contains("Analizando"))
                    {
                        string endudamiento = solcitud.PorcentajeEndeudamiento.ToString();
                    aux = endudamiento;
                    }
                }



            if (Convert.ToInt32(aux)>40)
            {
                lblerror.Visible = true;
                lblerror.Text = "Error: El porcentaje de endeudamiento es muy alto y no es aceptado por las políticas del Banco NAV.";
            }
            else
            {
                string estado = "Aprobada";
                string resultado = soli.Modificar(Convert.ToInt32(txtnumsoli.Text), estado);

                if (resultado.Equals("OK"))
                {
                    cargarSolicitudes();
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Error: " + resultado;
                    txtnumsoli.Text = "";
                }
            }
            
        }

        protected void ddlTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            auxprestamo = ddlTipoPrestamo.SelectedValue;
        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            cargarSolicitudes();
        }
    }
}