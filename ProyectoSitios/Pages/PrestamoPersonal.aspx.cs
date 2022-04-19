﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaNegocio;
namespace ProyectoSitios.Pages
{
    public partial class PrestamoPersonal : System.Web.UI.Page
    {
        NIndicadores ni = new NIndicadores();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSolicitarP_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Pages/FormularioC.aspx");

        }

        protected void btnVerMasP_Click(object sender, EventArgs e)
        {
            ni.AgregarIndicador(2,1);
            Response.Redirect("../Pages/prestamos.aspx");
        }
       
        protected void btnSolicitarV_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Pages/FormularioC.aspx");

        }

        protected void btnVerMasV_Click(object sender, EventArgs e)
        {
            ni.AgregarIndicador(6, 1);
            Response.Redirect("../Pages/PrestamosVehiculo.aspx");
        }

        protected void btnSolicitarVI_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Pages/FormularioC.aspx");

        }

        protected void btnVerMasVI_Click(object sender, EventArgs e)
        {
           
            ni.AgregarIndicador(8, 1);
            Response.Redirect("../Pages/PrestamosVivienda.aspx");
        }

        protected void btnSolicitarS_Click(object sender, EventArgs e)
        {
            Response.Redirect("../Pages/FormularioC.aspx");
        }

        protected void btnVerMasS_Click(object sender, EventArgs e)
        {

            ni.AgregarIndicador(5, 1);
            Response.Redirect("../Pages/PrestamosSalud.aspx");
        }
    }
}