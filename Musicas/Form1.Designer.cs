namespace Musicas
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.controlProgreso1 = new Musicproyect.ControlProgreso();
            this.panelReproductor1 = new Musicproyect.PanelReproductor();
            this.botonNavegacion2 = new ReproductorMusicaComponentes.BotonNavegacion();
            this.botonNavegacion1 = new ReproductorMusicaComponentes.BotonNavegacion();
            this.botonCerrar1 = new ReproductorMusicaComponentes.BotonCerrar();
            this.botonReproducir1 = new ReproductorMusicaComponentes.BotonReproducir();
            this.imagenAlbum1 = new ReproductorMusicaComponentes.ImagenAlbum();
            ((System.ComponentModel.ISupportInitialize)(this.controlProgreso1)).BeginInit();
            this.panelReproductor1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAlbum1)).BeginInit();
            this.SuspendLayout();
            // 
            // controlProgreso1
            // 
            this.controlProgreso1.BackColor = System.Drawing.Color.Black;
            this.controlProgreso1.Location = new System.Drawing.Point(30, 313);
            this.controlProgreso1.Maximum = 100;
            this.controlProgreso1.Name = "controlProgreso1";
            this.controlProgreso1.Size = new System.Drawing.Size(200, 45);
            this.controlProgreso1.TabIndex = 4;
            this.controlProgreso1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // panelReproductor1
            // 
            this.panelReproductor1.BackColor = System.Drawing.Color.Black;
            this.panelReproductor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReproductor1.Controls.Add(this.imagenAlbum1);
            this.panelReproductor1.Controls.Add(this.botonNavegacion2);
            this.panelReproductor1.Controls.Add(this.botonNavegacion1);
            this.panelReproductor1.Controls.Add(this.botonCerrar1);
            this.panelReproductor1.Controls.Add(this.botonReproducir1);
            this.panelReproductor1.Controls.Add(this.controlProgreso1);
            this.panelReproductor1.Location = new System.Drawing.Point(207, 12);
            this.panelReproductor1.Name = "panelReproductor1";
            this.panelReproductor1.Size = new System.Drawing.Size(262, 435);
            this.panelReproductor1.TabIndex = 7;
            this.panelReproductor1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelReproductor1_Paint_1);
            // 
            // botonNavegacion2
            // 
            this.botonNavegacion2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonNavegacion2.BackColor = System.Drawing.Color.Maroon;
            this.botonNavegacion2.ButtonColor = System.Drawing.Color.Maroon;
            this.botonNavegacion2.Location = new System.Drawing.Point(30, 364);
            this.botonNavegacion2.Name = "botonNavegacion2";
            this.botonNavegacion2.RotateLeft = false;
            this.botonNavegacion2.Size = new System.Drawing.Size(50, 50);
            this.botonNavegacion2.TabIndex = 0;
            this.botonNavegacion2.Text = "botonNavegacion2";
            this.botonNavegacion2.UseVisualStyleBackColor = false;
            this.botonNavegacion2.Click += new System.EventHandler(this.botonNavegacion2_Click);
            // 
            // botonNavegacion1
            // 
            this.botonNavegacion1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonNavegacion1.BackColor = System.Drawing.Color.Maroon;
            this.botonNavegacion1.ButtonColor = System.Drawing.Color.Maroon;
            this.botonNavegacion1.Location = new System.Drawing.Point(166, 364);
            this.botonNavegacion1.Name = "botonNavegacion1";
            this.botonNavegacion1.RotateLeft = false;
            this.botonNavegacion1.Size = new System.Drawing.Size(50, 50);
            this.botonNavegacion1.TabIndex = 10;
            this.botonNavegacion1.Text = "botonNavegacion1";
            this.botonNavegacion1.UseVisualStyleBackColor = false;
            this.botonNavegacion1.Click += new System.EventHandler(this.botonNavegacion1_Click);
            // 
            // botonCerrar1
            // 
            this.botonCerrar1.BackColor = System.Drawing.Color.Maroon;
            this.botonCerrar1.ButtonColor = System.Drawing.Color.Maroon;
            this.botonCerrar1.Location = new System.Drawing.Point(196, 17);
            this.botonCerrar1.Name = "botonCerrar1";
            this.botonCerrar1.Size = new System.Drawing.Size(45, 45);
            this.botonCerrar1.TabIndex = 9;
            this.botonCerrar1.Load += new System.EventHandler(this.botonCerrar1_Load);
            // 
            // botonReproducir1
            // 
            this.botonReproducir1.BackColor = System.Drawing.Color.Maroon;
            this.botonReproducir1.ButtonColor = System.Drawing.Color.Maroon;
            this.botonReproducir1.Location = new System.Drawing.Point(96, 364);
            this.botonReproducir1.Name = "botonReproducir1";
            this.botonReproducir1.Size = new System.Drawing.Size(50, 50);
            this.botonReproducir1.TabIndex = 8;
            // 
            // imagenAlbum1
            // 
            this.imagenAlbum1.BackColor = System.Drawing.Color.Black;
            this.imagenAlbum1.Image = ((System.Drawing.Image)(resources.GetObject("imagenAlbum1.Image")));
            this.imagenAlbum1.Location = new System.Drawing.Point(80, 92);
            this.imagenAlbum1.Name = "imagenAlbum1";
            this.imagenAlbum1.Size = new System.Drawing.Size(100, 100);
            this.imagenAlbum1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenAlbum1.TabIndex = 11;
            this.imagenAlbum1.TabStop = false;
            this.imagenAlbum1.Click += new System.EventHandler(this.imagenAlbum1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelReproductor1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.controlProgreso1)).EndInit();
            this.panelReproductor1.ResumeLayout(false);
            this.panelReproductor1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAlbum1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Musicproyect.ControlProgreso controlProgreso1;
        private Musicproyect.PanelReproductor panelReproductor1;
        private ReproductorMusicaComponentes.BotonReproducir botonReproducir1;
        private ReproductorMusicaComponentes.BotonCerrar botonCerrar1;
        private ReproductorMusicaComponentes.BotonNavegacion botonNavegacion2;
        private ReproductorMusicaComponentes.ImagenAlbum imagenAlbum1;
        public ReproductorMusicaComponentes.BotonNavegacion botonNavegacion1;
    }
}

