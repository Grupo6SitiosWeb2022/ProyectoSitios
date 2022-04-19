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
    public partial class login : System.Web.UI.Page


    {
        Nusuarios user = new Nusuarios();

        protected void Page_Load(object sender, EventArgs e)
        {
            lblerror.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string resp = user.ValidarNulosIndex(txtUser.Text, txtPass.Text);
            if (resp.Equals("1"))
            {
                resp = user.ValidarNumero(txtUser.Text);
                if (resp.Equals("1"))
                {
                    
                    resp = user.InicioSesion(txtUser.Text, txtPass.Text);
                    if (resp.Equals("El usuario no existe"))
                    {
                        lblerror.Visible = true;
                        lblerror.Text = "Error: " + resp;
                        txtUser.Text = "";
                        txtPass.Text = "";

                    }
                    else if (resp.Equals("Usuario y/o contraseña incorrectos."))
                    {
                        lblerror.Visible = true;
                        lblerror.Text = "Error: " + resp;
                        txtUser.Text = "";
                        txtPass.Text = "";

                    }                    
                    else
                    {
                        UsuarioLogin.Usuario1 = txtUser.Text;
                        UsuarioLogin.Contrasena1 = txtPass.Text;

                        if (resp.Equals("2") ){
                            Response.Redirect("../Pages/Index.aspx");
                        }
                        else if (resp.Equals("1")){
                            Response.Redirect("../Pages/PanelAdministrativoTramitador.aspx");
                        }
                        else if ( resp.Equals("3") )
                        {
                            Response.Redirect("../Pages/PanelAdministrativoAnalista.aspx");
                        }
                        else
                        {
                            lblerror.Visible = true;
                            lblerror.Text = "Error: " + resp;
                            txtUser.Text = "";
                            txtPass.Text = "";
                        }
                    }
                }
                else
                {
                    lblerror.Visible = true;
                    lblerror.Text = "Error: " + resp;
                    txtUser.Text = "";
                    txtPass.Text = "";
                }
            }
            else
            {
                lblerror.Visible = true;
                lblerror.Text = "Error: " + resp;
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }
    }
}