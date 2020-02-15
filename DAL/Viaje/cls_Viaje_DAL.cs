using System;

namespace DAL.Viaje
{
    public class cls_Viaje_DAL
    {
        private string nombre, apellido, destino, origen;
        private int clase, cantidad, precio, impuesto, total, asiento;
        private DateTime salida, regreso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Destino { get => destino; set => destino = value; }
        public int Clase { get => clase; set => clase = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
        public int Impuesto { get => impuesto; set => impuesto = value; }
        public int Total { get => total; set => total = value; }
        public int Asiento { get => asiento; set => asiento = value; }
        public string Origen { get => origen; set => origen = value; }
        public DateTime Salida { get => salida; set => salida = value; }
        public DateTime Regreso { get => regreso; set => regreso = value; }
    }
}
