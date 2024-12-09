using Dominio;
using Negocio;
using WinForm;

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
                Random random = new Random();
                int numeroAleatorio = random.Next(0, 3);

                switch (numeroAleatorio)
                {
                    case 0:
                        pbDiscos.Load("https://media.licdn.com/dms/image/v2/D4D35AQEuoIMseZ5ynA/profile-framedphoto-shrink_400_400/profile-framedphoto-shrink_400_400/0/1723436774597?e=1734141600&v=beta&t=99jFQK36rk02MQJQ9rav34y3QTT1DNluZ6DKwc7aH-A");
                        break;
                    case 1:
                        pbDiscos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_7r2O4Oq5u1_Vnmkw72EnrBTwnNk0LLy7oz_6wqmlYrL2QFmrtJowGbBV6qcem6lDQD0&usqp=CAU");
                        break;
                    case 2:
                        pbDiscos.Load("https://i.pinimg.com/236x/86/1c/a6/861ca60c3a2813c8e3250b9af138ada0.jpg");
                        break;

                    default:
                        break;
                }
            }

        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            frmAgregarDisco agregar = new frmAgregarDisco();
            agregar.ShowDialog();
        }
    }
}
