using BLL.Prestamo;
using DAL.Prestamo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PL
{
    public partial class _Default : Page
    {
        List<cls_Linea_DAL> planPagos = new List<cls_Linea_DAL>();
        List<cls_Linea_DAL> planVacio = new List<cls_Linea_DAL>();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected bool validacion()
        {
            if ((Convert.ToDouble(mtopress.Value)) > 0 && (Convert.ToDouble(intereses.Value)) > 0 && (Convert.ToDouble(plazo.Value)) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void calcular_Click(object sender, EventArgs e)
        {

            try
            {
                if (validacion())
                {
                    cls_Prestamo_DAL prestamo = new cls_Prestamo_DAL();
                    cls_Prestamo_BLL calculo = new cls_Prestamo_BLL();

                    double cuotaMes, abonoIntereses, abonoCapital, nuevoSaldo;

                    prestamo.DMtoPres = Convert.ToDouble(mtopress.Value);
                    prestamo.DTasa = Convert.ToDouble(intereses.Value);
                    prestamo.BPlazo = Convert.ToByte(plazo.Value);

                    calculo.CAlculoPrestamo(ref prestamo);

                    cuota.Value = string.Format("{0:n}", prestamo.DCuota);

                    for (byte i = 1; i <= prestamo.BPlazo; i++)
                    {
                        cls_Linea_DAL linea = new cls_Linea_DAL();

                        cuotaMes = prestamo.DCuota;
                        abonoIntereses = prestamo.DSaldo * (prestamo.DTasa / 100);
                        abonoCapital = cuotaMes - abonoIntereses;
                        nuevoSaldo = prestamo.DSaldo - abonoCapital;
                        prestamo.DSaldo = nuevoSaldo;

                        linea.No = i.ToString();
                        linea.Monto = string.Format("{0:n}", cuotaMes);
                        linea.Intereses = string.Format("{0:n}", abonoIntereses);
                        linea.Capital = string.Format("{0:n}", abonoCapital);
                        linea.Saldo = string.Format("{0:n}", nuevoSaldo);


                        planPagos.Add(linea);

                    }

                    GridView1.DataSource = planPagos;
                    GridView1.DataBind();

                }
                else
                {
                    Response.Write("<script>alert('Error: Por favor verificar que los tres campos estan llenos con numeros enteros positivos unicamente');</script>");
                }
            }
            catch (Exception)
            {

                Response.Write("<script>alert('Error: Por favor verificar que los tres campos estan llenos con numeros enteros positivos unicamente');</script>");
            }


        }

        protected void limpiar_Click(object sender, EventArgs e)
        {
            mtopress.Value = String.Empty;
            intereses.Value = String.Empty;
            plazo.Value = String.Empty;
            cuota.Value = String.Empty;



            GridView1.DataSource = planVacio;
            GridView1.DataBind();
        }
        protected void exportarExcel_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment;filename=Plan_de_Pagos.xls");
            Response.ContentType = "application/excel";

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            GridView1.Style["background-color"] = "white";
            GridView1.Style["font-size"] = "normal";
            GridView1.Style["border-collapse"] = "separate";
            GridView1.Style["border-color"] = "gray";
            GridView1.Style["background-color"] = "white";


            GridView1.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();

        }
        protected void exportarWord_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.AppendHeader("content-disposition", "attachment;filename=Plan_de_Pagos.doc");
            Response.ContentType = "application/word";

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            mainTitle.Style["font-family"] = "Segoe UI";
            subTitle.Style["font-family"] = "Segoe UI";
            subTitle.Style["display"] = "block";
            headOne.Style["font-family"] = "Segoe UI";
            headOne.Style["display"] = "block";
            tituloReporte.Style["font-family"] = "Segoe UI";

            mainTitle.Style["text-align"] = "center";
            subTitle.Style["text-align"] = "center";
            headOne.Style["text-align"] = "center";
            tituloReporte.Style["text-align"] = "center";


            subTitle.Style["font-size"] = "18px";
            headOne.Style["font-size"] = "18px";
            tituloReporte.Style["font-size"] = "22px";

            tituloReporte.Style["color"] = "#e43c5c";


            mainTitle.RenderControl(htmlTextWriter);
            subTitle.RenderControl(htmlTextWriter);
            headOne.RenderControl(htmlTextWriter);
            tituloReporte.RenderControl(htmlTextWriter);


            GridView1.Style["font-size"] = "medium";
            GridView1.Style["table-layout"] = "auto";
            GridView1.Style["width"] = "100%";





            foreach (TableCell tableCell in GridView1.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#e43c5c";
                tableCell.Style["color"] = "#fff";
                tableCell.Style["border"] = "1px solid #e43c5c";
            }
            foreach (GridViewRow gridViewRow in GridView1.Rows)
            {
                gridViewRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
                {
                    gridViewRowTableCell.Style["background-color"] = "#FFFFFF";
                    gridViewRowTableCell.Style["border"] = "1px solid #e43c5c";
                    gridViewRowTableCell.Style["text-align"] = "right";
                }
            }
            GridView1.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();

        }

        protected void exportarPDF_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.ContentType = "application/pdf";
            Response.AppendHeader("content-disposition", "attachment;filename=Plan_de_Pagos.pdf");
            Response.Cache.SetCacheability(HttpCacheability.NoCache);

            StringWriter stringWriter = new StringWriter();
            HtmlTextWriter htmlTextWriter = new HtmlTextWriter(stringWriter);

            mainTitle.Style["font-family"] = "Segoe UI";
            subTitle.Style["font-family"] = "Segoe UI";
            subTitle.Style["display"] = "block";
            headOne.Style["font-family"] = "Segoe UI";
            headOne.Style["display"] = "block";
            tituloReporte.Style["font-family"] = "Segoe UI";

            mainTitle.Style["text-align"] = "center";
            subTitle.Style["text-align"] = "center";
            headOne.Style["text-align"] = "center";
            tituloReporte.Style["text-align"] = "center";


            subTitle.Style["font-size"] = "18px";
            headOne.Style["font-size"] = "18px";
            tituloReporte.Style["font-size"] = "22px";

            tituloReporte.Style["color"] = "#e43c5c";


            mainTitle.RenderControl(htmlTextWriter);
            subTitle.RenderControl(htmlTextWriter);
            headOne.RenderControl(htmlTextWriter);
            tituloReporte.RenderControl(htmlTextWriter);


            GridView1.Style["font-size"] = "medium";
            GridView1.Style["table-layout"] = "auto";
            GridView1.Style["width"] = "100%";

            foreach (TableCell tableCell in GridView1.HeaderRow.Cells)
            {
                tableCell.Style["background-color"] = "#e43c5c";
                tableCell.Style["color"] = "#fff";
                tableCell.Style["border"] = "1px solid #e43c5c";
            }
            foreach (GridViewRow gridViewRow in GridView1.Rows)
            {
                gridViewRow.BackColor = System.Drawing.Color.White;
                foreach (TableCell gridViewRowTableCell in gridViewRow.Cells)
                {
                    gridViewRowTableCell.Style["background-color"] = "#FFFFFF";
                    gridViewRowTableCell.Style["border"] = "1px solid #e43c5c";
                    gridViewRowTableCell.Style["text-align"] = "right";
                }
            }
            GridView1.AllowPaging = false;
            GridView1.DataBind();
            GridView1.RenderControl(htmlTextWriter);
            StringReader stringReader = new StringReader(stringWriter.ToString());
            // Document pdfDoc = new HTMLWorker(pdfDoc);



            GridView1.RenderControl(htmlTextWriter);
            Response.Write(stringWriter.ToString());
            Response.End();

        }

        public override void VerifyRenderingInServerForm(Control control)
        {

        }
    }
}
