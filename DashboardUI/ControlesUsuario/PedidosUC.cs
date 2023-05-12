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
using Utilidades.VO;

namespace DashboardUI.ControlesUsuario
{
    public partial class PedidosUC : UserControl
    {
        CLienteVO clienteActivo;
        public PedidosUC(CLienteVO cliente)
        {
            InitializeComponent();
            clienteActivo = cliente;

            EstablecerToolTips();
        }

        private void EstablecerToolTips()
        {
            this.tt_MensajePedidos.SetToolTip(this.lbl_EncabezadoPedidos, "Listado de pedidos del cliente " + clienteActivo.IDCliente);
            this.tt_MensajePedidos.SetToolTip(this.lbl_EncabezadoDetallePedido, "Detalle de lineas del pedido seleccionado");
        }

        private void PedidosUC_Load(object sender, EventArgs e)
        {
            GestionDashboard gestionDashboard = new GestionDashboard();
            List<PedidoVO> listadoPedidos;
            //listadoPedidos = gestionDashboard.RecogerListadoPedidos("AROUT");
            listadoPedidos = gestionDashboard.RecogerListadoPedidos(clienteActivo.IDCliente);

            lbl_EncabezadoPedidos.Text = "Listado de pedidos de " + listadoPedidos[0].NombreEmpresa;
            dgv_ListadoPedidos.DataSource = listadoPedidos;
        }

        private void dgv_ListadoPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int iDPedido = (int)Int64.Parse(dgv_ListadoPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());

            GestionDashboard gestionDashboard = new GestionDashboard();
            List<DetallePedidoVO> detallePedido;
            detallePedido = gestionDashboard.RecogerDetallePedido(iDPedido);


            lbl_EncabezadoDetallePedido.Text = "Líneas del pedido " + detallePedido[0].IDPedido;
            dgv_DetallePedido.DataSource = detallePedido;
        }
    }
}
