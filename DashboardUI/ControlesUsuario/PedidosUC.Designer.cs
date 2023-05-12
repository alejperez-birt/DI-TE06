using System.Windows.Forms;

namespace DashboardUI.ControlesUsuario
{
    partial class PedidosUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidosUC));
            this.tlp_BasePedidos = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_ListadoPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_EncabezadoPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_EncabezadoPedidos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv_ListadoPedidos = new System.Windows.Forms.DataGridView();
            this.tlp_DetallePedido = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_DetallePedido = new System.Windows.Forms.DataGridView();
            this.lbl_Nota = new System.Windows.Forms.Label();
            this.tlp_EncabezadoDetallePedido = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_EncabezadoDetallePedido = new System.Windows.Forms.Label();
            this.tt_MensajePedidos = new System.Windows.Forms.ToolTip(this.components);
            this.tlp_BasePedidos.SuspendLayout();
            this.tlp_ListadoPedidos.SuspendLayout();
            this.tlp_EncabezadoPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoPedidos)).BeginInit();
            this.tlp_DetallePedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetallePedido)).BeginInit();
            this.tlp_EncabezadoDetallePedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_BasePedidos
            // 
            this.tlp_BasePedidos.ColumnCount = 1;
            this.tlp_BasePedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_BasePedidos.Controls.Add(this.tlp_ListadoPedidos, 0, 0);
            this.tlp_BasePedidos.Controls.Add(this.tlp_DetallePedido, 0, 1);
            this.tlp_BasePedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_BasePedidos.Location = new System.Drawing.Point(0, 0);
            this.tlp_BasePedidos.Name = "tlp_BasePedidos";
            this.tlp_BasePedidos.Padding = new System.Windows.Forms.Padding(17);
            this.tlp_BasePedidos.RowCount = 3;
            this.tlp_BasePedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_BasePedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_BasePedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BasePedidos.Size = new System.Drawing.Size(687, 560);
            this.tlp_BasePedidos.TabIndex = 0;
            // 
            // tlp_ListadoPedidos
            // 
            this.tlp_ListadoPedidos.ColumnCount = 1;
            this.tlp_ListadoPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ListadoPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlp_ListadoPedidos.Controls.Add(this.tlp_EncabezadoPedidos, 0, 0);
            this.tlp_ListadoPedidos.Controls.Add(this.dgv_ListadoPedidos, 0, 1);
            this.tlp_ListadoPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ListadoPedidos.Location = new System.Drawing.Point(17, 17);
            this.tlp_ListadoPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_ListadoPedidos.Name = "tlp_ListadoPedidos";
            this.tlp_ListadoPedidos.RowCount = 2;
            this.tlp_ListadoPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlp_ListadoPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_ListadoPedidos.Size = new System.Drawing.Size(653, 258);
            this.tlp_ListadoPedidos.TabIndex = 0;
            // 
            // tlp_EncabezadoPedidos
            // 
            this.tlp_EncabezadoPedidos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tlp_EncabezadoPedidos.ColumnCount = 2;
            this.tlp_EncabezadoPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlp_EncabezadoPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_EncabezadoPedidos.Controls.Add(this.lbl_EncabezadoPedidos, 1, 0);
            this.tlp_EncabezadoPedidos.Controls.Add(this.pictureBox1, 0, 0);
            this.tlp_EncabezadoPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_EncabezadoPedidos.Location = new System.Drawing.Point(0, 0);
            this.tlp_EncabezadoPedidos.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_EncabezadoPedidos.Name = "tlp_EncabezadoPedidos";
            this.tlp_EncabezadoPedidos.RowCount = 1;
            this.tlp_EncabezadoPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_EncabezadoPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tlp_EncabezadoPedidos.Size = new System.Drawing.Size(653, 52);
            this.tlp_EncabezadoPedidos.TabIndex = 4;
            // 
            // lbl_EncabezadoPedidos
            // 
            this.lbl_EncabezadoPedidos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_EncabezadoPedidos.AutoSize = true;
            this.lbl_EncabezadoPedidos.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_EncabezadoPedidos.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_EncabezadoPedidos.Location = new System.Drawing.Point(60, 13);
            this.lbl_EncabezadoPedidos.Margin = new System.Windows.Forms.Padding(9, 0, 3, 9);
            this.lbl_EncabezadoPedidos.Name = "lbl_EncabezadoPedidos";
            this.lbl_EncabezadoPedidos.Size = new System.Drawing.Size(195, 30);
            this.lbl_EncabezadoPedidos.TabIndex = 3;
            this.lbl_EncabezadoPedidos.Text = "lbl_ListadoPedidos";
            this.lbl_EncabezadoPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dgv_ListadoPedidos
            // 
            this.dgv_ListadoPedidos.AllowUserToAddRows = false;
            this.dgv_ListadoPedidos.AllowUserToDeleteRows = false;
            this.dgv_ListadoPedidos.AllowUserToOrderColumns = true;
            this.dgv_ListadoPedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_ListadoPedidos.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_ListadoPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListadoPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ListadoPedidos.Location = new System.Drawing.Point(0, 56);
            this.dgv_ListadoPedidos.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.dgv_ListadoPedidos.Name = "dgv_ListadoPedidos";
            this.dgv_ListadoPedidos.ReadOnly = true;
            this.dgv_ListadoPedidos.RowHeadersWidth = 25;
            this.dgv_ListadoPedidos.RowTemplate.Height = 25;
            this.dgv_ListadoPedidos.Size = new System.Drawing.Size(653, 202);
            this.dgv_ListadoPedidos.TabIndex = 5;
            this.dgv_ListadoPedidos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ListadoPedidos_CellDoubleClick);
            // 
            // tlp_DetallePedido
            // 
            this.tlp_DetallePedido.ColumnCount = 1;
            this.tlp_DetallePedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_DetallePedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlp_DetallePedido.Controls.Add(this.dgv_DetallePedido, 0, 2);
            this.tlp_DetallePedido.Controls.Add(this.lbl_Nota, 0, 0);
            this.tlp_DetallePedido.Controls.Add(this.tlp_EncabezadoDetallePedido, 0, 1);
            this.tlp_DetallePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_DetallePedido.Location = new System.Drawing.Point(17, 284);
            this.tlp_DetallePedido.Margin = new System.Windows.Forms.Padding(0, 9, 0, 0);
            this.tlp_DetallePedido.Name = "tlp_DetallePedido";
            this.tlp_DetallePedido.RowCount = 3;
            this.tlp_DetallePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlp_DetallePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp_DetallePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_DetallePedido.Size = new System.Drawing.Size(653, 249);
            this.tlp_DetallePedido.TabIndex = 1;
            // 
            // dgv_DetallePedido
            // 
            this.dgv_DetallePedido.AllowUserToAddRows = false;
            this.dgv_DetallePedido.AllowUserToDeleteRows = false;
            this.dgv_DetallePedido.AllowUserToOrderColumns = true;
            this.dgv_DetallePedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv_DetallePedido.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgv_DetallePedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DetallePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DetallePedido.Location = new System.Drawing.Point(0, 73);
            this.dgv_DetallePedido.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.dgv_DetallePedido.Name = "dgv_DetallePedido";
            this.dgv_DetallePedido.ReadOnly = true;
            this.dgv_DetallePedido.RowHeadersWidth = 25;
            this.dgv_DetallePedido.RowTemplate.Height = 25;
            this.dgv_DetallePedido.Size = new System.Drawing.Size(653, 176);
            this.dgv_DetallePedido.TabIndex = 6;
            // 
            // lbl_Nota
            // 
            this.lbl_Nota.AutoSize = true;
            this.lbl_Nota.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_Nota.Location = new System.Drawing.Point(3, 0);
            this.lbl_Nota.Name = "lbl_Nota";
            this.lbl_Nota.Size = new System.Drawing.Size(281, 26);
            this.lbl_Nota.TabIndex = 0;
            this.lbl_Nota.Text = "* Doble clic en un pedido para ver el contenido del pedido";
            this.lbl_Nota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_EncabezadoDetallePedido
            // 
            this.tlp_EncabezadoDetallePedido.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlp_EncabezadoDetallePedido.ColumnCount = 1;
            this.tlp_EncabezadoDetallePedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_EncabezadoDetallePedido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlp_EncabezadoDetallePedido.Controls.Add(this.lbl_EncabezadoDetallePedido, 0, 0);
            this.tlp_EncabezadoDetallePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_EncabezadoDetallePedido.Location = new System.Drawing.Point(0, 26);
            this.tlp_EncabezadoDetallePedido.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_EncabezadoDetallePedido.Name = "tlp_EncabezadoDetallePedido";
            this.tlp_EncabezadoDetallePedido.RowCount = 1;
            this.tlp_EncabezadoDetallePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_EncabezadoDetallePedido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp_EncabezadoDetallePedido.Size = new System.Drawing.Size(653, 43);
            this.tlp_EncabezadoDetallePedido.TabIndex = 1;
            // 
            // lbl_EncabezadoDetallePedido
            // 
            this.lbl_EncabezadoDetallePedido.AutoSize = true;
            this.lbl_EncabezadoDetallePedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_EncabezadoDetallePedido.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_EncabezadoDetallePedido.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_EncabezadoDetallePedido.Location = new System.Drawing.Point(0, 0);
            this.lbl_EncabezadoDetallePedido.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_EncabezadoDetallePedido.Name = "lbl_EncabezadoDetallePedido";
            this.lbl_EncabezadoDetallePedido.Size = new System.Drawing.Size(653, 43);
            this.lbl_EncabezadoDetallePedido.TabIndex = 4;
            this.lbl_EncabezadoDetallePedido.Text = "Líneas de pedido";
            this.lbl_EncabezadoDetallePedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PedidosUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.tlp_BasePedidos);
            this.Name = "PedidosUC";
            this.Size = new System.Drawing.Size(687, 560);
            this.Load += new System.EventHandler(this.PedidosUC_Load);
            this.tlp_BasePedidos.ResumeLayout(false);
            this.tlp_ListadoPedidos.ResumeLayout(false);
            this.tlp_EncabezadoPedidos.ResumeLayout(false);
            this.tlp_EncabezadoPedidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListadoPedidos)).EndInit();
            this.tlp_DetallePedido.ResumeLayout(false);
            this.tlp_DetallePedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DetallePedido)).EndInit();
            this.tlp_EncabezadoDetallePedido.ResumeLayout(false);
            this.tlp_EncabezadoDetallePedido.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_BasePedidos;
        private TableLayoutPanel tlp_ListadoPedidos;
        private TableLayoutPanel tlp_EncabezadoPedidos;
        private Label lbl_EncabezadoPedidos;
        private PictureBox pictureBox1;
        private DataGridView dgv_ListadoPedidos;
        private TableLayoutPanel tlp_DetallePedido;
        private DataGridView dgv_DetallePedido;
        private Label lbl_Nota;
        private TableLayoutPanel tlp_EncabezadoDetallePedido;
        private Label lbl_EncabezadoDetallePedido;
        private ToolTip tt_MensajePedidos;
    }
}
