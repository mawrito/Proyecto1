using ExcelDataReader;
using System;
using System.Data;
using System.IO;
using System.Web.UI;
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

                    DataTable table = result.Tables[0];
                    DataRow row = table.Rows[0];
                    string cell = row[0].ToString();

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        DataRow currentDataRow = table.Rows[i];

                        HtmlTableRow newRow = new HtmlTableRow();


                        for (int j = 0; j < currentDataRow.Table.Columns.Count; j++)
                        {
                            HtmlTableCell newCell = new HtmlTableCell();

                            newCell.InnerText = currentDataRow[j].ToString();

                            newRow.Cells.Add(newCell);
                        }

                        this.Table1.Rows.Add(newRow);
                    }
                }
            }


        }
        protected void ImportarSQL_Click(object sender, EventArgs e)
        {
            string filePath = "C:/Users/marich/Documents/Book1.xlsx";

            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    do
                    {
                        while (reader.Read())
                        {
                            reader.GetDouble(0);
                        }
                    } while (reader.NextResult());

                }
            }


        }

    }
}