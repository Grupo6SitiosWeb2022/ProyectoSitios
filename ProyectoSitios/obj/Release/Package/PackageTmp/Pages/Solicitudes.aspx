<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Solicitudes.aspx.cs" Inherits="ProyectoSitios.Pages.Solicitudes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Solicitudes NAV</title>
    <meta name="viewport" content="width=device-width"/>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.1/css/bulma.min.css">
    <link href="https://fonts.googleapis.com/css2?family=Syne+Mono&display=swap" rel="stylesheet">
    <script src="https://use.fontawesome.com/releases/v5.1.0/js/all.js"></script>
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Arvo:ital@1&display=swap" rel="stylesheet">
        <link href="https://fonts.googleapis.com/css2?family=Syne+Mono&display=swap" rel="stylesheet" />
    <link href="../css/bulma.css" rel="stylesheet" />
   <style>
        body {
	    font-family: 'Josefin Sans', sans-serif;
    font-size: 25px;
}
        p{
            font-size:15px;
        }

</style>
</head>
<body>
    <form id="form1" runat="server">
          <div>
            <button class="buttonmenu" style="background-color: transparent;" type="button"
                onclick="location.href='https://www.facebook.com'">
                <img style="width: 7%; height: 70px; left: 25px; top: 28px; position: absolute; z-index: 101; display: flex; margin-top: 4px;"
                    src="../img/iconoblanco.png" />
            </button>
        </div>
             <div>
            <nav class="navbar" style="z-index: 100; top: 35px; background-color: #061738; color: white" role="navigation" aria-label="dropdown navigation">
                <div class="navbar-menu" style="color: #ee8133;">

                    <div class="navbar-end" style="color: white;">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/PanelAdministrativo.aspx">Panel de administración
                        </a>
                    </div>
                    <div class="navbar-end">
                          <a class="navbar-link" style="color:#ee8133;" href="../Pages/tendencias.aspx">Tendencias
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/Solicitudes.aspx">Solicitudes
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/ConfiguracionRoles.aspx">Configuracion Roles
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/GraficoIndicadores.aspx">Gráficos
                        </a>
                    </div>
                </div>
            </nav>
        </div>
        <br />
        <br />
        <br />

        <div class="row4" style="text-align:center">
        <div class="side4" style="z-index: 101;text-align:center ">
    

      <div class="cardtendencias1" style="text-align:center;color:white;font-weight: bold;">
      <div class="card-content" style="text-align:center">
              <div>
                  
                  <h1 style="text-align: center;color:#061738;font-size:50px"> Solicitudes de Créditos </h1>
                  <h1 style="font-size:15px; color:transparent">__________________ ___________________ _________________ _____________ _______________ ____________   ____________ ______________ ____________ ____________  ____________   ____________ </h1>
                  <h4 style="text-align: center;color:#061738;font-size:20px"> Importante: Recordar que las solicitudes se muestran de las más antiguas a las más recientes. </h4>                  
                  <br />

                                 
              </div>

                <div class="card-content" style="text-align:center; padding-left:25px;padding-right:25px;background-color:#061738;border-radius: 15px;">

                  <h2 style="text-align: center;color:white;font-size:25px"> Filtros </h2>

                  <p style="display:inline;text-align:center">
                     
                   <p style="color:#ee8133; text-align:center;margin-left:3%; margin-right:2%"> 

                       
                    <asp:DropDownList ID="ddlTipoPrestamo" runat="server" CssClass="ddl" OnSelectedIndexChanged="ddlTipoPrestamo_SelectedIndexChanged" OnTextChanged="ddlTipoPrestamo_SelectedIndexChanged">
                                <asp:ListItem>--Selecciona un préstamo--</asp:ListItem>
                                <asp:ListItem Text="Personal" Value="2"></asp:ListItem>
                                <asp:ListItem Text="Vivienda" Value="6"></asp:ListItem>
                                <asp:ListItem Text="Salud" Value="5"></asp:ListItem>
                                <asp:ListItem Text="Vehicilo" Value="7"></asp:ListItem>
                     </asp:DropDownList>
                <p style="display:inline;color:#ee8133; text-align:center;">
                    <asp:LinkButton  runat="server" class="button is-info is-outlined" style="width: 220px; height: auto;" OnClick="Unnamed1_Click">
                        <span class="icon is-small">
                            <span class="material-icons">search</span>
                           
                        </span>
                    </asp:LinkButton>
                   
                    
                        
              </p></p> 
       </div>  
    </div>
   </div>

 </div>
             </div>

            <!-- Fin tarjeta 1 -->

                    

                   <!-- Inicio tabla -->

       
         <div class="row" style="text-align:center">
        <div class="side" style="z-index: 101;text-align:center ">
    
        <div style="width: 90%; text-align:center; align-items:center;  margin-left: auto; margin-right:auto; font-size: 15px">
        <asp:Table ID="tablesolicitudes" runat="server" CssClass="table is-striped" ForeColor="black" HorizontalAlign="Center" Width="100%">
            <asp:TableHeaderRow ID="Table1HeaderRow" Style="color: white;" CssClass="CabezaTabla"
                ForeColor="black"
                BackColor="#061738"
                runat="server">
                <asp:TableHeaderCell
                    Scope="Column"
                    Text="Num Solicitud" />
                <asp:TableHeaderCell
                    Scope="Column"
                    Text="Identificación" />
                <asp:TableHeaderCell
                    Scope="Column"
                    Text="Teléfono" />
                <asp:TableHeaderCell
                    Scope="Column"
                    Text="Moneda" />
                <asp:TableHeaderCell
                    Scope="Column"
                    Text="Monto Solicitado" />
                <asp:TableHeaderCell
                    Scope="Column"
                    Text="Plazo" />
                <asp:TableHeaderCell
                    Scope="Column"
                    Text="Código préstamo" />
            </asp:TableHeaderRow>              

        </asp:Table>
        
    </div>

   </div>
 </div>

                      <!-- Fin tabla -->

                      <!-- Fin tabla -->
        
            <div class="row4" style="text-align:center; height: auto;">
        <div class="side4" style="z-index: 101;text-align:center ">
    

      <div class="cardtendencias1" style="text-align:center;color:white;font-weight: bold;">
      <div class="card-content" style="text-align:center">
              <div>
                                 
                
                                             
                  <br />
                 
                  <div class="card-content" style="text-align:center; padding-left:25px;padding-right:25px">


                  <p style="text-align:center">
                     
                   <p style="color:#061738; text-align:center;"> 
                       
                       <asp:TextBox runat="server" class="input is-info" type="text" style="width:30%; height:auto" placeholder="Número de solicitud" id="txtnumsoli"/> 
                    <p style="color:#ee8133; text-align:center;margin-left:3%; margin-right:2%"> 

                       

                   <asp:Button runat="server" class="button is-info is-outlined" ID="btntramitar" style="width: 30%; height: auto;" Text="Tramitar" OnClick="btntramitar_Click"
                        />
                        <br />
                        <br />
                          <asp:Label class="message-header" style="width:90%; height: auto; background-color:#F46363; text-align:center; font-size: 15px;margin-left:5%;margin-right:5%;" ID="lblerror" runat="server"></asp:Label>
 

                        
              </p>
                      
              </div>
                   <h1 style="font-size:15px; color:transparent">__________________ ___________________ _________________ _____________ _______________ ____________   ____________ ______________ ____________ ____________  ____________   ____________ </h1>
                  
         </div>
       </div>  
    </div>
   </div>
 </div>

            <!-- Fin tarjeta 2 -->




                        <!-- Footer -->
          <footer class="footer1" style="width:95%;height:auto">
          <div class="content has-text-centered">
              <div>               
                  <p style="text-align: center;font-size:10px;float:left"> 
                  <p class="p1" style="display:inline"> <img style="width:20px;height:auto;display:inline" src="../img/c.png"/> 2020Banco NAV. Todos los derechos reservados.</p>
                  <p class="p1" style="display:inline"> <img style="width:20px;height:auto;display:inline" src="../img/correo.png"/> Contáctenos: bancona@gmail.com </p>
                  <p class="p1" style="display:inline"> <img style="width:20px;height:auto;display:inline" src="../img/tel.png"/> Teléfono: 2211-1135</p>
                  <p/> 
              </div>         
          </div>
        </footer>
    </form>
</body>
</html>
