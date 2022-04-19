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
    public partial class solicitudestramitar : System.Web.UI.Page
    {
        Nsolicitudes soli = new Nsolicitudes();
        string auxprestamo = "";
        NCalculadora calc = new NCalculadora();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarprestamos();
                cargarSolicitudes();
            }
        }
        public void cargarSolicitudes()
        {
            List<PrestamoSolcitudCredito> solcitudCreditos = soli.ListarVistas();

            if (auxprestamo.Equals(" ")|| auxprestamo.Equals("--Selecciona un préstamo--"))
            {

                foreach (PrestamoSolcitudCredito solcitud in solcitudCreditos)
                {
                    string estadp = solcitud.EstadoSolicitud.ToLower();

                    if (estadp.Contains("pendiente"))
                    {
                        string numSoli = solcitud.NumSolicitud.ToString();
                        string identificacion = solcitud.Identificacion;
                        string nombre = solcitud.NombreCompleto.ToString();
                        string telefono = solcitud.Telefono.ToString();
                        string moneda = solcitud.Moneda.ToString();
                        string monto = solcitud.MontoSolicitado.ToString();
                        string plazo = solcitud.Plazo.ToString();
                        string codigoprestamo="";
                        List<Prestamos> prest = calc.ListarPrestamos();
                        ListItem i;
                        foreach (Prestamos prestamo in prest)
                        {
                            if (prestamo.CodigoPrestamo.ToString().Equals(solcitud.CodigoPrestamo.ToString()))
                            {
                                 codigoprestamo = prestamo.NombrePrestamo.ToString();
                            }
                        }

                       
                        string fecha = solcitud.FechaSolicitud.ToString("dd-MM-yyyy");
                        string auxmoneda = "";
                        if (moneda == "1")
                        {
                            auxmoneda = "Dolares";
                        }
                        else if (moneda == "2")
                        {
                            auxmoneda = "Colones";
                        }
                        TableRow row = new TableRow();
                        TableCell[] cell = new TableCell[] { new TableCell { Text = numSoli }, new TableCell { Text = identificacion }
                ,  new TableCell { Text = codigoprestamo }, new TableCell { Text = monto } , new TableCell { Text = fecha }};
                        //cell.Text = word.ToString();
                        row.Cells.AddRange(cell);
                        TablaSolicitudes.Rows.Add(row);

                    }
                }
            }
            else
            {
                foreach (PrestamoSolcitudCredito solcitud in solcitudCreditos)
                {
                    string estadp = solcitud.EstadoSolicitud.ToLower();

                    if (solcitud.CodigoPrestamo.ToString().Contains(auxprestamo) && estadp.Contains("pendiente"))
                    {
                        string numSoli = solcitud.NumSolicitud.ToString();
                        string identificacion = solcitud.Identificacion;
                        string telefono = solcitud.Telefono.ToString();
                        string moneda = solcitud.Moneda.ToString();
                        string monto = solcitud.MontoSolicitado.ToString();
                        string plazo = solcitud.Plazo.ToString();
                        string codigoprestamo = "";
                        List<Prestamos> prest = calc.ListarPrestamos();
                        ListItem i;
                        foreach (Prestamos prestamo in prest)
                        {
                            if (prestamo.CodigoPrestamo.ToString().Equals(solcitud.CodigoPrestamo.ToString()))
                            {
                                codigoprestamo = prestamo.NombrePrestamo.ToString();
                            }
                        }
                        string fecha = solcitud.FechaSolicitud.ToString("dd-MM-yyyy");
                        string auxmoneda = "";
                        if (moneda == "1")
                        {
                            auxmoneda = "Dolares";
                        }
                        else if (moneda == "2")
                        {
                            auxmoneda = "Colones";
                        }
                        TableRow row = new TableRow();
                        TableCell[] cell = new TableCell[] { new TableCell { Text = numSoli }, new TableCell { Text = identificacion }
                , new TableCell { Text = codigoprestamo }, new TableCell { Text = monto } , new TableCell { Text =  fecha}};

                        //cell.Text = word.ToString();
                        row.Cells.AddRange(cell);
                        TablaSolicitudes.Rows.Add(row);

                    }
                }
            }
        }

        public void cargarprestamos()
        {
            List<Prestamos> prest = calc.ListarPrestamos();
            ListItem i;
            foreach (Prestamos prestamo in prest)
            {

                i = new ListItem(prestamo.NombrePrestamo, prestamo.CodigoPrestamo.ToString());
                ddltipo.Items.Add(i);
            }
        }

        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            //boton
            auxprestamo = ddltipo.SelectedValue;
            cargarSolicitudes();
            auxprestamo = " ";

        }

        protected void btnAgregar_Click1(object sender, EventArgs e)
        {

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        protected void ddlTipoPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ddltipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void txtTramitar_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btntramitar_Click1(object sender, EventArgs e)
        {
           int numerosolicitud =Convert.ToInt32(txtTramitar.Text);
            soli.EnviarSolicitud(numerosolicitud, "Tramitando");
            cargarSolicitudes();
            auxprestamo = " ";
        }
    }
}