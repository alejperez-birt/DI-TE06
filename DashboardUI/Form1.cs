using DashboardBLL;
using DashboardUI.ControlesUsuario;
using DashboardUI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilidades.VO;

namespace DashboardUI
{
    public partial class Form1 : Form
    {
        private TableLayoutPanel tlpDinamico;
        private UserControl ucDinamico;

        private CLienteVO clienteActivo;
        public CLienteVO ClienteActivo { get => clienteActivo; set => clienteActivo = value; }
        
        List<CLienteVO> clientes;


        public Form1()
        {
            InitializeComponent();

            tlpDinamico = tlp_Base;
            ucDinamico = new ControlesUsuario.InicialUC();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tlpDinamico.Controls.Add(ucDinamico, 1, 2);
            CargarFiltros();
            CargarToolTips();
        }


        private void CargarFiltros()
        {
            GestionDashboard gestionDashboard = new GestionDashboard();
            clientes = gestionDashboard.RecogerClientes();

            foreach (CLienteVO cliente in clientes)
            {
                cB_FiltroCliente.Items.Add(cliente);

                bool paisEncontrado = false;
                int numElemCombPais = cB_FiltroPais.Items.Count;
                for (int i = 0; i < numElemCombPais; i++)
                {
                    if (cB_FiltroPais.Items[i].Equals(cliente.Pais))
                    {
                        paisEncontrado = true;
                    }
                }

                if (!paisEncontrado)
                {
                    cB_FiltroPais.Items.Add(cliente.Pais);
                }
            }
        }

        private void CargarToolTips()
        {
            this.tt_Mensaje.SetToolTip(this.picB_Logo, "Visitanos en http://www.northwind.es");

            this.tt_Mensaje.SetToolTip(this.btn_General, "Click aquí para consultar las estadísticas del cliente");
            this.tt_Mensaje.SetToolTip(this.btn_Info, "Click aquí para ver la información del cliente");
            this.tt_Mensaje.SetToolTip(this.btn_Pedidos, "Click aquí para consultar los pedidos del cliente");
            this.tt_Mensaje.SetToolTip(this.btn_Reportes, "Click aquí para acceder a los listados generales");

            this.tt_Mensaje.SetToolTip(this.cB_FiltroPais, "Selecciona un país de la lista");
            this.tt_Mensaje.SetToolTip(this.cB_FiltroCliente, "Selecciona un cliente de la lista");
            this.tt_Mensaje.SetToolTip(this.cb_Busqueda, "Escribe aquí para localizar un cliente");
        }

        private void btn_General_MouseHover(object sender, EventArgs e)
        {
            tlp_General.BackColor = SystemColors.ActiveCaption;
        }

        private void btn_General_MouseLeave(object sender, EventArgs e)
        {
            tlp_General.BackColor = SystemColors.Highlight;
        }

        private void btn_Info_MouseHover(object sender, EventArgs e)
        {
            tlp_Info.BackColor = SystemColors.ActiveCaption;
        }

        private void btn_Info_MouseLeave(object sender, EventArgs e)
        {
            tlp_Info.BackColor = SystemColors.Highlight;
        }

        private void btn_Pedidos_MouseHover(object sender, EventArgs e)
        {
            tlp_Pedidos.BackColor = SystemColors.ActiveCaption;
        }

        private void btn_Pedidos_MouseLeave(object sender, EventArgs e)
        {
            tlp_Pedidos.BackColor = SystemColors.Highlight;
        }

        private void btn_Reportes_MouseHover(object sender, EventArgs e)
        {
            tlp_Reportes.BackColor = SystemColors.ActiveCaption;
        }

        private void btn_Reportes_MouseLeave(object sender, EventArgs e)
        {
            tlp_Reportes.BackColor = SystemColors.Highlight;
        }

        private void btn_General_Click(object sender, EventArgs e)
        {
            if (cB_FiltroCliente.SelectedIndex == -1 && cb_Busqueda.SelectedIndex == -1)
            {
                Atencion atencionPopUp = new Atencion(btn_General.Text);
                atencionPopUp.Show();
            }
            else 
            {
                if (cB_FiltroCliente.SelectedIndex != -1)
                {
                    clienteActivo = (CLienteVO)cB_FiltroCliente.SelectedItem;
                }
                else
                {
                    clienteActivo = (CLienteVO)cb_Busqueda.SelectedItem;
                }

                tlpDinamico.Controls.Remove(ucDinamico);
                ucDinamico = new ControlesUsuario.GeneralUC(clienteActivo);
                tlpDinamico.Controls.Add(ucDinamico, 1, 2);
            }
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            if (cB_FiltroCliente.SelectedIndex == -1 && cb_Busqueda.SelectedIndex == -1)
            {
                Atencion atencionPopUp = new Atencion(btn_Info.Text);
                atencionPopUp.Show();
            }
            else
            {
                if (cB_FiltroCliente.SelectedIndex != -1)
                {
                    clienteActivo = (CLienteVO)cB_FiltroCliente.SelectedItem;
                }
                else
                {
                    clienteActivo = (CLienteVO)cb_Busqueda.SelectedItem;
                }

                tlpDinamico.Controls.Remove(ucDinamico);
                ucDinamico = new ControlesUsuario.InfoClienteUC(clienteActivo);
                tlpDinamico.Controls.Add(ucDinamico, 1, 2);
            }
        }

