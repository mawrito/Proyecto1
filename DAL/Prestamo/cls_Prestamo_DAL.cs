using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Prestamo
{
    public class cls_Prestamo_DAL
    {

        private byte _bPlazo;
        private double _dTasa, _dMtoPres, _dCuota, _dAbonoCap, _dAbonoInt, _dSaldo;
        private DataTable _dtbPlanPagos;

        public byte BPlazo { get => _bPlazo; set => _bPlazo = value; }
        public double DTasa { get => _dTasa; set => _dTasa = value; }
        public double DMtoPres { get => _dMtoPres; set => _dMtoPres = value; }
        public double DCuota { get => _dCuota; set => _dCuota = value; }
        public double DAbonoCap { get => _dAbonoCap; set => _dAbonoCap = value; }
        public double DAbonoInt { get => _dAbonoInt; set => _dAbonoInt = value; }
        public double DSaldo { get => _dSaldo; set => _dSaldo = value; }
        public DataTable DtbPlanPagos { get => _dtbPlanPagos; set => _dtbPlanPagos = value; }
    }
}
