using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReproductorMusicaComponentes;

namespace Musicas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void slider1_Load(object sender, EventArgs e)
        {

        }

        private void buttonPause1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPause1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonClose1_Click(object sender, EventArgs e)
        {

        }

        private void panelReproductor1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listaCanciones1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelReproductor1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void botonCerrar1_Load(object sender, EventArgs e)
        {

        }

        private void botonNavegacion2_Click(object sender, EventArgs e)
        {

        }

        private void botonNavegacion1_Click(object sender, EventArgs e)
        {

        }

        private void imagenAlbum_Click(object sender, EventArgs e)
        {
            ImagenAlbum imagen = new ImagenAlbum();
            imagen.Location = new Point(75, 50); // Ajustar la posición
            this.Controls.Add(imagen);
        }

        private void imagenAlbum1_Click(object sender, EventArgs e)
        {

        }

        private void imagenAlbum2_Click(object sender, EventArgs e)
        {

        }

        private void textoCanciones1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
