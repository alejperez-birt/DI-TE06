using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.DTO
{
    public class EstadisticasDTO
    {
        private string iDCliente;
        private double ventasTotales;
        private int pedidosTotales;
        private double descuentoMedio;

        public EstadisticasDTO() { }
        public EstadisticasDTO(string iDCliente, double ventasTotales, int pedidosTotales, double descuentoMedio)
        {
            this.iDCliente = iDCliente;
            this.ventasTotales = ventasTotales;
            this.pedidosTotales = pedidosTotales;
            this.descuentoMedio = descuentoMedio;
        }

        public string IDCliente { get => iDCliente; set => iDCliente = value; }
        public double VentasTotales { get => ventasTotales; set => ventasTotales = value; }
        public int PedidosTotales { get => pedidosTotales; set => pedidosTotales = value; }
        public double DescuentoMedio { get => descuentoMedio; set => descuentoMedio = value; }
    }
}
