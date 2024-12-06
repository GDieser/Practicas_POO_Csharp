namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        private List<Disco> listaDiscos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscoNegocio discos = new DiscoNegocio();
            listaDiscos = discos.listar();
            dgvDiscos.DataSource = listaDiscos;
            
            dgvDiscos.Columns[3].Visible = false;
            dgvDiscos.Columns[4].Visible = false;
            dgvDiscos.Columns[5].Visible = false;

            pbDiscos.Load(listaDiscos[0].UrlImagen);

        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbDiscos.Load(imagen);
            }
            catch (Exception ex)
            {

                pbDiscos.Load("https://m.media-amazon.com/images/I/813kqvYoRfL.png");
            }
            
        }
    }
}
