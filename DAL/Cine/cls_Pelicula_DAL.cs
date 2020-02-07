using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Viaje
{
    public class cls_Pelicula_DAL
    {
        private string nombre, apellido, pelicula;
        private int sala, cantidad, precio, impuesto, total, asiento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Pelicula { get => pelicula; set => pelicula = value; }
        public int Sala { get => sala; set => sala = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Impuesto { get => impuesto; set => impuesto = value; }
        public int Total { get => total; set => total = value; }
        public int Asiento { get => asiento; set => asiento = value; }
    }
}
