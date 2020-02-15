using DAL.Viaje;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using PdfSharp.Pdf;
using System;
using System.Web.UI;


namespace PL
{
    public partial class Viajes : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Comprar(object sender, EventArgs e)
        {
            Nuevo();
        }

        protected void Nuevo()
        {
            cls_Viaje_DAL viaje = new cls_Viaje_DAL();
            viaje.Origen = origen.Value;
            viaje.Destino = destino.Value;
            viaje.Salida = Convert.ToDateTime(salida.Value);
            viaje.Regreso = Convert.ToDateTime(regreso.Value);
            viaje.Nombre = "Mario Alberto";
            viaje.Apellido = "Chaves Solano";
            viaje.Asiento = 25;
            viaje.Clase = 2;

            Imprimir(viaje);
        }
        protected void Imprimir(cls_Viaje_DAL viaje)
        {
            Document document = new Document();
            Section section = document.AddSection();
            
            section.AddImage("C:/Users/marich/source/repos/Tarea III/PL/assets/images/top.jpg");
            section.AddParagraph("");

            section.AddParagraph("DATOS DEL VIAJERO", "Bold");
            section.AddParagraph("");
            section.AddParagraph("NOMBRE COMPLETO: "+viaje.Nombre+" "+viaje.Apellido);
            section.AddParagraph("ASIENTO: " + viaje.Asiento + "CLASE: " + viaje.Clase + " Economica");
            section.AddParagraph("");
            section.AddParagraph("");
            
            section.AddParagraph("DATOS DEL VIAJE","Bold");
            section.AddParagraph("");
            section.AddParagraph("ORIGEN: "+viaje.Origen+"           DESTINO: "+viaje.Destino);
            section.AddParagraph("SALIDA: "+viaje.Salida+"           REGRESO: "+viaje.Regreso);

            section.AddParagraph("");
            section.AddImage("C:/Users/marich/source/repos/Tarea III/PL/assets/images/top.jpg");
            
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer(false, PdfFontEmbedding.Always);
            pdfRenderer.Document = document;
            pdfRenderer.RenderDocument();
            string filename = "../../users/marich/desktop/HelloWorld.pdf";
            pdfRenderer.PdfDocument.Save(filename);
            


        }
    }
}