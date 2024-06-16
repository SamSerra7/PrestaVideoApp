namespace Cliente
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
    }
}