using Entidades;
using Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteViews
{
    public partial class SucursalView : Form
    {
        private SucursalNegocios sucursalNegocios = new SucursalNegocios();
        private EncargadoNegocios encargadoNegocios = new EncargadoNegocios();
        private List<Sucursal> sucursales;
        private List<Encargado> encargados; 
        private List<string> nombresEncargados = new List<string>();

        public SucursalView()
        {
            InitializeComponent();
            sucursales = sucursalNegocios.ObtenerSucursales();
            encargados = encargadoNegocios.ObtenerEncargados();
            if (sucursales.Count > 0)
            {
                dgv_sucursales.DataSource = sucursales;
                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "No hay sucursales para mostrar";
            }
            
            if (encargados.Count > 0)
            {
                desbloquearCasillas();
                setNombreEncargados();
                cb_encargados.DataSource = nombresEncargados;
                lbl_error.Text = "";

            }
            else
            {
                lbl_error.Text = "No hay encargados, debe ir a crear uno nuevo";
                bloquearCasillas();
            }

            
        }

        private void setNombreEncargados()
        {
            foreach (var en in encargados)
            {
                if (en != null) nombresEncargados.Add(en.Nombre);
            }
        }

        private void bloquearCasillas()
        {
            txt_nombre.Enabled = false;
            txt_dir.Enabled = false;
            cb_encargados.Enabled = false;
            cb_activo.Enabled = false;
            txt_tel.Enabled = false;
        }

        private void desbloquearCasillas()
        {
            txt_nombre.Enabled = true;
            txt_dir.Enabled = true;
            cb_encargados.Enabled = true;
            cb_activo.Enabled = true;
            txt_tel.Enabled = true;
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
                bool activo = cb_activo.Text == "Si";
                var encargado = encargados.Find(c => c.Nombre == cb_encargados.Text);
                sucursalNegocios.RegistrarSucursal(new Sucursal(txt_nombre.Text,encargado,txt_dir.Text,txt_tel.Text,activo));
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
