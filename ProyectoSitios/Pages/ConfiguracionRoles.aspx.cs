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
    public partial class ConfiguracionRoles : System.Web.UI.Page
    {
        NRoles nroles = new NRoles();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarroles(" ");
            }

        }
        public void cargarroles(string info)
        {
            List<Roles> roleslist = nroles.ListarRoles();
            if (info.Equals(" "))
            {
                foreach (Roles rol in roleslist)
                {
                    string cod = rol.IdTipoRol.ToString();
                    string nom = rol.NombreRol;
                    TableRow row = new TableRow();
                    TableCell[] cell = new TableCell[] { new TableCell { Text = cod }, new TableCell { Text = nom } };
                    //cell.Text = word.ToString();
                    row.Cells.AddRange(cell);
                    TablaRolesn.Rows.Add(row);
                }
            }
            else 
            {
                foreach (Roles rol in roleslist)
                {
                    if (rol.NombreRol.Contains(info))
                    {
                        string cod = rol.IdTipoRol.ToString();
                        string nom = rol.NombreRol;
                        TableRow row = new TableRow();
                        TableCell[] cell = new TableCell[] { new TableCell { Text = cod }, new TableCell { Text = nom } };
                        //cell.Text = word.ToString();
                        row.Cells.AddRange(cell);
                        TablaRolesn.Rows.Add(row);
                    }
                }
                   
            }
            
        }

        protected void txtFiltro_TextChanged(object sender, EventArgs e)
        {

        }


        protected void btnBuscar_Click1(object sender, EventArgs e)
        {
            cargarroles(txtFiltro.Text);
        }



        protected void btnAgregar_Click1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodRol.Text) || string.IsNullOrEmpty(txtNombreRol.Text))
            {

            }
            else
            {
                nroles.CrearRol(int.Parse(txtCodRol.Text), txtNombreRol.Text);
                cargarroles(" ");
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            nroles.Modificar(int.Parse(txtCodRol.Text), txtNombreRol.Text);
            cargarroles(" ");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            nroles.EliminarRol(int.Parse(txtCodRol.Text), txtNombreRol.Text);
            cargarroles(" ");
        } 
    }
}