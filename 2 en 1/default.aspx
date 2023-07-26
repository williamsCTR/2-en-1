<%@ Page Title="" Language="C#" MasterPageFile="~/miMaster.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="_2_en_1._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<section class="contenedor row defauld">
        <h1 class="centrar pt-3">Calculadora y Convertidor de unidades</h1>
            <%------- CALCULADORA -------%>
    <%------- SECTION CALCULADORA -------%>
    <section class="containerCalculadora col-sm-12 col-md-12 col-lg-6 col-xl-6 pt-5">
        <%------- CONTENEDOR DE TODA LA CALCULADORA -------%>
        <div class="calculadora gap-2 p-5 card text-bg-dark">
            <%-------CONTENEDOR DE LAS PANTALLAS SECUNDARIA DONDE SE VAN MOSTRANDO LOS NUMEROS INGRESADOS Y LA OPERACION -------%>
            <div class="containerPantallaSecundaria row centrar">
                <div class="col-5">
                    <asp:TextBox ID="txtPantallaSecundariaNumero1" CssClass="form-control" Enabled="false" runat="server" Text="0"></asp:TextBox>
                </div>
                <div class="col-2">
                    <asp:Label ID="lblPantallaSecundariaOperador" runat="server" CssClass="col-form-label" Text="+" Font-Size="Larger"></asp:Label>
                </div>
                <div class="col-5">
                    <asp:TextBox ID="txtPantallaSecundariaNumero2" CssClass="form-control" Enabled="false" runat="server" Text="0"></asp:TextBox>
                </div>
            </div>
            <%------- CONTENEDOR DE LA PANTALLA PRINCIPAL DONDE SE MUESTRA EL RESULTADO Y EL ULTIMO NUMERO QUE SE ESTA INGRESANDO -------%>
            <div class="containerPantalla">
                <asp:TextBox ID="txtPantalla" CssClass="form-control p-3" Enabled="false" Text="0" runat="server"></asp:TextBox>
            </div>
            <%------- CONTENEDOR DE TODOS LOS BOTONES DE LA CALCULADORA -------%>
            <div class="containerBotones row row-cols-4">
                <asp:Button ID="btnC" CssClass="btn btn-dark boton" runat="server" Text="C" OnClick="btnC_Click" />
                <asp:Button ID="btnCE" CssClass="btn btn-dark boton" runat="server" Text="CE" OnClick="btnCE_Click" />
                <asp:Button ID="btnBorrar" CssClass="btn btn-dark boton" runat="server" Text="←" OnClick="btnBorrar_Click" />
                <asp:Button ID="btnDividir" CssClass="btn btn-dark boton" runat="server" Text="÷" OnClick="btnDividir_Click" />
                <asp:Button ID="btnSiete" CssClass="btn btn-dark boton mt-1" runat="server" Text="7" OnClick="btnSiete_Click" />
                <asp:Button ID="btnOcho" CssClass="btn btn-dark boton mt-1" runat="server" Text="8" OnClick="btnOcho_Click" />
                <asp:Button ID="btnNueve" CssClass="btn btn-dark boton mt-1" runat="server" Text="9" OnClick="btnNueve_Click" />
                <asp:Button ID="btnMultiplicar" CssClass="btn btn-dark boton mt-1" runat="server" Text="×" OnClick="btnMultiplicar_Click" />
                <asp:Button ID="btnCuatro" CssClass="btn btn-dark boton mt-1" runat="server" Text="4" OnClick="btnCuatro_Click" />
                <asp:Button ID="btnCinco" CssClass="btn btn-dark boton mt-1" runat="server" Text="5" OnClick="btnCinco_Click" />
                <asp:Button ID="btnSeis" CssClass="btn btn-dark boton mt-1" runat="server" Text="6" OnClick="btnSeis_Click" />
                <asp:Button ID="btnResta" CssClass="btn btn-dark boton mt-1" runat="server" Text="-" OnClick="btnResta_Click" />
                <asp:Button ID="btnUno" CssClass="btn btn-dark boton mt-1" runat="server" Text="1" OnClick="btnUno_Click" />
                <asp:Button ID="btnDos" CssClass="btn btn-dark boton mt-1" runat="server" Text="2" OnClick="btnDos_Click" />
                <asp:Button ID="btnTres" CssClass="btn btn-dark boton mt-1" runat="server" Text="3" OnClick="btnTres_Click" />
                <asp:Button ID="btnSuma" CssClass="btn btn-dark boton mt-1" runat="server" Text="+" OnClick="btnSuma_Click" />
                <asp:Button ID="btnDobleCero" CssClass="btn btn-dark boton mt-1" runat="server" Text="00" OnClick="btnDobleCero_Click" />
                <asp:Button ID="btnCero" CssClass="btn btn-dark boton mt-1" runat="server" Text="0" OnClick="btnCero_Click" />
                <asp:Button ID="btnComa" CssClass="btn btn-dark boton mt-1" runat="server" Text="," OnClick="btnComa_Click" />
                <asp:Button ID="btnIgual" CssClass="btn btn-dark boton mt-1" runat="server" Text="=" OnClick="btnIgual_Click" />
            </div>
        </div>
    </section>
    <%--------------------------------------------------------------------------------%>
    <%------- SECTION DEL CONVERTIDOR DE UNIDADES -------%>
    <section class="container__convertidor col-sm-12 col-md-12 col-lg-6 col-xl-6 pt-5">
        <div class="card text-bg-dark">
            <div class="card-body">
                <h5 class="card-title">Valor a convertir: </h5>
                <asp:TextBox ID="txtNumero" class="form-control" Text="0" runat="server"></asp:TextBox>
                <h5 class="card-title">Unidad:</h5>
                <asp:DropDownList ID="ddlUnidades" CssClass="form-control" runat="server"></asp:DropDownList>
                <hr>
                <h5 class="card-title">Convertir a:</h5>
                <asp:DropDownList ID="ddlUnidadesA" CssClass="form-control" runat="server"></asp:DropDownList>
                <hr>
                <h5 class="card-title">Resultado:</h5>
                <asp:Label ID="lblResultado" class="form-control" runat="server" Text="Esperando datos..."></asp:Label>
                <asp:Button ID="btnCalcular" class="btn btn-dark" runat="server" Text="Calcular" OnClick="btnCalcular_Click" />
            </div>
        </div>
    </section>
</section>
</asp:Content>
