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
    public partial class EncargadoView : Form
    {
        private EncargadoNegocios encargadoNegocios = new EncargadoNegocios();
        private List<Encargado> encargados;

        public EncargadoView()
        {
            InitializeComponent();
            encargados = encargadoNegocios.ObtenerEncargados();

            if (encargados.Count > 0)
            {
                dgv_encargados.DataSource = encargados;
                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "No hay encargados para mostrar";
            }

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
                SqlDateTime nacimiento = new SqlDateTime(dt_fecha_nacimiento.Value);
                SqlDateTime ingreso = new SqlDateTime(dt_fecha_nacimiento.Value);
                encargadoNegocios.RegistrarEncargado(new Encargado(txt_identificacion.Text, txt_nombre.Text, txt_apellido_1.Text, txt_apellido_2.Text, nacimiento, ingreso));
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
