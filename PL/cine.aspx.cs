using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Palindromo;
using BLL.Palindromo;
using System.Web.Services;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace PL
{
    public partial class Cine : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Imprimir(object sender, EventArgs e)
        {
            var htmlContent = String.Format("<body>Hello world: {0}</body>",
         DateTime.Now);
            var htmlToPdf = new NReco.PdfGenerator.HtmlToPdfConverter();
            var pdfBytes = htmlToPdf.GeneratePdf(htmlContent);

            htmlToPdf.GeneratePdfFromFile("http://www.google.com/", null, "export.pdf");
        }
    }
}