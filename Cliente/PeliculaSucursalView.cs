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

namespace ClienteViews
{
    public partial class PeliculaSucursalView : Form
    {
        private PeliculaSucursalNegocios peliculaSucursalNegocios = new PeliculaSucursalNegocios();
        private SucursalNegocios sucursalNegocios = new SucursalNegocios();
        private PeliculaNegocios peliculaNegocios = new PeliculaNegocios();
        List<Sucursal> sucursales;
        List<Pelicula> peliculas;
        List<string> nombresSucursales = new List<string>();
        List<PeliculaSucursal> peliculasSucursales = new List<PeliculaSucursal>();

        public PeliculaSucursalView()
        {
            InitializeComponent();
            sucursales = sucursalNegocios.ObtenerSucursales();
            peliculas = peliculaNegocios.ObtenerPeliculas();
            peliculasSucursales = peliculaSucursalNegocios.ObtenerPeliculaSucursales();

            if (peliculasSucursales.Count > 0)
            {
                var objPel = new List<Object>();
                peliculasSucursales.ForEach(p => objPel.Add(new { titulo= p.Pelicula.Titulo, sucursal= p.Sucursal, cantidad= p.Cantidad }));

                dgv_pelicula_sucursal.DataSource = objPel;
                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "No hay peliculas por sucursales para mostrar";
            }

            if (sucursales.Count > 0)
            {
                setNombresSucursales();
                cb_sucursales.DataSource = nombresSucursales;
                lbl_error.Text = "";

            }
            else
            {
                lbl_error.Text = "No hay sucursales, debe ir a crear una nueva";
                bloquearCasillas();
            }
            
            if (peliculas.Count > 0)
            {
                
                dgv_peliculas.DataSource = peliculas;

                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "No hay peliculas, debe ir a crear una nueva";
                bloquearCasillas();
            }

            if (sucursales.Count > 0 && peliculas.Count > 0) desbloquearCasillas();

            
        }

        private void setNombresSucursales()
        {
            foreach (var s in sucursales)
            {
                if (s != null && s.Activo) nombresSucursales.Add(s.Nombre);
            }
        }

        private void bloquearCasillas()
        {
            txt_cant.Enabled = false;
            cb_sucursales.Enabled = false;
            dgv_peliculas.Enabled = false;
        }

        private void desbloquearCasillas()
        {
            txt_cant.Enabled = true;
            cb_sucursales.Enabled = true;
            dgv_peliculas.Enabled = true;
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
                var sucursal = sucursales.Find(c => c.Nombre == cb_sucursales.Text);
                var peliculasEscogidas = dgv_peliculas.SelectedRows.OfType<DataGridViewRow>().ToArray();
                foreach (var pe in peliculasEscogidas)
                {
                    var pelicula =(Pelicula) pe.DataBoundItem;
                    peliculaSucursalNegocios.RegistrarPeliculaSucursal(new PeliculaSucursal(sucursal, pelicula, int.Parse(txt_cant.Text)));
                }

                this.Dispose();
                PantallaPrincipal pantallaPrincipal = new PantallaPrincipal();
                pantallaPrincipal.Show();
            }
            catch (Exception ex)
            {
                lbl_error.Text = ex.Message;
                throw;
            }

        }
    }
}
