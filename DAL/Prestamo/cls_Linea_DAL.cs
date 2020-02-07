using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Prestamo
{
    public class cls_Linea_DAL
    {
        private string Numero, Cuota, AbonoCapital, AbonoIntereses, NuevoSaldo;

        public string No { get => Numero; set => Numero = value; }
        public string Monto{ get => Cuota; set => Cuota = value; }
        public string Capital { get => AbonoCapital; set => AbonoCapital = value; }
        public string Intereses { get => AbonoIntereses; set => AbonoIntereses = value; }
        public string Saldo { get => NuevoSaldo; set => NuevoSaldo = value; }
    }
}
