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
    public partial class PeliculaView : Form
    {

        private CategoriaPeliculaNegocios categoriaPelicula = new CategoriaPeliculaNegocios();
        private List<CategoriaPelicula> categorias;

        public PeliculaView()
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
            pantallaPrincipal.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
