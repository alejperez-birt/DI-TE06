using DashboardUI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI.ControlesUsuario
{
    public partial class ReportesUC : UserControl
    {
        public ReportesUC()
        {
            InitializeComponent();
            EstablecerToolTips();
        }

        private void EstablecerToolTips()
        {
            this.tt_MensajeReportes.SetToolTip(this.btn_Reporte1, "Listado de productos por categoría");
            this.tt_MensajeReportes.SetToolTip(this.btn_Reporte2, "Listado de pedidos entre dos fechas");
            this.tt_MensajeReportes.SetToolTip(this.btn_Reporte3, "Listado de productos con más ventas entre dos fechas");
        }

        private void btn_Reporte1_Click(object sender, EventArgs e)
        {
            ReporteForm1 reporte = new ReporteForm1();
            reporte.Show();
        }

        private void btn_Reporte3_Click(object sender, EventArgs e)
        {
            ReporteForm3 reporte = new ReporteForm3();
            reporte.Show();
        }

        private void btn_Reporte2_Click(object sender, EventArgs e)
        {
            ReporteForm2 reporte = new ReporteForm2();
            reporte.Show();
        }
    }
}
