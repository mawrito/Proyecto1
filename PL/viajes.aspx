<%@ Page Title="Viajes" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="viajes.aspx.cs" Inherits="PL.Viajes" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!--START HEADER-->
    <div class="container">
        <h3>Agencia de Viajes</h3>
    </div>
    <!--END HEADER-->

    <!--START INPUT-->
    <div class="jumbotron">
        <div class="row-cols-1">
            <input  type="text"  value="Origen:" style="display: inline-block; background-color: #282828; border: none; color: white; text-align: center; font-size: large; width: 25%; border-radius: 6px" />
            <div class="form-group" style="display: inline-block;">
                <select id="origen" runat="server" class="custom-select" style="text-align: center; font-size: large">
                    <option selected="">eliga un punto de salida</option>
                    <option value="Alajuela">Alajuela</option>
                    <option value="Liberia">Liberia</option>
                    <option value="Tibas">Tibas</option>
                </select>
            </div>
            <input type="text"  value="Destino:" style="display: inline-block; background-color: #282828; border: none; color: white; text-align: center; font-size: large; width: 25%; border-radius: 6px" />
            <div class="form-group" style="display: inline-block;">
                <select id="destino" runat="server" class="custom-select" style="text-align: center; font-size: large;width:250px">
                    <option selected="">eliga un destino</option>
                    <option value="Cancun">Cancun</option>
                    <option value="New York">New York</option>
                    <option value="Cairo">Cairo</option>
                    <option value="Bahamas">Bahamas</option>
                    <option value="Galapagos">Galapagos</option>
                </select>
            </div>
        </div>
        <div class="row-cols-1">
            <input type="text" value="Salida:" style="display: inline-block; background-color: #282828; border: none; color: white; text-align: center; font-size: large; width: 25%; border-radius: 6px" />
            <div class="form-group" style="display: inline-block;">
                <input type="date" id="salida"  runat="server"  name="trip-start"   style="text-align: center; font-size: large; border-radius: 6px;height:40px">
            </div>
            <input type="text" value="Regreso:" style="display: inline-block; background-color: #282828; border: none; color: white; text-align: center; font-size: large; width: 25%; border-radius: 6px" />
            <div class="form-group" style="display: inline-block;">
                <input type="date" id="regreso" runat="server" name="trip-end"  style="text-align: center; font-size: large; border-radius: 6px;height:40px">
            </div>
        </div>

        <div class="row-cols-1">
            <input id="validate" type="button" runat="server" value="Comprar" class="btn btn-primary btn-lg" onserverclick="Comprar" style="width: 60%; font-size: large" />
        </div>
    </div>
    <!--END INPUT-->

    <!--START SLIDER-->
    <div class="w3-content w3-display-container" style="max-width: 1200px">
        <img class="mySlides" src="assets/images/d1.jpg" style="width: 100%" />
        <img class="mySlides" src="assets/images/d2.jpg" style="width: 100%" />
        <img class="mySlides" src="assets/images/d3.jpg" style="width: 100%" />
        <img class="mySlides" src="assets/images/d4.jpg" style="width: 100%" />
        <img class="mySlides" src="assets/images/d5.jpg" style="width: 100%" />

    </div>
    <!--END SLIDER-->

    <script type="text/javascript">
        var myIndex = 0;
        carousel();

        function carousel() {
            var i;
            var x = document.getElementsByClassName("mySlides");
            for (i = 0; i < x.length; i++) {
                x[i].style.display = "none";
            }
            myIndex++;
            if (myIndex > x.length) { myIndex = 1 }
            x[myIndex - 1].style.display = "block";
            setTimeout(carousel, 2000);
        }
    </script>
</asp:Content>





