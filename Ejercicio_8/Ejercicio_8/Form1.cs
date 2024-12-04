namespace Ejercicio_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscoNegocio discos = new DiscoNegocio();
            dgvDiscos.DataSource = discos.listar();
        }
    }
}
