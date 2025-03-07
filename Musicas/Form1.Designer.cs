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
            this.panelReproductor2 = new ReproductorMusicaComponentes.PanelReproductor();
            this.imagenAlbum2 = new ReproductorMusicaComponentes.ImagenAlbum();
            this.botonNavegacion4 = new ReproductorMusicaComponentes.BotonNavegacion();
            this.botonNavegacion3 = new ReproductorMusicaComponentes.BotonNavegacion();
            this.botonReproducir2 = new ReproductorMusicaComponentes.BotonReproducir();
            this.botonGuardar1 = new ReproductorMusicaComponentes.BotonGuardar();
            this.botonCerrar2 = new ReproductorMusicaComponentes.BotonCerrar();
            this.controlProgreso2 = new ReproductorMusicaComponentes.ControlProgreso();
            this.textoCancion1 = new ReproductorMusicaComponentes.TextoCancion();
            this.C = new ReproductorMusicaComponentes.TextoCancion();
            this.textoCancion2 = new ReproductorMusicaComponentes.TextoCancion();
            this.textoCancion3 = new ReproductorMusicaComponentes.TextoCancion();
            this.panelReproductor2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAlbum2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlProgreso2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReproductor2
            // 
            this.panelReproductor2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelReproductor2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReproductor2.Controls.Add(this.textoCancion3);
            this.panelReproductor2.Controls.Add(this.textoCancion2);
            this.panelReproductor2.Controls.Add(this.C);
            this.panelReproductor2.Controls.Add(this.textoCancion1);
            this.panelReproductor2.Controls.Add(this.controlProgreso2);
            this.panelReproductor2.Controls.Add(this.imagenAlbum2);
            this.panelReproductor2.Controls.Add(this.botonNavegacion4);
            this.panelReproductor2.Controls.Add(this.botonNavegacion3);
            this.panelReproductor2.Controls.Add(this.botonReproducir2);
            this.panelReproductor2.Controls.Add(this.botonGuardar1);
            this.panelReproductor2.Controls.Add(this.botonCerrar2);
            this.panelReproductor2.Location = new System.Drawing.Point(249, 12);
            this.panelReproductor2.Name = "panelReproductor2";
            this.panelReproductor2.Size = new System.Drawing.Size(302, 504);
            this.panelReproductor2.TabIndex = 1;
            // 
            // imagenAlbum2
            // 
            this.imagenAlbum2.BackColor = System.Drawing.Color.Black;
            this.imagenAlbum2.Image = ((System.Drawing.Image)(resources.GetObject("imagenAlbum2.Image")));
            this.imagenAlbum2.Location = new System.Drawing.Point(74, 91);
            this.imagenAlbum2.Name = "imagenAlbum2";
            this.imagenAlbum2.Size = new System.Drawing.Size(160, 153);
            this.imagenAlbum2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagenAlbum2.TabIndex = 6;
            this.imagenAlbum2.TabStop = false;
            this.imagenAlbum2.Click += new System.EventHandler(this.imagenAlbum2_Click);
            // 
            // botonNavegacion4
            // 
            this.botonNavegacion4.BackColor = System.Drawing.Color.Maroon;
            this.botonNavegacion4.ButtonColor = System.Drawing.Color.Maroon;
            this.botonNavegacion4.Location = new System.Drawing.Point(33, 429);
            this.botonNavegacion4.Name = "botonNavegacion4";
            this.botonNavegacion4.RotateLeft = false;
            this.botonNavegacion4.Size = new System.Drawing.Size(50, 50);
            this.botonNavegacion4.TabIndex = 5;
            this.botonNavegacion4.Text = "botonNavegacion4";
            this.botonNavegacion4.UseVisualStyleBackColor = false;
            // 
            // botonNavegacion3
            // 
            this.botonNavegacion3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botonNavegacion3.BackColor = System.Drawing.Color.Maroon;
            this.botonNavegacion3.ButtonColor = System.Drawing.Color.Maroon;
            this.botonNavegacion3.Location = new System.Drawing.Point(212, 429);
            this.botonNavegacion3.Name = "botonNavegacion3";
            this.botonNavegacion3.RotateLeft = false;
            this.botonNavegacion3.Size = new System.Drawing.Size(50, 50);
            this.botonNavegacion3.TabIndex = 4;
            this.botonNavegacion3.Text = "botonNavegacion3";
            this.botonNavegacion3.UseVisualStyleBackColor = false;
            // 
            // botonReproducir2
            // 
            this.botonReproducir2.BackColor = System.Drawing.Color.Maroon;
            this.botonReproducir2.ButtonColor = System.Drawing.Color.Maroon;
            this.botonReproducir2.Location = new System.Drawing.Point(123, 429);
            this.botonReproducir2.Name = "botonReproducir2";
            this.botonReproducir2.Size = new System.Drawing.Size(50, 50);
            this.botonReproducir2.TabIndex = 3;
            // 
            // botonGuardar1
            // 
            this.botonGuardar1.BackColor = System.Drawing.Color.Maroon;
            this.botonGuardar1.ButtonColor = System.Drawing.Color.Maroon;
            this.botonGuardar1.Location = new System.Drawing.Point(24, 18);
            this.botonGuardar1.Name = "botonGuardar1";
            this.botonGuardar1.Size = new System.Drawing.Size(50, 50);
            this.botonGuardar1.TabIndex = 2;
            // 
            // botonCerrar2
            // 
            this.botonCerrar2.BackColor = System.Drawing.Color.Maroon;
            this.botonCerrar2.ButtonColor = System.Drawing.Color.Maroon;
            this.botonCerrar2.Location = new System.Drawing.Point(240, 23);
            this.botonCerrar2.Name = "botonCerrar2";
            this.botonCerrar2.Size = new System.Drawing.Size(45, 45);
            this.botonCerrar2.TabIndex = 1;
            // 
            // controlProgreso2
            // 
            this.controlProgreso2.BackColor = System.Drawing.Color.Black;
            this.controlProgreso2.Location = new System.Drawing.Point(24, 367);
            this.controlProgreso2.Maximum = 100;
            this.controlProgreso2.Name = "controlProgreso2";
            this.controlProgreso2.Size = new System.Drawing.Size(249, 56);
            this.controlProgreso2.TabIndex = 8;
            this.controlProgreso2.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // textoCancion1
            // 
            this.textoCancion1.AutoSize = true;
            this.textoCancion1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.textoCancion1.ForeColor = System.Drawing.Color.White;
            this.textoCancion1.Location = new System.Drawing.Point(95, 265);
            this.textoCancion1.Name = "textoCancion1";
            this.textoCancion1.Size = new System.Drawing.Size(116, 24);
            this.textoCancion1.TabIndex = 9;
            this.textoCancion1.Text = "Song name";
            this.textoCancion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C.ForeColor = System.Drawing.Color.White;
            this.C.Location = new System.Drawing.Point(82, 300);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(143, 24);
            this.C.TabIndex = 10;
            this.C.Text = "C# F Mp3 Music Player";
            this.C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textoCancion2
            // 
            this.textoCancion2.AutoSize = true;
            this.textoCancion2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCancion2.ForeColor = System.Drawing.Color.White;
            this.textoCancion2.Location = new System.Drawing.Point(229, 346);
            this.textoCancion2.Name = "textoCancion2";
            this.textoCancion2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textoCancion2.Size = new System.Drawing.Size(36, 18);
            this.textoCancion2.TabIndex = 11;
            this.textoCancion2.Text = "0.00";
            this.textoCancion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textoCancion3
            // 
            this.textoCancion3.AutoSize = true;
            this.textoCancion3.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoCancion3.ForeColor = System.Drawing.Color.White;
            this.textoCancion3.Location = new System.Drawing.Point(42, 346);
            this.textoCancion3.Name = "textoCancion3";
            this.textoCancion3.Size = new System.Drawing.Size(32, 16);
            this.textoCancion3.TabIndex = 0;
            this.textoCancion3.Text = "0.00";
            this.textoCancion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(939, 512);
            this.Controls.Add(this.panelReproductor2);
            this.Name = "Form1";
            this.panelReproductor2.ResumeLayout(false);
            this.panelReproductor2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAlbum2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlProgreso2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReproductorMusicaComponentes.ControlProgreso controlProgreso1;
        private ReproductorMusicaComponentes.PanelReproductor panelReproductor1;
        private ReproductorMusicaComponentes.BotonReproducir botonReproducir1;
        private ReproductorMusicaComponentes.BotonCerrar botonCerrar1;
        private ReproductorMusicaComponentes.BotonNavegacion botonNavegacion2;
        private ReproductorMusicaComponentes.ImagenAlbum imagenAlbum1;
        public ReproductorMusicaComponentes.BotonNavegacion botonNavegacion1;
        private ReproductorMusicaComponentes.PanelReproductor panelReproductor2;
        private ReproductorMusicaComponentes.ImagenAlbum imagenAlbum2;
        private ReproductorMusicaComponentes.BotonNavegacion botonNavegacion4;
        private ReproductorMusicaComponentes.BotonNavegacion botonNavegacion3;
        private ReproductorMusicaComponentes.BotonReproducir botonReproducir2;
        private ReproductorMusicaComponentes.BotonGuardar botonGuardar1;
        private ReproductorMusicaComponentes.BotonCerrar botonCerrar2;
        private ReproductorMusicaComponentes.TextoCancion textoCancion1;
        private ReproductorMusicaComponentes.TextoCancion C;
        private ReproductorMusicaComponentes.TextoCancion textoCancion2;
        private ReproductorMusicaComponentes.ControlProgreso controlProgreso2;
        private ReproductorMusicaComponentes.TextoCancion textoCancion3;
    }
}

