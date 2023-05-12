using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.VO
{
    public class PedidoVO
    {
        private int iDPedido;
        private string iDCliente;
        private string nombreEmpresa;
        private DateTime fechaEnvio;
        private string agenciaEnvio;
        private double importeEnvio;
        private string destinatario;
        private string direccionEntrega;
        private string poblacionEntrega;
        private string regionEntrega;
        private string codigoPostalEntrega;
        private string paisEntrega;

        public PedidoVO() { }

        public PedidoVO(int iDPedido, string iDCliente, string nombreEmpresa, DateTime fechaEnvio, string agenciaEnvio, double importeEnvio, string destinatario, string direccionEntrega, string poblacionEntrega, string regionEntrega, string codigoPostalEntrega, string paisEntrega)
        {
            this.iDPedido = iDPedido;
            this.iDCliente = iDCliente;
            this.nombreEmpresa = nombreEmpresa;
            this.fechaEnvio = fechaEnvio;
            this.agenciaEnvio = agenciaEnvio;
            this.importeEnvio = importeEnvio;
            this.destinatario = destinatario;
            this.direccionEntrega = direccionEntrega;
            this.poblacionEntrega = poblacionEntrega;
            this.regionEntrega = regionEntrega;
            this.codigoPostalEntrega = codigoPostalEntrega;
            this.paisEntrega = paisEntrega;

        }

        public int IDPedido { get => iDPedido; set => iDPedido = value; }
        public string IDCliente { get => iDCliente; set => iDCliente = value; }
        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public DateTime FechaEnvio { get => fechaEnvio; set => fechaEnvio = value; }
        public string AgenciaEnvio { get => agenciaEnvio; set => agenciaEnvio = value; }
        public double ImporteEnvio { get => importeEnvio; set => importeEnvio = value; }
        public string Destinatario { get => destinatario; set => destinatario = value; }
        public string DireccionEntrega { get => direccionEntrega; set => direccionEntrega = value; }
        public string PoblacionEntrega { get => poblacionEntrega; set => poblacionEntrega = value; }
        public string RegionEntrega { get => regionEntrega; set => regionEntrega = value; }
        public string CodigoPostalEntrega { get => codigoPostalEntrega; set => codigoPostalEntrega = value; }
        public string PaisEntrega { get => paisEntrega; set => paisEntrega = value; }

    }
}
