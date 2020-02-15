using BLL.Palindromo;
using DAL.Palindromo;
using System;
using System.Web.UI;

namespace PL
{
    public partial class Capicuas : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void Validar_Click(object sender, EventArgs e)
        {
            cls_Palabra_DAL palabra = new cls_Palabra_DAL();
            palabra.Word = word.Value;
            cls_Validar_BLL validar = new cls_Validar_BLL();

            if (validar.Validacion(ref palabra))
            {
                reverse.Value = palabra.Reverse;
                result.Value = "SI es un Capicua";
            }
            else
            {
                reverse.Value = palabra.Reverse;
                result.Value = "NO es un Capicua";
            }

        }
    }
}