namespace ClienteViews
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btn_categoria_pelicula_Click(object sender, EventArgs e)
        {
            CategoriaPeliculaView categoriaPeliculaView = new CategoriaPeliculaView();
            categoriaPeliculaView.Show();
            this.Hide();
        }

        private void btn_pelicula_Click(object sender, EventArgs e)
        {
            PeliculaView peliculaView = new PeliculaView();
            peliculaView.Show();
            this.Hide();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            ClienteView clienteView = new ClienteView();
            clienteView.Show();
            this.Hide();
        }

        private void btn_encargado_Click(object sender, EventArgs e)
        {
            EncargadoView encargadoView = new EncargadoView();
            encargadoView.Show();
            this.Hide();
        }

        private void btn_sucursal_Click(object sender, EventArgs e)
        {
            SucursalView sucursalView = new SucursalView();
            sucursalView.Show();
            this.Hide();
        }

        private void btn_pelicula_sucursal_Click(object sender, EventArgs e)
        {
            PeliculaSucursalView peliculaSucursalView = new PeliculaSucursalView();
            peliculaSucursalView.Show();
            this.Hide();
        }
    }
}