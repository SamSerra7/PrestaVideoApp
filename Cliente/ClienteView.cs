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
    public partial class ClienteView : Form
    {
        private ClienteNegocios clienteNegocios = new ClienteNegocios();
        private List<Entidades.Cliente> clientes;

        public ClienteView()
        {
            InitializeComponent();
            clientes = clienteNegocios.ObtenerClientes();

            if (clientes.Count > 0)
            {
                dgv_clientes.DataSource = clientes;
                lbl_error.Text = "";
            }
            else
            {
                lbl_error.Text = "No hay clientes para mostrar";
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
                bool activo = cb_activo.Text == "Activar";
                SqlDateTime nacimiento = new SqlDateTime(dt_fecha_nacimiento.Value);
                clienteNegocios.RegistrarCliente(new Entidades.Cliente(txt_identificacion.Text, txt_nombre.Text, txt_apellido_1.Text, txt_apellido_2.Text, nacimiento, activo));
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
