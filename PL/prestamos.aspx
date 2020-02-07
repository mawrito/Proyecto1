<%@ Page Title="Prestamos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="prestamos.aspx.cs" Inherits="PL._Default" EnableEventValidation="false" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
       <!--HEADER START-->
        <div class="container" id:"target">
            <h3 id="mainTitle" runat="server">Calculadora de Préstamos</h3>
            <p class="cta-sub-title"  id="subTitle" runat="server" style="display:none">Generador de plan de cuotas</p>
        <h1 id="headOne" runat="server" style="display:none">Cuota fija & Tasa constante</h1>
        </div>
        <!--HEADER END-->

        <!--INPUT START-->
        <div class="jumbotron">
                <h6 style="font-size:large">Por favor llene los campos Prestamo, Interes y Plazo y presione calcular para obtener su plan de cuotas.</h6>
                <br />
                <div class="row-cols-1">
                    <input type="text" runat="server" class="col" onkeypress="return isNumber(event)" style="text-align: center; font-size: large; max-width: 50%; border-radius: 6px" id="mtopress" placeholder="monto"/>
                </div>
                <br />
                <div class="row-cols-1">
                    <input type="text" runat="server" class="col" onkeypress="return isNumber(event)" style="text-align: center; font-size: large; max-width: 50%; border-radius: 6px" id="intereses" placeholder="interes"/>
                </div>
                <br />
                <div class="row-cols-1">
                    <input type="text" runat="server" class="col" onkeypress="return isNumber(event)" style="text-align: center; font-size: large; max-width: 50%; border-radius: 6px" id="plazo" placeholder="plazo" />
                </div>
                <br />
                <div class="row-cols-1">
                    <input type="button" value="Calcular" runat="server" class="btn btn-primary btn-lg" onserverclick="calcular_Click" style="width: 50%;font-size: large" id="calcular"/>
                </div>
                <br />
                <div class="row-cols-1">
                    <input type="text" runat="server" class="col" style="background-color:#282828;border:none; color:white;text-align: center; font-size: large; max-width: 50%; border-radius: 6px" id="cuota" placeholder="cuota a pagar"/>
                </div>
        </div>
        <!--INPUT END-->

        <!--HEADER START-->
        <div class="container">
            <h3 class="cta-title" id="tituloReporte" runat="server">Plan de Cuotas</h3>
        </div>
        <!--HEADER END-->

        <!--PAYMENTS-->
        <div class="jumbotron">
                <div >
                    <asp:GridView runat="server" class="table" style="font-size:large; background-color:black" id="GridView1">
                    </asp:GridView>
                    <br />
                    <asp:Button runat="server" class="btn btn-primary btn-lg" style="width: 50%;font-size: large" id="Button1" text="Exportar a Excel" onclick="exportarExcel_Click" />
                    <br />  
                    <br />
                    <asp:Button runat="server" class="btn btn-primary btn-lg" style="width: 50%;font-size: large" id="Button2" text="Exportar a Word" onclick="exportarWord_Click" />

                </div>
        </div>
        <!--PAYMENTS END-->
</asp:Content>
