using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.DTO
{
    public class PedidoDTO
    {
        private int iDPedido;
        private DateTime fechaEnvio;
        private int cantidadPedido;
        private double importePedido;

        public PedidoDTO() { }

        public PedidoDTO(int iDPedido, DateTime fechaEnvio, int cantidadPedido, double importePedido)
        {
            this.iDPedido = iDPedido;
            this.fechaEnvio = fechaEnvio;
            this.cantidadPedido = cantidadPedido;
            this.importePedido = importePedido;
        }

        public int IDPedido { get => iDPedido; set => iDPedido = value; }
        public DateTime FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
        public int CantidadPedido { get => cantidadPedido; set => cantidadPedido = value; }
        public double ImportePedido { get => importePedido; set => importePedido = value; }
    }
}
