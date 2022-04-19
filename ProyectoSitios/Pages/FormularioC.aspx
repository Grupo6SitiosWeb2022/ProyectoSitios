﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormularioC.aspx.cs" Inherits="ProyectoSitios.Pages.FormularioC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Banco NAV</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.1/css/bulma.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Syne+Mono&display=swap" rel="stylesheet" />
    <script src="https://use.fontawesome.com/releases/v5.1.0/js/all.js"></script>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Josefin+Sans:wght@500&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link href="../css/bulma1.css" rel="stylesheet" />

</head>

<body>
    <form id="form1" runat="server">
        <div>
            <button class="buttonmenu" style="background-color: transparent;" type="button" onclick="location.href='https://www.facebook.com'">
                <img style="width: 10%; left: 25px; top: 380px; position: absolute; z-index: 101; display: flex; margin-top: 4px;" src="../img/icono.png">
                <img style="width: 20%; left: 0px; top: 390px; position: absolute; z-index: 99; display: flex;" src="../img/hexagono.png">
            </button>



            <div class="demo_wrap">
                <img src="../img/Mascara.jpg">
                <img class="azul" src="../img/fondo_requisitos1.png">
            </div>
        </div>

        <br>
        <br>
        <br>
        <br />
        <br>
        <br>

        <div>

            <br>
            <br>
            <br>
            <nav class="navbar" style="z-index: 100; top: 95px" role="navigation" aria-label="dropdown navigation">
                <div class="navbar-menu">
                    <div class="navbar-end">
                        <a class="navbar-link" href="../Pages/PrestamoPersonal.aspx">Préstamo personal
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" href="../Pages/PrestamoPyme.aspx">Préstamo pymes
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" href="../Pages/PrestamosCoorporativos.aspx">Préstamo corporativa
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" href="../Pages/CalcularPrestamos.aspx">Calculadora
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" href="../Pages/login.aspx">Iniciar Sesión
                        </a>
                    </div>
                </div>
            </nav>
        </div>

        <br />
        <div style="font-size: medium; color: blue;">
            <br />
            <br />
            <br />


        </div>

        <div class="row" style="text-align: center">
            <div class="side" style="z-index: 101;">



                <div class="cardVerticaV" style="display: block; color: white; font-weight: bold;">

                    <div style="margin-left: 40px; display: flex;">
                        <div style="padding: 10px; float: left; width: 45%; text-align: justify;">
                            <br />

                            <asp:Label ID="lblTipoI" runat="server" Text="">Tipo de identificación</asp:Label>
                            <br />

                            <asp:DropDownList ID="ddlTiposIdentificacion" runat="server" CssClass="select.is-info select">
                                <asp:ListItem>--Selecciona un tipo de Identificación--</asp:ListItem>
                                <asp:ListItem Value="1">Nacional</asp:ListItem>
                                <asp:ListItem Value="2">Extranjero</asp:ListItem>
                                <asp:ListItem Value="3">Dimex</asp:ListItem>
                                <asp:ListItem Value="4">Pasaporte</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Label ID="lblIdentificacion" runat="server" Text="">Identificación</asp:Label>
                            <br />

                            <asp:TextBox ID="txtIdetificacion" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="lblNombreC" runat="server" Text="">Nombre completo</asp:Label>
                            <br />

                            <asp:TextBox ID="txtNombreC" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="lblCorreo" runat="server" Text="">Correo Electrónico</asp:Label>
                            <br />

                            <asp:TextBox ID="txtcorreo" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="lblTelefono" runat="server" Text="">Teléfono</asp:Label>
                            <br />

                            <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                            <br />
                            <br />
                        </div>
                        <div style="padding: 10px; float: right; width: 45%; text-align: justify;">
                            <br />
                            <asp:Label ID="lblTMoneda" runat="server" Text="Tipo de Moneda"></asp:Label>
                            <br />

                            <asp:DropDownList ID="ddlTipoMoneda" runat="server" CssClass="select.is-info select">
                                <asp:ListItem>--Selecciona un tipo de Mondeda--</asp:ListItem>
                                <asp:ListItem Value="1">Dolares</asp:ListItem>
                                <asp:ListItem Value="2">Colones</asp:ListItem>
                            </asp:DropDownList>
                            <br />
                            <br />
                            <asp:Label ID="lblDireccion" runat="server" Text="">Dirección</asp:Label>
                            <br />

                            <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="lblMonto" runat="server" Text="">Monto</asp:Label>
                            <br />

                            <asp:TextBox ID="txtMonto" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="lblPlazo" runat="server" Text="">Plazo</asp:Label>
                            <br />
                            <asp:TextBox ID="txtPlazo" runat="server"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="lblSalario" runat="server" Text="">Salario neto</asp:Label>
                            <br />
                            <asp:TextBox ID="txtSalario" runat="server"></asp:TextBox>
                            <br />
                            <br />
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                    </div>
                    <asp:Button ID="btnFormulario" runat="server" Text="Enviar solicitud" class="button is-info is-outlined" Style="width: 200px;" OnClick="btnFormulario_Click" />

                </div>

            </div>

            <div class="main">
                <br />
                <br />
                <div>
                    <div id="conteItemsCarrusel">
                        <div class="itemCarrusel" id="ItemC-1">
                            <div class="flechasC">
                                <a href="#ItemC-4">
                                    <i class='fas fa-angle-left' style='font-size: 48px; color: #ee8133'></i>
                                </a>
                                <a href="#ItemC-2">
                                    <i class='fas fa-angle-right' style='font-size: 48px; color: #ee8133'></i>
                                </a>
                            </div>
                            <div class="tarjetasC" id="tarjetasC-1">
                                <div>
                                    <div class="tarjeta">
                                        <img src="../img/5.png" />
                                        <div class="descripcion">
                                            <br />
                                            <h1>Prestamo personal</h1>
                                            <br />
                                            <p>
                                                Solicita tu prestamo personal y hacé realidad todos los planes que has estado posponiendo tus sueños, metas y proyectos.
                                            </p>

                                            <div class="TarjetaBTN">
                                                <button class="button is-info is-outlined" style="width: 130px; height: 30px;">
                                                    <a class="enlace" href="../Pages/FormularioC.aspx">Solicitar</a>
                                                </button>
                                                <button class="button is-info is-outlined" style="width: 110px; height: 30px;">
                                                    <span class="icon is-small">
                                                        <span class="material-icons">add</span>



                                                        <a class="enlace" href="../Pages/prestamos.aspx">Ver más</a>
                                                    </span>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>




                        </div>
                        <div class="itemCarrusel" id="ItemC-2">
                            <div class="tarjetasC" id="tarjetasC-2">
                                <div class="flechasC">
                                    <a href="#ItemC-1">
                                        <i class='fas fa-angle-left' style='font-size: 48px; color: #ee8133'></i>
                                    </a>
                                    <a href="#ItemC-3">
                                        <i class='fas fa-angle-right' style='font-size: 48px; color: #ee8133'></i>
                                    </a>

                                </div>
                                <div>
                                    <div class="tarjeta">
                                        <img src="../img/2.png" />
                                        <div>
                                            <br />
                                            <h1>Prestamo vehicular</h1>
                                            <br />
                                            <div>
                                                <p>
                                                    Te ofrecemos tasas competitivas y rápidos tiempos de respuesta 
                        para comprar tu carro nuevo, seminuevo y usado;con opciones 
                        leasing y crédito prendario.
                                                </p>
                                            </div>
                                            <div class="TarjetaBTN">
                                                <button class="button is-info is-outlined" style="width: 130px; height: 30px;">
                                                    <a class="enlace" href="../Pages/FormularioC.aspx">Solicitar</a>
                                                </button>
                                                <button class="button is-info is-outlined" style="width: 110px; height: 30px;">
                                                    <span class="icon is-small">
                                                        <span class="material-icons">add</span>



                                                        <a class="enlace" href="../Pages/PrestamosVehiculo.aspx">Ver más</a>
                                                    </span>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>


                        </div>
                        <div class="itemCarrusel" id="ItemC-3">
                            <div class="tarjetasC" id="tarjetasC-3">
                                <div class="flechasC">
                                    <a href="#ItemC-2">
                                        <i class='fas fa-angle-left' style='font-size: 48px; color: #ee8133'></i>
                                    </a>
                                    <a href="#ItemC-4">
                                        <i class='fas fa-angle-right' style='font-size: 48px; color: #ee8133'></i>
                                    </a>

                                </div>
                                <div>
                                    <div class="tarjeta">
                                        <img src="../img/4.jpg" />
                                        <div>
                                            <br />
                                            <h1>Prestamo Vivienda</h1>
                                            <br />
                                            <div>
                                                <p>
                                                    Te ofrecemos una solución ágil de financiamiento para 
                                                    que estrenés en menor tiempo tu nuevo hogar.
                                                </p>
                                            </div>
                                            <div class="TarjetaBTN">
                                                <button class="button is-info is-outlined" style="width: 130px; height: 30px;">
                                                    <a class="enlace" href="../Pages/FormularioC.aspx">Solicitar</a>
                                                </button>
                                                <button class="button is-info is-outlined" style="width: 110px; height: 30px;">
                                                    <span class="icon is-small">
                                                        <span class="material-icons">add</span>
                                                        <a class="enlace" href="../Pages/PrestamosVivienda.aspx">Ver más</a>
                                                    </span>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="itemCarrusel" id="ItemC-4">
                            <div class="tarjetasC" id="tarjetasC-4">
                                <div class="flechasC">
                                    <a href="#ItemC-3">
                                        <i class='fas fa-angle-left' style='font-size: 48px; color: #ee8133'></i>
                                    </a>
                                    <a href="#ItemC-1">
                                        <i class='fas fa-angle-right' style='font-size: 48px; color: #ee8133'></i>
                                    </a>

                                </div>
                                <div>
                                    <div class="tarjeta">
                                        <img src="../img/1.png" />
                                        <div>
                                            <br />
                                            <h1>Prestamo de Salud</h1>
                                            <br />
                                            <div>
                                                <p>
                                                    Es hora de pasar de los dichos a los hechos y ponerle fecha y hora a ese momento, 
                                              para lograr sanar lo que te molesta hace tiempo o solucionar ese imprevisto que 
                                              te haya generado un gasto por hospitalización.
                                                </p>
                                            </div>
                                            <div class="TarjetaBTN">
                                                <button class="button is-info is-outlined" style="width: 130px; height: 30px;">
                                                    <a class="enlace" href="../Pages/FormularioC.aspx">Solicitar</a>
                                                </button>
                                                <button class="button is-info is-outlined" style="width: 110px; height: 30px;">
                                                    <span class="icon is-small">
                                                        <span class="material-icons">add</span>



                                                        <a class="enlace" href="../Pages/PrestamosSalud.aspx">Ver más</a>
                                                    </span>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div style="padding-top: 250px">
                    <div class="tarjetasC" id="tarjetasC-5">
                        <div class="tarjeta">
                            <div>
                                <br />
                                <br />
                                <br />
                                <br />
                                <div>
                                    <p>
                                        ¡Le tenemos las respuestas a 
                                                todas sus preguntas!
                                                ¿Cuánto será lo que debe pagar mensualmente? 
                                                ¿A qué plazos? ¿Cuáles son nuestras tasas de interés?
                                    </p>
                                </div>
                                <div class="TarjetaBTN">
                                    <button class="button is-info is-outlined" style="width: 180px; height: 40px;">
                                        <a class="enlace" href="../Pages/CalcularPrestamos.aspx">Calcular cuota aquí </a>
                                    </button>
                                </div>
                            </div>
                            <img src="../img/30.png" />
                        </div>

                    </div>
                </div>




            </div>

        </div>
        <br />
        </div>
          </div>
            

        <!-- Footer -->
        <!-- Footer -->
        <footer class="footer">
            <div class="content has-text-centered">
                <div>

                    <p style="font-size: 10px;">
                        <p class="p1" style="display: inline">
                            <img style="width: 20px; height: auto; display: inline" src="../img/c.png" />
                            2020Banco NAV. Todos los derechos reservados.
                        </p>
                        <p class="p1" style="display: inline">
                            <img style="width: 20px; height: auto; display: inline" src="../img/correo.png" />
                            Contáctenos: bancona@gmail.com
                        </p>
                        <p class="p1" style="display: inline">
                            <img style="width: 20px; height: auto; display: inline" src="../img/tel.png" />
                            Teléfono: 2211-1135
                        </p>
                        <p />
                </div>

            </div>
        </footer>


    </form>
</body>
</html>

