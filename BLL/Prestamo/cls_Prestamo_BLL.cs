using DAL.Prestamo;
using System;

namespace BLL.Prestamo
{
    public class cls_Prestamo_BLL
    {
        public void CAlculoPrestamo(ref cls_Prestamo_DAL Obj_DAL)
        {
            try
            {
                if (Obj_DAL.BPlazo > 0 && Obj_DAL.BPlazo <= 72)
                {
                    Double rateExposed = Math.Pow(1 + (Obj_DAL.DTasa / 100), Convert.ToDouble(Obj_DAL.BPlazo));
                    Obj_DAL.DCuota = Obj_DAL.DMtoPres * (((Obj_DAL.DTasa / 100) * rateExposed) / (rateExposed - 1));
                    //Obj_DAL.DSaldo = Obj_DAL.DMtoPres - (Obj_DAL.DCuota-(Obj_DAL.DMtoPres * (Obj_DAL.DTasa / 100)));
                    Obj_DAL.DSaldo = Obj_DAL.DMtoPres;
                }
                else
                {
                    //Response.Write("<script>alert('Error: Se permite un plazo maximo de 72 meses');</script>");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
