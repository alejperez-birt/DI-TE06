using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class DetallePedidoVO
    {
        private int iDPedido;
        private int iDProducto;
        private string nombreProducto;
        private double precio;
        private int cantidad;
        private double descuento;
        private DateTime fechaEnvio;

        public DetallePedidoVO() { }

        public DetallePedidoVO(int iDPedido, int iDProducto, string nombreProducto, double precio, int cantidad, double descuento)
        {
            this.iDPedido = iDPedido;
            this.iDProducto = iDProducto;
            this.nombreProducto = nombreProducto;
            this.precio = precio;
            this.cantidad = cantidad;
            this.descuento = descuento;
            this.fechaEnvio = fechaEnvio;
        }

        public int IDPedido { get => iDPedido; set => iDPedido = value; }
        public int IDProducto { get => iDProducto; set => iDProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Descuento { get => descuento; set => descuento = value; }
        public DateTime FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
    }
}
