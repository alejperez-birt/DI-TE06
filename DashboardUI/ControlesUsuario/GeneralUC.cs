using DashboardBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.DTO;
using Utilidades.VO;

namespace DashboardUI.ControlesUsuario
{
    public partial class GeneralUC : UserControl
    {
        CLienteVO clienteActivo;

        public GeneralUC(CLienteVO cliente)
        {
            InitializeComponent();
            clienteActivo = cliente;

            EstablecerToolTips();
        }

        private void EstablecerToolTips()
        {
            this.tt_MensajeGeneral.SetToolTip(this.pnl_TotalVentas, "Total de ventas realizadas a " + clienteActivo.IDCliente);
            this.tt_MensajeGeneral.SetToolTip(this.pnl_TotalPedidos, "Cantidad de pedidos realizados por " + clienteActivo.IDCliente);
            this.tt_MensajeGeneral.SetToolTip(this.pnl_Descuentos, "Descuento medio aplicado a " + clienteActivo.IDCliente);

            this.tt_MensajeGeneral.SetToolTip(this.chr_Ventas, "Unidades vendidas y ventas totales de " + clienteActivo.IDCliente + " a lo largo del tiempo");
        }

        public void GeneralUC_Load(object sender, EventArgs e)
        {
            MostrarEstadisticas();
            GenerarGrafico();
        }


        private void MostrarEstadisticas()
        {
            EstadisticasDTO estadisticas = new EstadisticasDTO();
            // estadisticas.IDCliente = "AROUT";
            estadisticas.IDCliente = clienteActivo.IDCliente;

            GestionDashboard gestionDashboard = new GestionDashboard();
            estadisticas = gestionDashboard.CalcularTotales(estadisticas);

            lbl_NumeroVentas.Text = estadisticas.VentasTotales.ToString() + "Euro";
            lbl_NumeroPedidos.Text = estadisticas.PedidosTotales.ToString();
            lbl_NumeroDescuento.Text = estadisticas.DescuentoMedio.ToString() + "%";
        }
        private void GenerarGrafico()
        {
            List<PedidoDTO> totalesPedidos;

            GestionDashboard gestionDashboard = new GestionDashboard();
            //totalesPedidos = gestionDashboard.CalcularTotalesPedidos("AROUT");
            totalesPedidos = gestionDashboard.CalcularTotalesPedidos(clienteActivo.IDCliente);

            List<string> x1 = new List<string>();
            List<double> y1 = new List<double>();

            List<string> x2 = new List<string>();
            List<int> y2 = new List<int>();

            for (int i = 0; i < totalesPedidos.Count; i++)
            {
                x1.Add(totalesPedidos[i].FechaEnvio.Date.ToString());
                y1.Add(totalesPedidos[i].ImportePedido);

                x2.Add(totalesPedidos[i].FechaEnvio.Date.ToString());
                y2.Add(totalesPedidos[i].CantidadPedido*10);
            }

            chr_Ventas.Series["Ventas"].Points.DataBindXY(x1.ToArray(), y1.ToArray());
            chr_Ventas.Series["Unidades"].Points.DataBindXY(x2.ToArray(), y2.ToArray());

            chr_Ventas.ChartAreas[0].AxisX.Title = "Fecha de envío";

            chr_Ventas.Titles.Clear();
            chr_Ventas.Titles.Add("Ventas y cantidad de unidades vendidas");

        }

    }
}
