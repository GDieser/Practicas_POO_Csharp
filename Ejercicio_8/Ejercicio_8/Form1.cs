using Dominio;
using Negocio;
using WinForm;
using WinFormDiscos;

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
            cargarGrilla();

        }

        private void cargarGrilla()
        {
            DiscoNegocio discos = new DiscoNegocio();
            listaDiscos = discos.listar();
            dgvDiscos.DataSource = listaDiscos;

            ocultatColumnas();
            //dgvDiscos.Columns[5].Visible = false;

            pbDiscos.Load(listaDiscos[0].UrlImagen);

        }

        private void ocultatColumnas()
        {
            dgvDiscos.Columns["IdTipoEdicion"].Visible = false;
            dgvDiscos.Columns["IdDisco"].Visible = false;
            dgvDiscos.Columns["UrlImagen"].Visible = false;
            dgvDiscos.Columns["IdEstilo"].Visible = false;
        }
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDiscos.CurrentRow != null)
            {
                Disco seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.UrlImagen);
            }
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
                int numeroAleatorio = random.Next(0, 2);

                switch (numeroAleatorio)
                {
                    case 0:
                        pbDiscos.Load("https://i.pinimg.com/236x/86/1c/a6/861ca60c3a2813c8e3250b9af138ada0.jpg");
                        break;
                    case 1:
                        pbDiscos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR_7r2O4Oq5u1_Vnmkw72EnrBTwnNk0LLy7oz_6wqmlYrL2QFmrtJowGbBV6qcem6lDQD0&usqp=CAU");
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

            cargarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Disco seleccionado;

            seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

            frmAgregarDisco modificar = new frmAgregarDisco(seleccionado);
            modificar.ShowDialog();

            cargarGrilla();
        }

        private void btnAgregarEstilo_Click(object sender, EventArgs e)
        {
            AgregarEstilo_Tipo agregar = new AgregarEstilo_Tipo();
            agregar.esEstilo = true;

            agregar.ShowDialog();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            AgregarEstilo_Tipo agregar = new AgregarEstilo_Tipo();
            agregar.esEstilo = false;

            agregar.ShowDialog(this);
        }

        private void btnEliminarFisico_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btnEliminarLogico_Click(object sender, EventArgs e)
        {
            eliminar(true);
        }

        private void eliminar(bool logico = false)
        {
            DiscoNegocio disco = new DiscoNegocio();
            Disco seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("¿Confirmar acción?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Disco)dgvDiscos.CurrentRow.DataBoundItem;

                    if (logico)
                    {
                        disco.eliminarLogico(seleccionado.IdDisco);
                    }
                    else
                    {
                        disco.eliminarFisico(seleccionado.IdDisco);
                    }

                    cargarGrilla();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            /* List<Disco> listaFiltrada;
             string filtro = tboxFiltro.Text;

             if (filtro != "")
             {
                 ///Agregar para artistas
                 listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToLower().Contains(filtro.ToLower()));
             }
             else
             {
                 listaFiltrada = listaDiscos;
             }



             dgvDiscos.DataSource = null;
             dgvDiscos.DataSource = listaFiltrada;
             ocultatColumnas();*/
        }

        private void tboxFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void tboxFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Disco> listaFiltrada;
            string filtro = tboxFiltro.Text;

            if (filtro != "")
            {
                ///Agregar para artistas
                listaFiltrada = listaDiscos.FindAll(x => x.Titulo.ToLower().Contains(filtro.ToLower()));
            }
            else
            {
                listaFiltrada = listaDiscos;
            }



            dgvDiscos.DataSource = null;
            dgvDiscos.DataSource = listaFiltrada;
            ocultatColumnas();
        }
    }
}
