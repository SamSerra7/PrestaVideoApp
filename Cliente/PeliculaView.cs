using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class PeliculaView : Form
    {

        private CategoriaPeliculaNegocios categoriaPelicula = new CategoriaPeliculaNegocios();
        private PeliculaNegocios peliculaNegocios = new PeliculaNegocios();
        private List<CategoriaPelicula> categorias;
        private List<Pelicula> peliculas;

        public PeliculaView()
        {
            InitializeComponent();
            categorias = categoriaPelicula.ObtenerCategoriaPeliculas();
            peliculas = peliculaNegocios.ObtenerPeliculas();
            if (categorias.Count > 0)
            {
                desbloquearCasillas();
                cb_categoria.DataSource = categorias;
                lbl_error.Text = "";
            }
            else if (peliculas.Count > 0)
            {
                dgv_peliculas.DataSource = peliculas;
                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "No hay categorias, debe ir a crear una nueva o no hay peliculas para mostrar";
                bloquearCasillas();
            }


        }

        private void bloquearCasillas()
        {
            txt_dioma.Enabled = false;
            txt_titulo.Enabled = false;
            cb_categoria.Enabled = false;
            num_lanzamiento.Enabled = false;
        }

        private void desbloquearCasillas()
        {
            txt_dioma.Enabled = true;
            txt_titulo.Enabled = true;
            cb_categoria.Enabled = true;
            num_lanzamiento.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //categoriaPelicula.RegistrarCategoriaPelicula(new CategoriaPelicula(txt_nombre.Text, txt_descripcion.Text));
            var categoria = categoriaPelicula.ObtenerCategoriaPeliculas().Find(c => c.Nombre == cb_categoria.Text);
            peliculaNegocios.RegistrarPelicula(new Pelicula(txt_titulo.Text, categoria, (int)num_lanzamiento.Value, txt_dioma.Text));
            this.Dispose();
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
        }
    }
}
