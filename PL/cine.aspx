<%@ Page Title="Cine" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cine.aspx.cs" Inherits="PL.Cine" %>

<%@ Import Namespace="System.Net.Mail" %>
<%@ Import Namespace="System.IO" %>
<%@ Import Namespace="NReco.PdfGenerator" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <script runat="server" language="c#">
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Request.HttpMethod == "POST" && Request["action"] == "generate_pdf")
            {
                var htmlToPdf = new HtmlToPdfConverter();

                Response.ContentType = "application/pdf";
                if (!String.IsNullOrEmpty(Request["htmlUrl"]))
                {
                    htmlToPdf.GeneratePdfFromFile(Request["htmlUrl"], null, Response.OutputStream);
                }
                else
                {
                    htmlToPdf.GeneratePdf(Request["htmlContent"], null, Response.OutputStream);
                }
                Response.End();
            }
        }
    </script>



    <!--HEADER START-->
    <div class="container">
        <h2>CineMario</h2>
    </div>
    <!--HEADER END-->
     <form action="<%=Request.Url.ToString() %>" target="_blank" method="post">
                    <input type="hidden" name="action" value="generate_pdf" />
                    <input type="text" class="form-control" value="https://localhost:44301/ticket2.html" name="htmlUrl" style="width: 100%; display: none" />
                    
                </form>
    <!--INPUT START-->
    


    <h3>Cartelera</h3>
    <br />
    <div class="row-cols-3">
        <div class="card border-dark mb-3" style="max-width: 20rem; display: inline-block">
            <div class="card-header">Sala 1</div>
            <div class="card-body">
                <img src="assets/images/jocker.jpg" style="width: 150px; height: 200px" />
                <h4 class="card-title">Jocker</h4>
                <p class="card-text">Mayores de 18 años - Hora: 17:00-19:30 Idioma Igles Subtitulada</p>
                <form action="<%=Request.Url.ToString() %>" target="_blank" method="post">
                    <input type="hidden" name="action" value="generate_pdf" />
                    <input type="text" class="form-control" value="https://p1p4.azurewebsites.net/ticket1.html" name="htmlUrl" style="width: 100%; display: none" />
                    <button type="submit" class="btn btn-primary btn-info generatePdf">Comprar</button>
                </form>
            </div>
        </div>

        <div class="card border-dark mb-3" style="max-width: 20rem; display: inline-block">
            <div class="card-header">Sala 2</div>
            <div class="card-body">
                <img src="assets/images/logan.jpg" style="width: 150px; height: 200px" />
                <h4 class="card-title">Logan</h4>
                <p class="card-text">Mayores de 18 años - Hora: 18:00-20:00 Idioma Igles Subtitulada</p>
                <form action="<%=Request.Url.ToString() %>" target="_blank" method="post">
                    <input type="hidden" name="action" value="generate_pdf" />
                    <input type="text" class="form-control" value="https://p1p4.azurewebsites.net/ticket2.html" name="htmlUrl" style="width: 100%; display: none" />
                    <button type="submit" class="btn btn-primary btn-info generatePdf">Comprar</button>
                </form>
            </div>
        </div>

        <div class="card border-dark mb-3" style="max-width: 20rem; display: inline-block">
            <div class="card-header">Sala 3</div>
            <div class="card-body">
                <img src="assets/images/wick.jpg" style="width: 150px; height: 200px" />
                <h4 class="card-title">John Wick 3</h4>
                <p class="card-text">Mayores de 18 años - Hora: 20:00-22:15 Idioma Igles Subtitulada</p>
                <form action="<%=Request.Url.ToString() %>" target="_blank" method="post">
                    <input type="hidden" name="action" value="generate_pdf" />
                    <input type="text" class="form-control" value="https://p1p4.azurewebsites.net/ticket3.html" name="htmlUrl" style="width: 100%; display: none" />
                    <button type="submit" class="btn btn-primary btn-info generatePdf">Comprar</button>
                </form>
            </div>
        </div>

   
                

        <!--INPUT END-->
</asp:Content>





