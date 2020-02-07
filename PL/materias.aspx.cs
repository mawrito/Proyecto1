using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Palindromo;
using BLL.Palindromo;
using System.Web.Services;
using System.IO;
using ExcelDataReader;
using System.Data;
using System.Web.UI.HtmlControls;

namespace PL
{
    public partial class Materias : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Importar_Click(object sender, EventArgs e)
        {
            string filePath = "C:/Users/marich/Documents/Book1.xlsx";

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();

                    // Ejemplos de acceso a datos
                    DataTable table = result.Tables[0];
                    DataRow row = table.Rows[0];
                    string cell = row[0].ToString();

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        DataRow currentDataRow = table.Rows[i];

                        HtmlTableRow newRow = new HtmlTableRow();
                        

                        for (int j = 0; j < currentDataRow.Table.Columns.Count; j++)
                        {
                            // Create a Cell (<td>)...
                            HtmlTableCell newCell = new HtmlTableCell();

                            // Set some properties on the cell...
                            //newCell.BackColor = System.Drawing.Color.White;
                            //newCell.ForeColor = System.Drawing.Color.Black;

                            // Add the text from the DataRow...
                            newCell.InnerText = currentDataRow[j].ToString();

                            // Add the cell to the row...
                            newRow.Cells.Add(newCell);
                        }

                        // Add the row to the table:
                        this.Table1.Rows.Add(newRow);
                    }
                }
            }


        }
       
    }
}