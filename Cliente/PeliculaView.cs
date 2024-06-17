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

namespace ClienteViews
{
    public partial class PeliculaView : Form
    {

        private CategoriaPeliculaNegocios categoriaPelicula = new CategoriaPeliculaNegocios();
        private PeliculaNegocios peliculaNegocios = new PeliculaNegocios();
        private List<CategoriaPelicula> categorias;
        private List<string> nombreCategorias = new List<string>();
        private List<Pelicula> peliculas;

        public PeliculaView()
        {
            InitializeComponent();
            categorias = categoriaPelicula.ObtenerCategoriaPeliculas();
            peliculas = peliculaNegocios.ObtenerPeliculas();
            if (peliculas.Count > 0)
            {
                dgv_peliculas.DataSource = peliculas;
                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "No hay peliculas para mostrar";
            }
            
            if (categorias.Count > 0)
            {
                desbloquearCasillas();
                setNombreCategorias();
                cb_categoria.DataSource = nombreCategorias;
                lbl_error.Text = "";

            }
            else
            {
                lbl_error.Text = "No hay categorias, debe ir a crear una nueva ";
                bloquearCasillas();
            }
            


        }

        private void setNombreCategorias()
        {
            foreach (var cat in categorias)
            {
                if (cat != null) nombreCategorias.Add(cat.Nombre);
            }
        }

        private void bloquearCasillas()
        {
            txt_dioma.Enabled = false;
            txt_titulo.Enabled = false;
            cb_categoria.Enabled = false;
            txt_lanzamiento.Enabled = false;
        }

        private void desbloquearCasillas()
        {
            txt_dioma.Enabled = true;
            txt_titulo.Enabled = true;
            cb_categoria.Enabled = true;
            txt_lanzamiento.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var categoria = categorias.Find(c => c.Nombre == cb_categoria.Text);
                peliculaNegocios.RegistrarPelicula(new Pelicula(txt_titulo.Text, categoria, int.Parse(txt_lanzamiento.Text), txt_dioma.Text));
                this.Dispose();
                PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                pantallaPrincipal.Show();
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
            }
        }
    }
}
