namespace DashboardUI
{
    partial class AcercaDe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcercaDe));
            this.tlp_BaseAcercaDe = new System.Windows.Forms.TableLayoutPanel();
            this.picB_Logo = new System.Windows.Forms.PictureBox();
            this.lbl_AcercaDe = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tlp_BaseAcercaDe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_BaseAcercaDe
            // 
            this.tlp_BaseAcercaDe.ColumnCount = 1;
            this.tlp_BaseAcercaDe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_BaseAcercaDe.Controls.Add(this.picB_Logo, 0, 0);
            this.tlp_BaseAcercaDe.Controls.Add(this.lbl_AcercaDe, 0, 1);
            this.tlp_BaseAcercaDe.Controls.Add(this.button1, 0, 2);
            this.tlp_BaseAcercaDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_BaseAcercaDe.Location = new System.Drawing.Point(0, 0);
            this.tlp_BaseAcercaDe.Name = "tlp_BaseAcercaDe";
            this.tlp_BaseAcercaDe.RowCount = 3;
            this.tlp_BaseAcercaDe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tlp_BaseAcercaDe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_BaseAcercaDe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tlp_BaseAcercaDe.Size = new System.Drawing.Size(293, 202);
            this.tlp_BaseAcercaDe.TabIndex = 0;
            // 
            // picB_Logo
            // 
            this.picB_Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picB_Logo.BackgroundImage")));
            this.picB_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picB_Logo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picB_Logo.Location = new System.Drawing.Point(10, 10);
            this.picB_Logo.Margin = new System.Windows.Forms.Padding(10);
            this.picB_Logo.Name = "picB_Logo";
            this.picB_Logo.Size = new System.Drawing.Size(273, 48);
            this.picB_Logo.TabIndex = 0;
            this.picB_Logo.TabStop = false;
            // 
            // lbl_AcercaDe
            // 
            this.lbl_AcercaDe.AutoSize = true;
            this.lbl_AcercaDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_AcercaDe.Location = new System.Drawing.Point(3, 68);
            this.lbl_AcercaDe.Name = "lbl_AcercaDe";
            this.lbl_AcercaDe.Size = new System.Drawing.Size(287, 66);
            this.lbl_AcercaDe.TabIndex = 1;
            this.lbl_AcercaDe.Text = "label1";
            this.lbl_AcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(85, 154);
            this.button1.Margin = new System.Windows.Forms.Padding(85, 20, 85, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AcercaDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(293, 202);
            this.Controls.Add(this.tlp_BaseAcercaDe);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AcercaDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AcercaDe";
            this.Load += new System.EventHandler(this.AcercaDe_Load);
            this.tlp_BaseAcercaDe.ResumeLayout(false);
            this.tlp_BaseAcercaDe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picB_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_BaseAcercaDe;
        private System.Windows.Forms.PictureBox picB_Logo;
        private System.Windows.Forms.Label lbl_AcercaDe;
        private System.Windows.Forms.Button button1;
    }
}