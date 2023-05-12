using System.Windows.Forms;

namespace DashboardUI.ControlesUsuario
{
    partial class GeneralUC
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeneralUC));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tlp_BaseGeneral = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Totales = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Descuentos = new System.Windows.Forms.Panel();
            this.lbl_DescuentoMedio = new System.Windows.Forms.Label();
            this.picB_DescuentoMedio = new System.Windows.Forms.PictureBox();
            this.lbl_NumeroDescuento = new System.Windows.Forms.Label();
            this.pnl_TotalPedidos = new System.Windows.Forms.Panel();
            this.picB_TotalPedidos = new System.Windows.Forms.PictureBox();
            this.lbl_NumeroPedidos = new System.Windows.Forms.Label();
            this.lbl_TotalPedidos = new System.Windows.Forms.Label();
            this.pnl_TotalVentas = new System.Windows.Forms.Panel();
            this.picB_TotalVentas = new System.Windows.Forms.PictureBox();
            this.lbl_NumeroVentas = new System.Windows.Forms.Label();
            this.lbl_TotalVentas = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chr_Ventas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tt_MensajeGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.tlp_BaseGeneral.SuspendLayout();
            this.tlp_Totales.SuspendLayout();
            this.pnl_Descuentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_DescuentoMedio)).BeginInit();
            this.pnl_TotalPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_TotalPedidos)).BeginInit();
            this.pnl_TotalVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_TotalVentas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chr_Ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_BaseGeneral
            // 
            this.tlp_BaseGeneral.ColumnCount = 1;
            this.tlp_BaseGeneral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_BaseGeneral.Controls.Add(this.tlp_Totales, 0, 0);
            this.tlp_BaseGeneral.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tlp_BaseGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_BaseGeneral.Location = new System.Drawing.Point(0, 0);
            this.tlp_BaseGeneral.Name = "tlp_BaseGeneral";
            this.tlp_BaseGeneral.Padding = new System.Windows.Forms.Padding(17);
            this.tlp_BaseGeneral.RowCount = 3;
            this.tlp_BaseGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_BaseGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp_BaseGeneral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BaseGeneral.Size = new System.Drawing.Size(687, 560);
            this.tlp_BaseGeneral.TabIndex = 0;
            // 
            // tlp_Totales
            // 
            this.tlp_Totales.ColumnCount = 3;
            this.tlp_Totales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Totales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Totales.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlp_Totales.Controls.Add(this.pnl_Descuentos, 2, 0);
            this.tlp_Totales.Controls.Add(this.pnl_TotalPedidos, 1, 0);
            this.tlp_Totales.Controls.Add(this.pnl_TotalVentas, 0, 0);
            this.tlp_Totales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Totales.Location = new System.Drawing.Point(17, 17);
            this.tlp_Totales.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Totales.Name = "tlp_Totales";
            this.tlp_Totales.Padding = new System.Windows.Forms.Padding(9);
            this.tlp_Totales.RowCount = 1;
            this.tlp_Totales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Totales.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tlp_Totales.Size = new System.Drawing.Size(653, 129);
            this.tlp_Totales.TabIndex = 0;
            // 
            // pnl_Descuentos
            // 
            this.pnl_Descuentos.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_Descuentos.Controls.Add(this.lbl_DescuentoMedio);
            this.pnl_Descuentos.Controls.Add(this.picB_DescuentoMedio);
            this.pnl_Descuentos.Controls.Add(this.lbl_NumeroDescuento);
            this.pnl_Descuentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Descuentos.Location = new System.Drawing.Point(442, 12);
            this.pnl_Descuentos.Margin = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.pnl_Descuentos.Name = "pnl_Descuentos";
            this.pnl_Descuentos.Size = new System.Drawing.Size(199, 105);
            this.pnl_Descuentos.TabIndex = 2;
            // 
            // lbl_DescuentoMedio
            // 
            this.lbl_DescuentoMedio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_DescuentoMedio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_DescuentoMedio.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_DescuentoMedio.Location = new System.Drawing.Point(67, 16);
            this.lbl_DescuentoMedio.Name = "lbl_DescuentoMedio";
            this.lbl_DescuentoMedio.Size = new System.Drawing.Size(123, 47);
            this.lbl_DescuentoMedio.TabIndex = 3;
            this.lbl_DescuentoMedio.Text = "DESCUENTO MEDIO";
            this.lbl_DescuentoMedio.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // picB_DescuentoMedio
            // 
            this.picB_DescuentoMedio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_DescuentoMedio.BackgroundImage")));
            this.picB_DescuentoMedio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_DescuentoMedio.Location = new System.Drawing.Point(12, 10);
            this.picB_DescuentoMedio.Name = "picB_DescuentoMedio";
            this.picB_DescuentoMedio.Size = new System.Drawing.Size(55, 55);
            this.picB_DescuentoMedio.TabIndex = 5;
            this.picB_DescuentoMedio.TabStop = false;
            // 
            // lbl_NumeroDescuento
            // 
            this.lbl_NumeroDescuento.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_NumeroDescuento.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NumeroDescuento.Location = new System.Drawing.Point(13, 65);
            this.lbl_NumeroDescuento.Name = "lbl_NumeroDescuento";
            this.lbl_NumeroDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_NumeroDescuento.Size = new System.Drawing.Size(184, 32);
            this.lbl_NumeroDescuento.TabIndex = 4;
            this.lbl_NumeroDescuento.Text = "DESCUENTO";
            this.lbl_NumeroDescuento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_TotalPedidos
            // 
            this.pnl_TotalPedidos.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_TotalPedidos.Controls.Add(this.picB_TotalPedidos);
            this.pnl_TotalPedidos.Controls.Add(this.lbl_NumeroPedidos);
            this.pnl_TotalPedidos.Controls.Add(this.lbl_TotalPedidos);
            this.pnl_TotalPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_TotalPedidos.Location = new System.Drawing.Point(231, 12);
            this.pnl_TotalPedidos.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.pnl_TotalPedidos.Name = "pnl_TotalPedidos";
            this.pnl_TotalPedidos.Size = new System.Drawing.Size(189, 105);
            this.pnl_TotalPedidos.TabIndex = 1;
            // 
            // picB_TotalPedidos
            // 
            this.picB_TotalPedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_TotalPedidos.BackgroundImage")));
            this.picB_TotalPedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_TotalPedidos.Location = new System.Drawing.Point(9, 9);
            this.picB_TotalPedidos.Name = "picB_TotalPedidos";
            this.picB_TotalPedidos.Size = new System.Drawing.Size(55, 55);
            this.picB_TotalPedidos.TabIndex = 5;
            this.picB_TotalPedidos.TabStop = false;
            // 
            // lbl_NumeroPedidos
            // 
            this.lbl_NumeroPedidos.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_NumeroPedidos.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NumeroPedidos.Location = new System.Drawing.Point(20, 63);
            this.lbl_NumeroPedidos.Name = "lbl_NumeroPedidos";
            this.lbl_NumeroPedidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_NumeroPedidos.Size = new System.Drawing.Size(166, 32);
            this.lbl_NumeroPedidos.TabIndex = 4;
            this.lbl_NumeroPedidos.Text = "PEDIDOS";
            this.lbl_NumeroPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TotalPedidos
            // 
            this.lbl_TotalPedidos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalPedidos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_TotalPedidos.Location = new System.Drawing.Point(64, 16);
            this.lbl_TotalPedidos.Name = "lbl_TotalPedidos";
            this.lbl_TotalPedidos.Size = new System.Drawing.Size(115, 47);
            this.lbl_TotalPedidos.TabIndex = 3;
            this.lbl_TotalPedidos.Text = "TOTAL PEDIDOS";
            this.lbl_TotalPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_TotalVentas
            // 
            this.pnl_TotalVentas.BackColor = System.Drawing.SystemColors.Info;
            this.pnl_TotalVentas.Controls.Add(this.picB_TotalVentas);
            this.pnl_TotalVentas.Controls.Add(this.lbl_NumeroVentas);
            this.pnl_TotalVentas.Controls.Add(this.lbl_TotalVentas);
            this.pnl_TotalVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_TotalVentas.Location = new System.Drawing.Point(12, 12);
            this.pnl_TotalVentas.Margin = new System.Windows.Forms.Padding(3, 3, 11, 3);
            this.pnl_TotalVentas.Name = "pnl_TotalVentas";
            this.pnl_TotalVentas.Size = new System.Drawing.Size(197, 105);
            this.pnl_TotalVentas.TabIndex = 0;
            // 
            // picB_TotalVentas
            // 
            this.picB_TotalVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_TotalVentas.BackgroundImage")));
            this.picB_TotalVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_TotalVentas.Location = new System.Drawing.Point(9, 9);
            this.picB_TotalVentas.Name = "picB_TotalVentas";
            this.picB_TotalVentas.Size = new System.Drawing.Size(55, 55);
            this.picB_TotalVentas.TabIndex = 2;
            this.picB_TotalVentas.TabStop = false;
            // 
            // lbl_NumeroVentas
            // 
            this.lbl_NumeroVentas.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_NumeroVentas.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_NumeroVentas.Location = new System.Drawing.Point(29, 63);
            this.lbl_NumeroVentas.Name = "lbl_NumeroVentas";
            this.lbl_NumeroVentas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_NumeroVentas.Size = new System.Drawing.Size(166, 32);
            this.lbl_NumeroVentas.TabIndex = 1;
            this.lbl_NumeroVentas.Text = "VENTAS";
            this.lbl_NumeroVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_TotalVentas
            // 
            this.lbl_TotalVentas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.lbl_TotalVentas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lbl_TotalVentas.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbl_TotalVentas.Location = new System.Drawing.Point(99, 16);
            this.lbl_TotalVentas.Name = "lbl_TotalVentas";
            this.lbl_TotalVentas.Size = new System.Drawing.Size(89, 47);
            this.lbl_TotalVentas.TabIndex = 0;
            this.lbl_TotalVentas.Text = "TOTAL VENTAS";
            this.lbl_TotalVentas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chr_Ventas, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 149);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 389F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(647, 381);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chr_Ventas
            // 
            this.chr_Ventas.BackColor = System.Drawing.Color.Transparent;
            this.chr_Ventas.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chr_Ventas.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chr_Ventas.ChartAreas.Add(chartArea1);
            this.chr_Ventas.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chr_Ventas.Legends.Add(legend1);
            this.chr_Ventas.Location = new System.Drawing.Point(0, 0);
            this.chr_Ventas.Margin = new System.Windows.Forms.Padding(0);
            this.chr_Ventas.Name = "chr_Ventas";
            this.chr_Ventas.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Unidades";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Ventas";
            this.chr_Ventas.Series.Add(series1);
            this.chr_Ventas.Series.Add(series2);
            this.chr_Ventas.Size = new System.Drawing.Size(647, 381);
            this.chr_Ventas.TabIndex = 0;
            this.chr_Ventas.Text = "chart1";
            // 
            // GeneralUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.tlp_BaseGeneral);
            this.Name = "GeneralUC";
            this.Size = new System.Drawing.Size(687, 560);
            this.Load += new System.EventHandler(this.GeneralUC_Load);
            this.tlp_BaseGeneral.ResumeLayout(false);
            this.tlp_Totales.ResumeLayout(false);
            this.pnl_Descuentos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_DescuentoMedio)).EndInit();
            this.pnl_TotalPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_TotalPedidos)).EndInit();
            this.pnl_TotalVentas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_TotalVentas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chr_Ventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_BaseGeneral;
        private TableLayoutPanel tlp_Totales;
        private Panel pnl_Descuentos;
        private Panel pnl_TotalPedidos;
        private Panel pnl_TotalVentas;
        private Label lbl_NumeroVentas;
        private Label lbl_TotalVentas;
        private PictureBox picB_TotalPedidos;
        private Label lbl_NumeroPedidos;
        private Label lbl_TotalPedidos;
        private PictureBox picB_TotalVentas;
        private Label lbl_DescuentoMedio;
        private PictureBox picB_DescuentoMedio;
        private Label lbl_NumeroDescuento;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chr_Ventas;
        private ToolTip tt_MensajeGeneral;
    }
}
