using DashboardDAL;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.DTO;
using Utilidades.VO;

namespace DashboardBLL
{
    public class GestionDashboard
    {
        public GestionDashboard() { }

        public CLienteVO RecogerDatosCliente(string iDCliente)
        {
            CLienteVO cliente = AccederDatosCLiente(iDCliente);
            return cliente;
        }

        private CLienteVO AccederDatosCLiente(string iDCliente)
        {
            GestionSQL gestionSQL = new GestionSQL();
            CLienteVO cliente = gestionSQL.DatosClienteSQL(iDCliente);
            return cliente;
        }

        public List<PedidoVO> RecogerListadoPedidos(string iDCliente)
        {
            List<PedidoVO> listadoPedidos = AccederListadoPedidos(iDCliente);
            return listadoPedidos;
        }

        private List<PedidoVO> AccederListadoPedidos(string iDCliente)
        {
            GestionSQL gestionSQL = new GestionSQL();
            List<PedidoVO> listadoPedidos = gestionSQL.ListadoPedidosSQL(iDCliente);
            return listadoPedidos;
        }

        public List<DetallePedidoVO> RecogerDetallePedido(int iDPedido)
        {
            List<DetallePedidoVO> detallePedido = AccederDetallePedido(iDPedido);
            return detallePedido;
        }

        private List<DetallePedidoVO> AccederDetallePedido(int iDPedido)
        {
            GestionSQL gestionSQL = new GestionSQL();
            List<DetallePedidoVO> detallePedido = gestionSQL.DetallePedidoSQL(iDPedido);
            return detallePedido;
        }

        public EstadisticasDTO CalcularTotales(EstadisticasDTO estadisticas)
        {
            estadisticas = AccederTotalesDetallesPedido(estadisticas);
            return estadisticas;
        }

        private EstadisticasDTO AccederTotalesDetallesPedido(EstadisticasDTO estadisticas)
        {
            GestionSQL gestionSQL = new GestionSQL();
            List<DetallePedidoVO> detallePedido = gestionSQL.DetallePedidosClienteSQL(estadisticas.IDCliente);

            double importeTotal = 0;
            double sumaDescuentos = 0;

            for (int i = 0; i < detallePedido.Count; i++)
            {
                importeTotal += detallePedido[i].Cantidad * detallePedido[i].Precio;
                sumaDescuentos += detallePedido[i].Descuento;
            }

            estadisticas.VentasTotales = Math.Round(importeTotal, 2);
            estadisticas.PedidosTotales = detallePedido.Count;
            estadisticas.DescuentoMedio = Math.Round(100 * sumaDescuentos / detallePedido.Count, 2);

            return estadisticas;
        }

        public List<PedidoDTO> CalcularTotalesPedidos(string iDCliente)
        {
            List<PedidoDTO> totalesPedidos = AccederTotalesPedidos(iDCliente);
            return totalesPedidos;
        }

        private List<PedidoDTO> AccederTotalesPedidos(string iDCliente)
        {
            List<PedidoDTO> totalesPedidos = new List<PedidoDTO>();

            GestionSQL gestionSQL = new GestionSQL();
            List<DetallePedidoVO> detallePedido = gestionSQL.DetallePedidosClienteSQL(iDCliente);

            double importeTotal = 0;
            int cantidadTotal = 0;

            int iDPedidoAnterior = detallePedido[0].IDPedido;
            DateTime fechaEnvioAnterior = detallePedido[0].FechaEnvio;

            for (int i = 0; i < detallePedido.Count; i++)
            {
                if(detallePedido[i].IDPedido == iDPedidoAnterior)
                {
                    importeTotal += detallePedido[i].Cantidad * detallePedido[i].Precio;
                    cantidadTotal += detallePedido[i].Cantidad;


                } else
                {
                    PedidoDTO pedidoDTO = new PedidoDTO(iDPedidoAnterior, fechaEnvioAnterior, cantidadTotal, importeTotal);
                    totalesPedidos.Add(pedidoDTO);

                    iDPedidoAnterior = detallePedido[i].IDPedido;
                    fechaEnvioAnterior = detallePedido[i].FechaEnvio;
                    importeTotal = detallePedido[i].Cantidad * detallePedido[i].Precio;
                    cantidadTotal = detallePedido[i].Cantidad;
                }
            }

            PedidoDTO pedido = new PedidoDTO(iDPedidoAnterior, fechaEnvioAnterior, cantidadTotal, importeTotal);
            totalesPedidos.Add(pedido);

            return totalesPedidos;
        }

        public List<CLienteVO> RecogerClientes()
        {
            List<CLienteVO> clientes = AccederClientes();
            return clientes;
        }

        private List<CLienteVO> AccederClientes()
        {
            GestionSQL gestionSQL = new GestionSQL();
            List<CLienteVO> clientes = gestionSQL.ClientesSQL();
            return clientes;
        }

        public List<CLienteVO> BuscarClientes(String textoBusqueda)
        {
            List<CLienteVO> clientes = AccederBusquedaClientes(textoBusqueda);
            return clientes;
        }

        private List<CLienteVO> AccederBusquedaClientes(String textoBusqueda)
        {
            GestionSQL gestionSQL = new GestionSQL();
            List<CLienteVO> clientes = gestionSQL.BusquedaClientesSQL(textoBusqueda);
            return clientes;
        }
    }
}

