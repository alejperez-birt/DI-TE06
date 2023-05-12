using System.Windows.Forms;

namespace DashboardUI.ControlesUsuario
{
    partial class InfoClienteUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoClienteUC));
            this.picB_Cliente = new System.Windows.Forms.PictureBox();
            this.lbl_NombreEmpresa = new System.Windows.Forms.Label();
            this.tlp_BaseInfoCliente = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_EncabezadoInfoCliente = new System.Windows.Forms.TableLayoutPanel();
            this.tlp_ContenidoInfoCliente = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Fax = new System.Windows.Forms.Label();
            this.lbl_ContenidoFax = new System.Windows.Forms.Label();
            this.lbl_PersonaContacto = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Pais = new System.Windows.Forms.Label();
            this.lbl_Region = new System.Windows.Forms.Label();
            this.lbl_CodigoPostal = new System.Windows.Forms.Label();
            this.lbl_Poblacion = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Cargo = new System.Windows.Forms.Label();
            this.lbl_ContenidoPersonaContacto = new System.Windows.Forms.Label();
            this.lbl_ContenidoCargo = new System.Windows.Forms.Label();
            this.lbl_ContenidoDireccion = new System.Windows.Forms.Label();
            this.lbl_ContenidoPoblacion = new System.Windows.Forms.Label();
            this.lbl_ContenidoRegion = new System.Windows.Forms.Label();
            this.lbl_ContenidoCodigoPostal = new System.Windows.Forms.Label();
            this.lbl_ContenidoPais = new System.Windows.Forms.Label();
            this.lbl_ContenidoTelefono = new System.Windows.Forms.Label();
            this.tt_MensajeInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picB_Cliente)).BeginInit();
            this.tlp_BaseInfoCliente.SuspendLayout();
            this.tlp_EncabezadoInfoCliente.SuspendLayout();
            this.tlp_ContenidoInfoCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // picB_Cliente
            // 
            this.picB_Cliente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picB_Cliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_Cliente.BackgroundImage")));
            this.picB_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picB_Cliente.InitialImage = null;
            this.picB_Cliente.Location = new System.Drawing.Point(87, 9);
            this.picB_Cliente.Margin = new System.Windows.Forms.Padding(0);
            this.picB_Cliente.Name = "picB_Cliente";
            this.picB_Cliente.Size = new System.Drawing.Size(64, 65);
            this.picB_Cliente.TabIndex = 1;
            this.picB_Cliente.TabStop = false;
            // 
            // lbl_NombreEmpresa
            // 
            this.lbl_NombreEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_NombreEmpresa.AutoSize = true;
            this.lbl_NombreEmpresa.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NombreEmpresa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_NombreEmpresa.Location = new System.Drawing.Point(160, 35);
            this.lbl_NombreEmpresa.Margin = new System.Windows.Forms.Padding(9, 0, 3, 9);
            this.lbl_NombreEmpresa.Name = "lbl_NombreEmpresa";
            this.lbl_NombreEmpresa.Size = new System.Drawing.Size(210, 30);
            this.lbl_NombreEmpresa.TabIndex = 2;
            this.lbl_NombreEmpresa.Text = "lbl_NombreEmpresa";
            this.lbl_NombreEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_BaseInfoCliente
            // 
            this.tlp_BaseInfoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlp_BaseInfoCliente.ColumnCount = 1;
            this.tlp_BaseInfoCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_BaseInfoCliente.Controls.Add(this.tlp_EncabezadoInfoCliente, 0, 0);
            this.tlp_BaseInfoCliente.Controls.Add(this.tlp_ContenidoInfoCliente, 0, 1);
            this.tlp_BaseInfoCliente.Location = new System.Drawing.Point(0, 0);
            this.tlp_BaseInfoCliente.Margin = new System.Windows.Forms.Padding(0);
            this.tlp_BaseInfoCliente.Name = "tlp_BaseInfoCliente";
            this.tlp_BaseInfoCliente.Padding = new System.Windows.Forms.Padding(17);
            this.tlp_BaseInfoCliente.RowCount = 3;
            this.tlp_BaseInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tlp_BaseInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_BaseInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlp_BaseInfoCliente.Size = new System.Drawing.Size(687, 560);
            this.tlp_BaseInfoCliente.TabIndex = 3;
            // 
            // tlp_EncabezadoInfoCliente
            // 
            this.tlp_EncabezadoInfoCliente.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.tlp_EncabezadoInfoCliente.ColumnCount = 2;
            this.tlp_EncabezadoInfoCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 142F));
            this.tlp_EncabezadoInfoCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_EncabezadoInfoCliente.Controls.Add(this.picB_Cliente, 0, 0);
            this.tlp_EncabezadoInfoCliente.Controls.Add(this.lbl_NombreEmpresa, 1, 0);
            this.tlp_EncabezadoInfoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_EncabezadoInfoCliente.Location = new System.Drawing.Point(17, 17);
            this.tlp_EncabezadoInfoCliente.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.tlp_EncabezadoInfoCliente.Name = "tlp_EncabezadoInfoCliente";
            this.tlp_EncabezadoInfoCliente.Padding = new System.Windows.Forms.Padding(9);
            this.tlp_EncabezadoInfoCliente.RowCount = 1;
            this.tlp_EncabezadoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_EncabezadoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlp_EncabezadoInfoCliente.Size = new System.Drawing.Size(653, 83);
            this.tlp_EncabezadoInfoCliente.TabIndex = 0;
            // 
            // tlp_ContenidoInfoCliente
            // 
            this.tlp_ContenidoInfoCliente.BackColor = System.Drawing.SystemColors.Info;
            this.tlp_ContenidoInfoCliente.ColumnCount = 2;
            this.tlp_ContenidoInfoCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_ContenidoInfoCliente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_Fax, 0, 8);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_ContenidoFax, 0, 8);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_PersonaContacto, 0, 0);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_Telefono, 0, 7);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_Pais, 0, 6);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_Region, 0, 4);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_CodigoPostal, 0, 5);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_Poblacion, 0, 3);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_Direccion, 0, 2);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_Cargo, 0, 1);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_ContenidoPersonaContacto, 1, 0);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_ContenidoCargo, 1, 1);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_ContenidoDireccion, 1, 2);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_ContenidoPoblacion, 1, 3);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_ContenidoRegion, 1, 4);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_ContenidoCodigoPostal, 1, 5);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_ContenidoPais, 1, 6);
            this.tlp_ContenidoInfoCliente.Controls.Add(this.lbl_ContenidoTelefono, 1, 7);
            this.tlp_ContenidoInfoCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_ContenidoInfoCliente.Location = new System.Drawing.Point(17, 108);
            this.tlp_ContenidoInfoCliente.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tlp_ContenidoInfoCliente.Name = "tlp_ContenidoInfoCliente";
            this.tlp_ContenidoInfoCliente.Padding = new System.Windows.Forms.Padding(9);
            this.tlp_ContenidoInfoCliente.RowCount = 9;
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlp_ContenidoInfoCliente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tlp_ContenidoInfoCliente.Size = new System.Drawing.Size(653, 425);
            this.tlp_ContenidoInfoCliente.TabIndex = 1;
            // 
            // lbl_Fax
            // 
            this.lbl_Fax.AutoSize = true;
            this.lbl_Fax.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Fax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Fax.Location = new System.Drawing.Point(131, 369);
            this.lbl_Fax.Name = "lbl_Fax";
            this.lbl_Fax.Size = new System.Drawing.Size(33, 47);
            this.lbl_Fax.TabIndex = 17;
            this.lbl_Fax.Text = "Fax";
            this.lbl_Fax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ContenidoFax
            // 
            this.lbl_ContenidoFax.AutoSize = true;
            this.lbl_ContenidoFax.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ContenidoFax.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_ContenidoFax.Location = new System.Drawing.Point(170, 369);
            this.lbl_ContenidoFax.Name = "lbl_ContenidoFax";
            this.lbl_ContenidoFax.Size = new System.Drawing.Size(122, 47);
            this.lbl_ContenidoFax.TabIndex = 8;
            this.lbl_ContenidoFax.Text = "lbl_ContenidoFax";
            this.lbl_ContenidoFax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PersonaContacto
            // 
            this.lbl_PersonaContacto.AutoSize = true;
            this.lbl_PersonaContacto.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_PersonaContacto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_PersonaContacto.Location = new System.Drawing.Point(13, 9);
            this.lbl_PersonaContacto.Name = "lbl_PersonaContacto";
            this.lbl_PersonaContacto.Size = new System.Drawing.Size(151, 45);
            this.lbl_PersonaContacto.TabIndex = 0;
            this.lbl_PersonaContacto.Text = "Persona de contacto";
            this.lbl_PersonaContacto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Telefono.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Telefono.Location = new System.Drawing.Point(94, 324);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(70, 45);
            this.lbl_Telefono.TabIndex = 1;
            this.lbl_Telefono.Text = "Teléfono";
            this.lbl_Telefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Pais
            // 
            this.lbl_Pais.AutoSize = true;
            this.lbl_Pais.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Pais.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Pais.Location = new System.Drawing.Point(127, 279);
            this.lbl_Pais.Name = "lbl_Pais";
            this.lbl_Pais.Size = new System.Drawing.Size(37, 45);
            this.lbl_Pais.TabIndex = 2;
            this.lbl_Pais.Text = "País";
            this.lbl_Pais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Region
            // 
            this.lbl_Region.AutoSize = true;
            this.lbl_Region.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Region.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Region.Location = new System.Drawing.Point(106, 189);
            this.lbl_Region.Name = "lbl_Region";
            this.lbl_Region.Size = new System.Drawing.Size(58, 45);
            this.lbl_Region.TabIndex = 3;
            this.lbl_Region.Text = "Región";
            this.lbl_Region.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_CodigoPostal
            // 
            this.lbl_CodigoPostal.AutoSize = true;
            this.lbl_CodigoPostal.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_CodigoPostal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_CodigoPostal.Location = new System.Drawing.Point(59, 234);
            this.lbl_CodigoPostal.Name = "lbl_CodigoPostal";
            this.lbl_CodigoPostal.Size = new System.Drawing.Size(105, 45);
            this.lbl_CodigoPostal.TabIndex = 4;
            this.lbl_CodigoPostal.Text = "Código Postal";
            this.lbl_CodigoPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Poblacion
            // 
            this.lbl_Poblacion.AutoSize = true;
            this.lbl_Poblacion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Poblacion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Poblacion.Location = new System.Drawing.Point(87, 144);
            this.lbl_Poblacion.Name = "lbl_Poblacion";
            this.lbl_Poblacion.Size = new System.Drawing.Size(77, 45);
            this.lbl_Poblacion.TabIndex = 5;
            this.lbl_Poblacion.Text = "Población";
            this.lbl_Poblacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Direccion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Direccion.Location = new System.Drawing.Point(90, 99);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(74, 45);
            this.lbl_Direccion.TabIndex = 6;
            this.lbl_Direccion.Text = "Dirección";
            this.lbl_Direccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Cargo
            // 
            this.lbl_Cargo.AutoSize = true;
            this.lbl_Cargo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbl_Cargo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_Cargo.Location = new System.Drawing.Point(114, 54);
            this.lbl_Cargo.Name = "lbl_Cargo";
            this.lbl_Cargo.Size = new System.Drawing.Size(50, 45);
            this.lbl_Cargo.TabIndex = 7;
            this.lbl_Cargo.Text = "Cargo";
            this.lbl_Cargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ContenidoPersonaContacto
            // 
            this.lbl_ContenidoPersonaContacto.AutoSize = true;
            this.lbl_ContenidoPersonaContacto.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ContenidoPersonaContacto.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_ContenidoPersonaContacto.Location = new System.Drawing.Point(170, 9);
            this.lbl_ContenidoPersonaContacto.Name = "lbl_ContenidoPersonaContacto";
            this.lbl_ContenidoPersonaContacto.Size = new System.Drawing.Size(212, 45);
            this.lbl_ContenidoPersonaContacto.TabIndex = 9;
            this.lbl_ContenidoPersonaContacto.Text = "lbl_ContenidoPersonaContacto";
            this.lbl_ContenidoPersonaContacto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ContenidoCargo
            // 
            this.lbl_ContenidoCargo.AutoSize = true;
            this.lbl_ContenidoCargo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ContenidoCargo.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_ContenidoCargo.Location = new System.Drawing.Point(170, 54);
            this.lbl_ContenidoCargo.Name = "lbl_ContenidoCargo";
            this.lbl_ContenidoCargo.Size = new System.Drawing.Size(141, 45);
            this.lbl_ContenidoCargo.TabIndex = 16;
            this.lbl_ContenidoCargo.Text = "lbl_ContenidoCargo";
            this.lbl_ContenidoCargo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ContenidoDireccion
            // 
            this.lbl_ContenidoDireccion.AutoSize = true;
            this.lbl_ContenidoDireccion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ContenidoDireccion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_ContenidoDireccion.Location = new System.Drawing.Point(170, 99);
            this.lbl_ContenidoDireccion.Name = "lbl_ContenidoDireccion";
            this.lbl_ContenidoDireccion.Size = new System.Drawing.Size(164, 45);
            this.lbl_ContenidoDireccion.TabIndex = 15;
            this.lbl_ContenidoDireccion.Text = "lbl_ContenidoDireccion";
            this.lbl_ContenidoDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ContenidoPoblacion
            // 
            this.lbl_ContenidoPoblacion.AutoSize = true;
            this.lbl_ContenidoPoblacion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ContenidoPoblacion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_ContenidoPoblacion.Location = new System.Drawing.Point(170, 144);
            this.lbl_ContenidoPoblacion.Name = "lbl_ContenidoPoblacion";
            this.lbl_ContenidoPoblacion.Size = new System.Drawing.Size(166, 45);
            this.lbl_ContenidoPoblacion.TabIndex = 14;
            this.lbl_ContenidoPoblacion.Text = "lbl_ContenidoPoblacion";
            this.lbl_ContenidoPoblacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ContenidoRegion
            // 
            this.lbl_ContenidoRegion.AutoSize = true;
            this.lbl_ContenidoRegion.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ContenidoRegion.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_ContenidoRegion.Location = new System.Drawing.Point(170, 189);
            this.lbl_ContenidoRegion.Name = "lbl_ContenidoRegion";
            this.lbl_ContenidoRegion.Size = new System.Drawing.Size(148, 45);
            this.lbl_ContenidoRegion.TabIndex = 12;
            this.lbl_ContenidoRegion.Text = "lbl_ContenidoRegion";
            this.lbl_ContenidoRegion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ContenidoCodigoPostal
            // 
            this.lbl_ContenidoCodigoPostal.AutoSize = true;
            this.lbl_ContenidoCodigoPostal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ContenidoCodigoPostal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_ContenidoCodigoPostal.Location = new System.Drawing.Point(170, 234);
            this.lbl_ContenidoCodigoPostal.Name = "lbl_ContenidoCodigoPostal";
            this.lbl_ContenidoCodigoPostal.Size = new System.Drawing.Size(189, 45);
            this.lbl_ContenidoCodigoPostal.TabIndex = 13;
            this.lbl_ContenidoCodigoPostal.Text = "lbl_ContenidoCodigoPostal";
            this.lbl_ContenidoCodigoPostal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ContenidoPais
            // 
            this.lbl_ContenidoPais.AutoSize = true;
            this.lbl_ContenidoPais.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ContenidoPais.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_ContenidoPais.Location = new System.Drawing.Point(170, 279);
            this.lbl_ContenidoPais.Name = "lbl_ContenidoPais";
            this.lbl_ContenidoPais.Size = new System.Drawing.Size(126, 45);
            this.lbl_ContenidoPais.TabIndex = 11;
            this.lbl_ContenidoPais.Text = "lbl_ContenidoPais";
            this.lbl_ContenidoPais.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_ContenidoTelefono
            // 
            this.lbl_ContenidoTelefono.AutoSize = true;
            this.lbl_ContenidoTelefono.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_ContenidoTelefono.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lbl_ContenidoTelefono.Location = new System.Drawing.Point(170, 324);
            this.lbl_ContenidoTelefono.Name = "lbl_ContenidoTelefono";
            this.lbl_ContenidoTelefono.Size = new System.Drawing.Size(159, 45);
            this.lbl_ContenidoTelefono.TabIndex = 10;
            this.lbl_ContenidoTelefono.Text = "lbl_ContenidoTelefono";
            this.lbl_ContenidoTelefono.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfoClienteUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.tlp_BaseInfoCliente);
            this.Name = "InfoClienteUC";
            this.Size = new System.Drawing.Size(687, 560);
            this.Load += new System.EventHandler(this.InfoClienteUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picB_Cliente)).EndInit();
            this.tlp_BaseInfoCliente.ResumeLayout(false);
            this.tlp_EncabezadoInfoCliente.ResumeLayout(false);
            this.tlp_EncabezadoInfoCliente.PerformLayout();
            this.tlp_ContenidoInfoCliente.ResumeLayout(false);
            this.tlp_ContenidoInfoCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox picB_Cliente;
        private Label lbl_NombreEmpresa;
        private TableLayoutPanel tlp_BaseInfoCliente;
        private TableLayoutPanel tlp_EncabezadoInfoCliente;
        private TableLayoutPanel tlp_ContenidoInfoCliente;
        private Label lbl_PersonaContacto;
        private Label lbl_ContenidoFax;
        private Label lbl_Telefono;
        private Label lbl_Pais;
        private Label lbl_Region;
        private Label lbl_CodigoPostal;
        private Label lbl_Poblacion;
        private Label lbl_Direccion;
        private Label lbl_Cargo;
        private Label lbl_Fax;
        private Label lbl_ContenidoPersonaContacto;
        private Label lbl_ContenidoCargo;
        private Label lbl_ContenidoDireccion;
        private Label lbl_ContenidoPoblacion;
        private Label lbl_ContenidoRegion;
        private Label lbl_ContenidoCodigoPostal;
        private Label lbl_ContenidoPais;
        private Label lbl_ContenidoTelefono;
        private ToolTip tt_MensajeInfo;
    }
}
