using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Viaje;
using BLL.Palindromo;
using System.Web.Services;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System.Diagnostics;

namespace PL
{
    public partial class Viajes : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Comprar(object sender, EventArgs e)
        {
            cls_Viaje_DAL viaje = new cls_Viaje_DAL();
        }


        protected void Imprimir(object sender, EventArgs e)
        {
            Document document = new Document();

            Section section = document.AddSection();
            section.AddParagraph("Hello, World!");
            section.AddParagraph();

            Paragraph paragraph = section.AddParagraph();
            paragraph.Format.Font.Color = Color.FromCmyk(100, 30, 20, 50);
            paragraph.AddFormattedText("Hello, World!", TextFormat.Underline);

            FormattedText ft = paragraph.AddFormattedText("Small text", TextFormat.Bold);
            ft.Font.Size = 6;
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false,PdfFontEmbedding.Always);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();
            string filename = "../../users/marich/desktop/HelloWorld.pdf";
            pdfRenderer.PdfDocument.Save(filename);
            

        }
    }
}