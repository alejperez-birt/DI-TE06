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
    public partial class InfoClienteUC : UserControl
    {
        CLienteVO clienteActivo;
        public InfoClienteUC(CLienteVO cliente)
        {
            InitializeComponent();
            clienteActivo = cliente;

            EstablecerToolTips();
        }

        private void EstablecerToolTips()
        {
            this.tt_MensajeInfo.SetToolTip(this.tlp_EncabezadoInfoCliente, "Información general del cliente " + clienteActivo.IDCliente);
            this.tt_MensajeInfo.SetToolTip(this.tlp_ContenidoInfoCliente, "Información general del cliente " + clienteActivo.IDCliente);
        }

        private void InfoClienteUC_Load(object sender, EventArgs e)
        {
            GestionDashboard gestionDashboard = new GestionDashboard();
            CLienteVO cliente = gestionDashboard.RecogerDatosCliente(clienteActivo.IDCliente);

            lbl_NombreEmpresa.Text = cliente.IDCliente + ".- " + cliente.NombreEmpresa;
            lbl_ContenidoPersonaContacto.Text = cliente.NombreContacto;
            lbl_ContenidoCargo.Text = cliente.CategoriaContacto;
            lbl_ContenidoDireccion.Text = cliente.Direccion;
            lbl_ContenidoPoblacion.Text = cliente.Ciudad;
            lbl_ContenidoRegion.Text = cliente.Region;
            lbl_ContenidoCodigoPostal.Text = cliente.CodigoPostal;
            lbl_ContenidoPais.Text = cliente.Pais;
            lbl_ContenidoTelefono.Text = cliente.Telefono;
            lbl_ContenidoFax.Text = cliente.Fax;

        }

    }
}