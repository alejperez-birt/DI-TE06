using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DashboardUI
{
    public partial class Atencion : Form
    {
        public Atencion(String mensaje)
        {
            InitializeComponent();
            this.lbl_Texto.Text = "No se puede mostrar la pantalla '" + mensaje + "' hasta que no seleccione un cliente";
        }

        private void Atencion_Load(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
