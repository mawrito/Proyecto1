using System;
using System.Web.UI;

namespace PL
{
    public partial class Cine : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Imprimir(object sender, EventArgs e)
        {
            var htmlContent = String.Format("<body>Tiquete de Cine: {0}</body>",
         DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            htmlToPdf.GeneratePdfFromFile("Ticket.html/", null, "export.pdf");
        }
    }
}