        private void btn_Pedidos_Click(object sender, EventArgs e)
        {
            if (cB_FiltroCliente.SelectedIndex == -1 && cb_Busqueda.SelectedIndex == -1)
            {
                Atencion atencionPopUp = new Atencion(btn_Pedidos.Text);
                atencionPopUp.Show();
            }
            else
            {
                if (cB_FiltroCliente.SelectedIndex != -1)
                {
                    clienteActivo = (CLienteVO)cB_FiltroCliente.SelectedItem;
                }
                else
                {
                    clienteActivo = (CLienteVO)cb_Busqueda.SelectedItem;
                }

                tlpDinamico.Controls.Remove(ucDinamico);
                ucDinamico = new ControlesUsuario.PedidosUC(clienteActivo);
                tlpDinamico.Controls.Add(ucDinamico, 1, 2);
            }
        }

        private void cB_FiltroCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_FiltroCliente.SelectedIndex != -1)
            {
                cb_Busqueda.Items.Clear();
                cb_Busqueda.Text = "";
                cb_Busqueda.SelectedIndex = -1;

                clienteActivo = (CLienteVO)cB_FiltroCliente.SelectedItem;

                tlpDinamico.Controls.Remove(ucDinamico);
                ucDinamico = new ControlesUsuario.GeneralUC(clienteActivo);
                tlpDinamico.Controls.Add(ucDinamico, 1, 2);
            }
        }

        private void btn_Reportes_Click(object sender, EventArgs e)
        {
            tlpDinamico.Controls.Remove(ucDinamico);
            ucDinamico = new ControlesUsuario.ReportesUC();
            tlpDinamico.Controls.Add(ucDinamico, 1, 2);
        }

        private void cB_FiltroPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cB_FiltroPais.SelectedIndex != -1)
            {
                String paisSeleccionado = (String)cB_FiltroPais.SelectedItem;
                cB_FiltroCliente.Items.Clear();
                cB_FiltroCliente.Text = "";
                cB_FiltroCliente.SelectedIndex = -1;

                cb_Busqueda.Items.Clear();
                cb_Busqueda.Text = "";
                cb_Busqueda.SelectedIndex = -1;

                tlpDinamico.Controls.Remove(ucDinamico);
                ucDinamico = new ControlesUsuario.InicialUC();
                tlpDinamico.Controls.Add(ucDinamico, 1, 2);

                GestionDashboard gestionDashboard = new GestionDashboard();
                clientes = gestionDashboard.RecogerClientes();

                foreach (CLienteVO cliente in clientes)
                {
                    if (cliente.Pais.Equals(paisSeleccionado))
                    {
                        cB_FiltroCliente.Items.Add(cliente);
                    }
                }
            }
        }


        private void cb_Busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            GestionDashboard gestionDashboard = new GestionDashboard();
            clientes = gestionDashboard.BuscarClientes(cb_Busqueda.Text);

            int numElemCombBusq = cb_Busqueda.Items.Count;
            for (int i = numElemCombBusq - 1; i >= 0; i--)
            {
                cb_Busqueda.Items.RemoveAt(i);
            }

            foreach (CLienteVO cliente in clientes)
            {
                cb_Busqueda.Items.Add(cliente);
            }

            cb_Busqueda.DroppedDown = true;
        }

        private void cb_Busqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Busqueda.SelectedIndex != -1)
            {
                cB_FiltroPais.Items.Clear();
                cB_FiltroPais.Text = "";
                cB_FiltroPais.SelectedIndex = -1;

                cB_FiltroCliente.Items.Clear();
                cB_FiltroCliente.Text = "";
                cB_FiltroCliente.SelectedIndex = -1;

                CargarFiltros();

                clienteActivo = (CLienteVO)cb_Busqueda.SelectedItem;

                tlpDinamico.Controls.Remove(ucDinamico);
                ucDinamico = new ControlesUsuario.GeneralUC(clienteActivo);
                tlpDinamico.Controls.Add(ucDinamico, 1, 2);
            }
        }

        private void tsmi_ProductoCategoria_Click(object sender, EventArgs e)
        {
            ReporteForm1 reporte = new ReporteForm1();
            reporte.Show();
        }

        private void tsmi_PedidosPeriodo_Click(object sender, EventArgs e)
        {
            ReporteForm2 reporte = new ReporteForm2();
            reporte.Show();
        }

        private void tsmi_ProductosVendidos_Click(object sender, EventArgs e)
        {
            ReporteForm3 reporte = new ReporteForm3();
            reporte.Show();
        }

        private void tsmi_Inicio_Click(object sender, EventArgs e)
        {
            ucDinamico = new ControlesUsuario.InicialUC();
            tlpDinamico.Controls.Add(ucDinamico, 1, 2);

            cB_FiltroPais.SelectedIndex = -1;
            cB_FiltroCliente.SelectedIndex = -1;
            cb_Busqueda.SelectedIndex = -1;
            CargarFiltros();
        }

        private void tsmi_ManualUsuario_Click(object sender, EventArgs e)
        {
            string appPath = Application.StartupPath;
            Help.ShowHelp(this,"..\\..\\..\\Utilidades\\Ayuda\\Ayuda.chm");
        }

        private void tsmi_AcercaDe_Click(object sender, EventArgs e)
        {
            AcercaDe acerca = new AcercaDe();
            acerca.Show();
        }
    }
}
