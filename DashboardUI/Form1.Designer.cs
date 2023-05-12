using System.Windows.Forms;

namespace DashboardUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlp_Base = new System.Windows.Forms.TableLayoutPanel();
            this.picB_Logo = new System.Windows.Forms.PictureBox();
            this.tlp_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Pedidos = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Pedidos = new System.Windows.Forms.Button();
            this.picB_Pedidos = new System.Windows.Forms.PictureBox();
            this.tlp_Info = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Info = new System.Windows.Forms.Button();
            this.picB_Info = new System.Windows.Forms.PictureBox();
            this.tlp_General = new System.Windows.Forms.TableLayoutPanel();
            this.picB_General = new System.Windows.Forms.PictureBox();
            this.btn_General = new System.Windows.Forms.Button();
            this.tlp_Resto = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Reportes = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_Reportes = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_Filtros = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_FiltroCliente = new System.Windows.Forms.TableLayoutPanel();
            this.cB_FiltroCliente = new System.Windows.Forms.ComboBox();
            this.lbl_FiltroCliente = new System.Windows.Forms.Label();
            this.tlp_FiltroPais = new System.Windows.Forms.TableLayoutPanel();
            this.cB_FiltroPais = new System.Windows.Forms.ComboBox();
            this.lbl_FiltroPais = new System.Windows.Forms.Label();
            this.lbl_Filtrado = new System.Windows.Forms.Label();
            this.tlp_Busqueda = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_Busqueda = new System.Windows.Forms.Label();
            this.cb_Busqueda = new System.Windows.Forms.ComboBox();
            this.ms_MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmi_NorthWind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Inicio = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ProductoCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_PedidosPeriodo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ProductosVendidos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_Ayuda = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_ManualUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_AcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tt_Mensaje = new System.Windows.Forms.ToolTip(this.components);
            this.tlp_Base.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).BeginInit();
            this.tlp_Menu.SuspendLayout();
            this.tlp_Pedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pedidos)).BeginInit();
            this.tlp_Info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Info)).BeginInit();
            this.tlp_General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_General)).BeginInit();
            this.tlp_Reportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tlp_Filtros.SuspendLayout();
            this.tlp_FiltroCliente.SuspendLayout();
            this.tlp_FiltroPais.SuspendLayout();
            this.tlp_Busqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ms_MenuPrincipal.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Base
            // 
            this.tlp_Base.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlp_Base.ColumnCount = 2;
            this.tlp_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.43651F));
            this.tlp_Base.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.56349F));
            this.tlp_Base.Controls.Add(this.picB_Logo, 0, 1);
            this.tlp_Base.Controls.Add(this.tlp_Menu, 0, 2);
            this.tlp_Base.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tlp_Base.Controls.Add(this.ms_MenuPrincipal, 0, 0);
            this.tlp_Base.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Base.Location = new System.Drawing.Point(0, 0);
            this.tlp_Base.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Base.Name = "tlp_Base";
            this.tlp_Base.RowCount = 3;
            this.tlp_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tlp_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.52263F));
            this.tlp_Base.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.47737F));
            this.tlp_Base.Size = new System.Drawing.Size(864, 632);
            this.tlp_Base.TabIndex = 0;
            // 
            // picB_Logo
            // 
            this.picB_Logo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.picB_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_Logo.BackgroundImage")));
            this.picB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_Logo.Location = new System.Drawing.Point(0, 24);
            this.picB_Logo.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.picB_Logo.Name = "picB_Logo";
            this.picB_Logo.Size = new System.Drawing.Size(176, 68);
            this.picB_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picB_Logo.TabIndex = 0;
            this.picB_Logo.TabStop = false;
            // 
            // tlp_Menu
            // 
            this.tlp_Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlp_Menu.ColumnCount = 1;
            this.tlp_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Menu.Controls.Add(this.tlp_Pedidos, 0, 2);
            this.tlp_Menu.Controls.Add(this.tlp_Info, 0, 1);
            this.tlp_Menu.Controls.Add(this.tlp_General, 0, 0);
            this.tlp_Menu.Controls.Add(this.tlp_Resto, 0, 4);
            this.tlp_Menu.Controls.Add(this.tlp_Reportes, 0, 3);
            this.tlp_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Menu.Location = new System.Drawing.Point(0, 94);
            this.tlp_Menu.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Menu.Name = "tlp_Menu";
            this.tlp_Menu.RowCount = 5;
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Menu.Size = new System.Drawing.Size(176, 538);
            this.tlp_Menu.TabIndex = 1;
            // 
            // tlp_Pedidos
            // 
            this.tlp_Pedidos.BackColor = System.Drawing.SystemColors.Highlight;
            this.tlp_Pedidos.ColumnCount = 2;
            this.tlp_Pedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp_Pedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Pedidos.Controls.Add(this.btn_Pedidos, 1, 0);
            this.tlp_Pedidos.Controls.Add(this.picB_Pedidos, 0, 0);
            this.tlp_Pedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Pedidos.Location = new System.Drawing.Point(0, 106);
            this.tlp_Pedidos.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tlp_Pedidos.Name = "tlp_Pedidos";
            this.tlp_Pedidos.RowCount = 1;
            this.tlp_Pedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Pedidos.Size = new System.Drawing.Size(176, 51);
            this.tlp_Pedidos.TabIndex = 4;
            // 
            // btn_Pedidos
            // 
            this.btn_Pedidos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Pedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pedidos.FlatAppearance.BorderSize = 0;
            this.btn_Pedidos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Pedidos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Pedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pedidos.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Pedidos.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Pedidos.Location = new System.Drawing.Point(46, 3);
            this.btn_Pedidos.Name = "btn_Pedidos";
            this.btn_Pedidos.Size = new System.Drawing.Size(127, 45);
            this.btn_Pedidos.TabIndex = 0;
            this.btn_Pedidos.Text = "Pedidos";
            this.btn_Pedidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pedidos.UseVisualStyleBackColor = true;
            this.btn_Pedidos.Click += new System.EventHandler(this.btn_Pedidos_Click);
            this.btn_Pedidos.MouseLeave += new System.EventHandler(this.btn_Pedidos_MouseLeave);
            this.btn_Pedidos.MouseHover += new System.EventHandler(this.btn_Pedidos_MouseHover);
            // 
            // picB_Pedidos
            // 
            this.picB_Pedidos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_Pedidos.BackgroundImage")));
            this.picB_Pedidos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_Pedidos.Location = new System.Drawing.Point(13, 13);
            this.picB_Pedidos.Margin = new System.Windows.Forms.Padding(13, 13, 0, 13);
            this.picB_Pedidos.Name = "picB_Pedidos";
            this.picB_Pedidos.Size = new System.Drawing.Size(28, 25);
            this.picB_Pedidos.TabIndex = 1;
            this.picB_Pedidos.TabStop = false;
            // 
            // tlp_Info
            // 
            this.tlp_Info.BackColor = System.Drawing.SystemColors.Highlight;
            this.tlp_Info.ColumnCount = 2;
            this.tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp_Info.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Info.Controls.Add(this.btn_Info, 1, 0);
            this.tlp_Info.Controls.Add(this.picB_Info, 0, 0);
            this.tlp_Info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Info.Location = new System.Drawing.Point(0, 53);
            this.tlp_Info.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tlp_Info.Name = "tlp_Info";
            this.tlp_Info.RowCount = 1;
            this.tlp_Info.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Info.Size = new System.Drawing.Size(176, 51);
            this.tlp_Info.TabIndex = 3;
            // 
            // btn_Info
            // 
            this.btn_Info.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Info.FlatAppearance.BorderSize = 0;
            this.btn_Info.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Info.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Info.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Info.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Info.Location = new System.Drawing.Point(46, 3);
            this.btn_Info.Name = "btn_Info";
            this.btn_Info.Size = new System.Drawing.Size(127, 45);
            this.btn_Info.TabIndex = 0;
            this.btn_Info.Text = "Info Cliente";
            this.btn_Info.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Info.UseVisualStyleBackColor = true;
            this.btn_Info.Click += new System.EventHandler(this.btn_Info_Click);
            this.btn_Info.MouseLeave += new System.EventHandler(this.btn_Info_MouseLeave);
            this.btn_Info.MouseHover += new System.EventHandler(this.btn_Info_MouseHover);
            // 
            // picB_Info
            // 
            this.picB_Info.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_Info.BackgroundImage")));
            this.picB_Info.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_Info.Location = new System.Drawing.Point(13, 13);
            this.picB_Info.Margin = new System.Windows.Forms.Padding(13, 13, 0, 13);
            this.picB_Info.Name = "picB_Info";
            this.picB_Info.Size = new System.Drawing.Size(29, 25);
            this.picB_Info.TabIndex = 1;
            this.picB_Info.TabStop = false;
            // 
            // tlp_General
            // 
            this.tlp_General.BackColor = System.Drawing.SystemColors.Highlight;
            this.tlp_General.ColumnCount = 2;
            this.tlp_General.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp_General.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_General.Controls.Add(this.picB_General, 0, 0);
            this.tlp_General.Controls.Add(this.btn_General, 1, 0);
            this.tlp_General.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_General.Location = new System.Drawing.Point(0, 0);
            this.tlp_General.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tlp_General.Name = "tlp_General";
            this.tlp_General.RowCount = 1;
            this.tlp_General.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_General.Size = new System.Drawing.Size(176, 51);
            this.tlp_General.TabIndex = 2;
            // 
            // picB_General
            // 
            this.picB_General.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_General.BackgroundImage")));
            this.picB_General.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_General.Location = new System.Drawing.Point(13, 13);
            this.picB_General.Margin = new System.Windows.Forms.Padding(13, 13, 0, 13);
            this.picB_General.Name = "picB_General";
            this.picB_General.Size = new System.Drawing.Size(29, 25);
            this.picB_General.TabIndex = 1;
            this.picB_General.TabStop = false;
            // 
            // btn_General
            // 
            this.btn_General.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_General.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_General.FlatAppearance.BorderSize = 0;
            this.btn_General.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_General.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_General.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_General.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_General.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_General.Location = new System.Drawing.Point(47, 3);
            this.btn_General.Name = "btn_General";
            this.btn_General.Size = new System.Drawing.Size(126, 45);
            this.btn_General.TabIndex = 0;
            this.btn_General.Text = "General";
            this.btn_General.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_General.UseVisualStyleBackColor = true;
            this.btn_General.Click += new System.EventHandler(this.btn_General_Click);
            this.btn_General.MouseLeave += new System.EventHandler(this.btn_General_MouseLeave);
            this.btn_General.MouseHover += new System.EventHandler(this.btn_General_MouseHover);
            // 
            // tlp_Resto
            // 
            this.tlp_Resto.BackColor = System.Drawing.SystemColors.Highlight;
            this.tlp_Resto.ColumnCount = 1;
            this.tlp_Resto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Resto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlp_Resto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Resto.Location = new System.Drawing.Point(0, 212);
            this.tlp_Resto.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Resto.Name = "tlp_Resto";
            this.tlp_Resto.RowCount = 1;
            this.tlp_Resto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Resto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 326F));
            this.tlp_Resto.Size = new System.Drawing.Size(176, 326);
            this.tlp_Resto.TabIndex = 5;
            // 
            // tlp_Reportes
            // 
            this.tlp_Reportes.BackColor = System.Drawing.SystemColors.Highlight;
            this.tlp_Reportes.ColumnCount = 2;
            this.tlp_Reportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp_Reportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Reportes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Reportes.Controls.Add(this.pictureBox3, 0, 0);
            this.tlp_Reportes.Controls.Add(this.btn_Reportes, 1, 0);
            this.tlp_Reportes.Location = new System.Drawing.Point(0, 159);
            this.tlp_Reportes.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tlp_Reportes.Name = "tlp_Reportes";
            this.tlp_Reportes.RowCount = 1;
            this.tlp_Reportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Reportes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tlp_Reportes.Size = new System.Drawing.Size(176, 50);
            this.tlp_Reportes.TabIndex = 6;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 13);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(13, 13, 0, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 24);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btn_Reportes
            // 
            this.btn_Reportes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Reportes.FlatAppearance.BorderSize = 0;
            this.btn_Reportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_Reportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_Reportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reportes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btn_Reportes.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_Reportes.Location = new System.Drawing.Point(46, 3);
            this.btn_Reportes.Name = "btn_Reportes";
            this.btn_Reportes.Size = new System.Drawing.Size(127, 44);
            this.btn_Reportes.TabIndex = 1;
            this.btn_Reportes.Text = "Reportes";
            this.btn_Reportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Reportes.UseVisualStyleBackColor = true;
            this.btn_Reportes.Click += new System.EventHandler(this.btn_Reportes_Click);
            this.btn_Reportes.MouseLeave += new System.EventHandler(this.btn_Reportes_MouseLeave);
            this.btn_Reportes.MouseHover += new System.EventHandler(this.btn_Reportes_MouseHover);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.55232F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.44767F));
            this.tableLayoutPanel2.Controls.Add(this.tlp_Filtros, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tlp_Busqueda, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(176, 24);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(688, 68);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tlp_Filtros
            // 
            this.tlp_Filtros.ColumnCount = 2;
            this.tlp_Filtros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlp_Filtros.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_Filtros.Controls.Add(this.tlp_FiltroCliente, 1, 1);
            this.tlp_Filtros.Controls.Add(this.tlp_FiltroPais, 0, 1);
            this.tlp_Filtros.Controls.Add(this.lbl_Filtrado, 0, 0);
            this.tlp_Filtros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Filtros.Location = new System.Drawing.Point(0, 0);
            this.tlp_Filtros.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Filtros.Name = "tlp_Filtros";
            this.tlp_Filtros.RowCount = 2;
            this.tlp_Filtros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Filtros.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Filtros.Size = new System.Drawing.Size(451, 68);
            this.tlp_Filtros.TabIndex = 0;
            // 
            // tlp_FiltroCliente
            // 
            this.tlp_FiltroCliente.ColumnCount = 2;
            this.tlp_FiltroCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tlp_FiltroCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tlp_FiltroCliente.Controls.Add(this.cB_FiltroCliente, 1, 0);
            this.tlp_FiltroCliente.Controls.Add(this.lbl_FiltroCliente, 0, 0);
            this.tlp_FiltroCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_FiltroCliente.Location = new System.Drawing.Point(180, 34);
            this.tlp_FiltroCliente.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_FiltroCliente.Name = "tlp_FiltroCliente";
            this.tlp_FiltroCliente.RowCount = 1;
            this.tlp_FiltroCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_FiltroCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlp_FiltroCliente.Size = new System.Drawing.Size(271, 34);
            this.tlp_FiltroCliente.TabIndex = 1;
            // 
            // cB_FiltroCliente
            // 
            this.cB_FiltroCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cB_FiltroCliente.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cB_FiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_FiltroCliente.ForeColor = System.Drawing.SystemColors.Info;
            this.cB_FiltroCliente.FormattingEnabled = true;
            this.cB_FiltroCliente.Location = new System.Drawing.Point(68, 3);
            this.cB_FiltroCliente.Margin = new System.Windows.Forms.Padding(3, 3, 18, 18);
            this.cB_FiltroCliente.Name = "cB_FiltroCliente";
            this.cB_FiltroCliente.Size = new System.Drawing.Size(185, 23);
            this.cB_FiltroCliente.TabIndex = 0;
            this.cB_FiltroCliente.SelectedIndexChanged += new System.EventHandler(this.cB_FiltroCliente_SelectedIndexChanged);
            // 
            // lbl_FiltroCliente
            // 
            this.lbl_FiltroCliente.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_FiltroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltroCliente.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_FiltroCliente.Location = new System.Drawing.Point(3, 0);
            this.lbl_FiltroCliente.Margin = new System.Windows.Forms.Padding(3, 0, 3, 18);
            this.lbl_FiltroCliente.Name = "lbl_FiltroCliente";
            this.lbl_FiltroCliente.Size = new System.Drawing.Size(58, 16);
            this.lbl_FiltroCliente.TabIndex = 1;
            this.lbl_FiltroCliente.Text = "Cliente";
            this.lbl_FiltroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlp_FiltroPais
            // 
            this.tlp_FiltroPais.ColumnCount = 2;
            this.tlp_FiltroPais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.55556F));
            this.tlp_FiltroPais.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.44444F));
            this.tlp_FiltroPais.Controls.Add(this.cB_FiltroPais, 1, 0);
            this.tlp_FiltroPais.Controls.Add(this.lbl_FiltroPais, 0, 0);
            this.tlp_FiltroPais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_FiltroPais.Location = new System.Drawing.Point(0, 34);
            this.tlp_FiltroPais.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_FiltroPais.Name = "tlp_FiltroPais";
            this.tlp_FiltroPais.RowCount = 1;
            this.tlp_FiltroPais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_FiltroPais.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tlp_FiltroPais.Size = new System.Drawing.Size(180, 34);
            this.tlp_FiltroPais.TabIndex = 0;
            // 
            // cB_FiltroPais
            // 
            this.cB_FiltroPais.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cB_FiltroPais.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cB_FiltroPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_FiltroPais.ForeColor = System.Drawing.SystemColors.Info;
            this.cB_FiltroPais.FormattingEnabled = true;
            this.cB_FiltroPais.Location = new System.Drawing.Point(59, 3);
            this.cB_FiltroPais.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
            this.cB_FiltroPais.Name = "cB_FiltroPais";
            this.cB_FiltroPais.Size = new System.Drawing.Size(118, 23);
            this.cB_FiltroPais.TabIndex = 0;
            this.cB_FiltroPais.SelectedIndexChanged += new System.EventHandler(this.cB_FiltroPais_SelectedIndexChanged);
            // 
            // lbl_FiltroPais
            // 
            this.lbl_FiltroPais.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lbl_FiltroPais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FiltroPais.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_FiltroPais.Location = new System.Drawing.Point(3, 0);
            this.lbl_FiltroPais.Margin = new System.Windows.Forms.Padding(3, 0, 3, 18);
            this.lbl_FiltroPais.Name = "lbl_FiltroPais";
            this.lbl_FiltroPais.Size = new System.Drawing.Size(50, 16);
            this.lbl_FiltroPais.TabIndex = 1;
            this.lbl_FiltroPais.Text = "País";
            this.lbl_FiltroPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Filtrado
            // 
            this.lbl_Filtrado.AutoSize = true;
            this.tlp_Filtros.SetColumnSpan(this.lbl_Filtrado, 2);
            this.lbl_Filtrado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Filtrado.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Filtrado.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Filtrado.Location = new System.Drawing.Point(3, 0);
            this.lbl_Filtrado.Name = "lbl_Filtrado";
            this.lbl_Filtrado.Size = new System.Drawing.Size(445, 34);
            this.lbl_Filtrado.TabIndex = 2;
            this.lbl_Filtrado.Text = "Filtrado de clientes";
            this.lbl_Filtrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tlp_Busqueda
            // 
            this.tlp_Busqueda.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tlp_Busqueda.ColumnCount = 2;
            this.tlp_Busqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.36975F));
            this.tlp_Busqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.63025F));
            this.tlp_Busqueda.Controls.Add(this.pictureBox2, 0, 1);
            this.tlp_Busqueda.Controls.Add(this.lbl_Busqueda, 0, 0);
            this.tlp_Busqueda.Controls.Add(this.cb_Busqueda, 1, 1);
            this.tlp_Busqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Busqueda.Location = new System.Drawing.Point(451, 0);
            this.tlp_Busqueda.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_Busqueda.Name = "tlp_Busqueda";
            this.tlp_Busqueda.RowCount = 2;
            this.tlp_Busqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Busqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Busqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_Busqueda.Size = new System.Drawing.Size(237, 68);
            this.tlp_Busqueda.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(30, 37);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 21);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_Busqueda
            // 
            this.lbl_Busqueda.AutoSize = true;
            this.tlp_Busqueda.SetColumnSpan(this.lbl_Busqueda, 2);
            this.lbl_Busqueda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Busqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Busqueda.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Busqueda.Location = new System.Drawing.Point(3, 0);
            this.lbl_Busqueda.Name = "lbl_Busqueda";
            this.lbl_Busqueda.Size = new System.Drawing.Size(231, 34);
            this.lbl_Busqueda.TabIndex = 3;
            this.lbl_Busqueda.Text = "Búsqueda de clientes";
            this.lbl_Busqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_Busqueda
            // 
            this.cb_Busqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Busqueda.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cb_Busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Busqueda.ForeColor = System.Drawing.SystemColors.Info;
            this.cb_Busqueda.FormattingEnabled = true;
            this.cb_Busqueda.Location = new System.Drawing.Point(60, 37);
            this.cb_Busqueda.Margin = new System.Windows.Forms.Padding(3, 3, 18, 18);
            this.cb_Busqueda.Name = "cb_Busqueda";
            this.cb_Busqueda.Size = new System.Drawing.Size(159, 23);
            this.cb_Busqueda.TabIndex = 2;
            this.cb_Busqueda.SelectedIndexChanged += new System.EventHandler(this.cb_Busqueda_SelectedIndexChanged);
            this.cb_Busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Busqueda_KeyPress);
            // 
            // ms_MenuPrincipal
            // 
            this.tlp_Base.SetColumnSpan(this.ms_MenuPrincipal, 2);
            this.ms_MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_NorthWind,
            this.tsmi_Ayuda});
            this.ms_MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.ms_MenuPrincipal.Name = "ms_MenuPrincipal";
            this.ms_MenuPrincipal.Size = new System.Drawing.Size(864, 24);
            this.ms_MenuPrincipal.TabIndex = 3;
            this.ms_MenuPrincipal.Text = "menuStrip1";
            // 
            // tsmi_NorthWind
            // 
            this.tsmi_NorthWind.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_Inicio,
            this.tsmi_Reportes});
            this.tsmi_NorthWind.Name = "tsmi_NorthWind";
            this.tsmi_NorthWind.Size = new System.Drawing.Size(78, 20);
            this.tsmi_NorthWind.Text = "NorthWind";
            // 
            // tsmi_Inicio
            // 
            this.tsmi_Inicio.Name = "tsmi_Inicio";
            this.tsmi_Inicio.Size = new System.Drawing.Size(120, 22);
            this.tsmi_Inicio.Text = "Inicio";
            this.tsmi_Inicio.Click += new System.EventHandler(this.tsmi_Inicio_Click);
            // 
            // tsmi_Reportes
            // 
            this.tsmi_Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ProductoCategoria,
            this.tsmi_PedidosPeriodo,
            this.tsmi_ProductosVendidos});
            this.tsmi_Reportes.Name = "tsmi_Reportes";
            this.tsmi_Reportes.Size = new System.Drawing.Size(120, 22);
            this.tsmi_Reportes.Text = "Reportes";
            // 
            // tsmi_ProductoCategoria
            // 
            this.tsmi_ProductoCategoria.Name = "tsmi_ProductoCategoria";
            this.tsmi_ProductoCategoria.Size = new System.Drawing.Size(204, 22);
            this.tsmi_ProductoCategoria.Text = "Producto por categoría";
            this.tsmi_ProductoCategoria.Click += new System.EventHandler(this.tsmi_ProductoCategoria_Click);
            // 
            // tsmi_PedidosPeriodo
            // 
            this.tsmi_PedidosPeriodo.Name = "tsmi_PedidosPeriodo";
            this.tsmi_PedidosPeriodo.Size = new System.Drawing.Size(204, 22);
            this.tsmi_PedidosPeriodo.Text = "Pedidos por periodo";
            this.tsmi_PedidosPeriodo.Click += new System.EventHandler(this.tsmi_PedidosPeriodo_Click);
            // 
            // tsmi_ProductosVendidos
            // 
            this.tsmi_ProductosVendidos.Name = "tsmi_ProductosVendidos";
            this.tsmi_ProductosVendidos.Size = new System.Drawing.Size(204, 22);
            this.tsmi_ProductosVendidos.Text = "Productos más vendidos";
            this.tsmi_ProductosVendidos.Click += new System.EventHandler(this.tsmi_ProductosVendidos_Click);
            // 
            // tsmi_Ayuda
            // 
            this.tsmi_Ayuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_ManualUsuario,
            this.tsmi_AcercaDe});
            this.tsmi_Ayuda.Name = "tsmi_Ayuda";
            this.tsmi_Ayuda.Size = new System.Drawing.Size(53, 20);
            this.tsmi_Ayuda.Text = "Ayuda";
            // 
            // tsmi_ManualUsuario
            // 
            this.tsmi_ManualUsuario.Name = "tsmi_ManualUsuario";
            this.tsmi_ManualUsuario.Size = new System.Drawing.Size(180, 22);
            this.tsmi_ManualUsuario.Text = "Manual de Usuario";
            this.tsmi_ManualUsuario.Click += new System.EventHandler(this.tsmi_ManualUsuario_Click);
            // 
            // tsmi_AcercaDe
            // 
            this.tsmi_AcercaDe.Name = "tsmi_AcercaDe";
            this.tsmi_AcercaDe.Size = new System.Drawing.Size(180, 22);
            this.tsmi_AcercaDe.Text = "Acerca de";
            this.tsmi_AcercaDe.Click += new System.EventHandler(this.tsmi_AcercaDe_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(67, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "Info Cliente";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(15, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 632);
            this.Controls.Add(this.tlp_Base);
            this.MainMenuStrip = this.ms_MenuPrincipal;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tlp_Base.ResumeLayout(false);
            this.tlp_Base.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).EndInit();
            this.tlp_Menu.ResumeLayout(false);
            this.tlp_Pedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_Pedidos)).EndInit();
            this.tlp_Info.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_Info)).EndInit();
            this.tlp_General.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picB_General)).EndInit();
            this.tlp_Reportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tlp_Filtros.ResumeLayout(false);
            this.tlp_Filtros.PerformLayout();
            this.tlp_FiltroCliente.ResumeLayout(false);
            this.tlp_FiltroPais.ResumeLayout(false);
            this.tlp_Busqueda.ResumeLayout(false);
            this.tlp_Busqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ms_MenuPrincipal.ResumeLayout(false);
            this.ms_MenuPrincipal.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tlp_Base;
        private PictureBox picB_Logo;
        private TableLayoutPanel tlp_Menu;
        private TableLayoutPanel tlp_General;
        private Button btn_General;
        private PictureBox picB_General;
        private TableLayoutPanel tlp_Info;
        private Button btn_Info;
        private PictureBox picB_Info;
        private TableLayoutPanel tlp_Pedidos;
        private Button btn_Pedidos;
        private PictureBox picB_Pedidos;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private PictureBox pictureBox1;
        private TableLayoutPanel tlp_Resto;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tlp_Filtros;
        private TableLayoutPanel tlp_FiltroCliente;
        private ComboBox cB_FiltroCliente;
        private Label lbl_FiltroCliente;
        private TableLayoutPanel tlp_FiltroPais;
        private ComboBox cB_FiltroPais;
        private Label lbl_FiltroPais;
        private TableLayoutPanel tlp_Busqueda;
        private PictureBox pictureBox2;
        private TableLayoutPanel tlp_Reportes;
        private PictureBox pictureBox3;
        private Button btn_Reportes;
        private ComboBox cb_Busqueda;
        private Label lbl_Filtrado;
        private Label lbl_Busqueda;
        private ToolTip tt_Mensaje;
        private MenuStrip ms_MenuPrincipal;
        private ToolStripMenuItem tsmi_NorthWind;
        private ToolStripMenuItem tsmi_Ayuda;
        private ToolStripMenuItem tsmi_Inicio;
        private ToolStripMenuItem tsmi_Reportes;
        private ToolStripMenuItem tsmi_ProductoCategoria;
        private ToolStripMenuItem tsmi_PedidosPeriodo;
        private ToolStripMenuItem tsmi_ProductosVendidos;
        private ToolStripMenuItem tsmi_ManualUsuario;
        private ToolStripMenuItem tsmi_AcercaDe;
    }
}