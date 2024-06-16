using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    public partial class CategoriaPeliculaView : Form
    {
        private CategoriaPeliculaNegocios categoriaPelicula = new CategoriaPeliculaNegocios();
        private List<CategoriaPelicula> categorias;
        public CategoriaPeliculaView()
        {

            InitializeComponent();
            categorias = categoriaPelicula.ObtenerCategoriaPeliculas();
            if (categorias.Count > 0)
            {
                dataGridView1.DataSource = categorias;
                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "No hay datos que mostrar";
            }
        }

        private void button_agregar_categoria_Click(object sender, EventArgs e)
        {
            categoriaPelicula.RegistrarCategoriaPelicula(new CategoriaPelicula(txt_nombre.Text, txt_descripcion.Text));
            this.Dispose();
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
        }
    }
}
