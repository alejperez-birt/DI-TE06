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
    public partial class AcercaDe : Form
    {
        public AcercaDe()
        {
            InitializeComponent();
        }

        private void AcercaDe_Load(object sender, EventArgs e)
        {
            lbl_AcercaDe.Text = "Alex Pérez\n" +
                           "DAM - Diseño de Interfaces - UD06\n" +
                           "2023";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
