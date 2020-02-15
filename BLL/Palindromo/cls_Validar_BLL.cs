using DAL.Palindromo;
using System;

namespace BLL.Palindromo
{
    public class cls_Validar_BLL
    {
        public bool Validacion(ref cls_Palabra_DAL Obj_DAL)
        {
            char[] ch = Obj_DAL.Word.ToCharArray();
            Array.Reverse(ch);
            Obj_DAL.Reverse = new string(ch);

            if (Obj_DAL.Word.Equals(Obj_DAL.Reverse, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
    }
}
