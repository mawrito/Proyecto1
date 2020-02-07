using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL.Palindromo;
using BLL.Palindromo;
using System.Web.Services;

namespace PL
{
    public partial class Palindromo : Page
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
                result.Value = "SI es un Palindromo";
            }
            else
            {
                reverse.Value = palabra.Reverse;
                result.Value = "NO es un Palindromo";
            }

        }
    }
}