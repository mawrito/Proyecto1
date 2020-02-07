using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Viaje
{
    public class cls_Viaje_DAL
    {
        private string nombre, apellido, destino;
        private int clase, cantidad, precio, impuesto, total, asiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Destino { get => destino; set => destino = value; }
        public int Clase { get => clase; set => clase = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Impuesto { get => impuesto; set => impuesto = value; }
        public int Total { get => total; set => total = value; }
        public int Asiento { get => asiento; set => asiento = value; }
    }
}
