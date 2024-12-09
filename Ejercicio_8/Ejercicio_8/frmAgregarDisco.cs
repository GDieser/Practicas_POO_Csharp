using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace WinForm
{

    public partial class frmAgregarDisco : Form
    {
        private List<Estilo> listaEstilos;
        private List<TipoEdicion> listaTipos;

        public frmAgregarDisco()
        {
            InitializeComponent();

            EstiloNegocio estiloNegocio = new EstiloNegocio();
            listaEstilos = estiloNegocio.listar();

            cboxEstilo.DataSource = listaEstilos;

            TipoEdicionNegocio tipo = new TipoEdicionNegocio();
            listaTipos = tipo.listar();

            cBoxTipoEdicion.DataSource = listaTipos;

        }

        private void btnAgregarDisco_Click(object sender, EventArgs e)
        {
            
            Disco disco = new Disco();
            DiscoNegocio nuevo = new DiscoNegocio();

            if (!validarIngresos())
                return;

            disco.Titulo = txbTitulo.Text;
            disco.CantidadCanciones = (int)nudCantidad.Value;

            string fecha = dtpFechaLanzamiento.Value.ToString("yyyy-MM-dd");
            disco.FechaLanzamiento = fecha;
            disco.UrlImagen = txbUrlImagen.Text;

            Estilo estilo = (Estilo)cboxEstilo.SelectedItem;
            TipoEdicion tipo = (TipoEdicion)cBoxTipoEdicion.SelectedItem;

            disco.IdEstilo = estilo.IdEstilo;
            disco.IdTipoEdicion = tipo.IdTipo;

            MessageBox.Show("Agregado Exitosamente", "Agregado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nuevo.agregar(disco);
            Close();

        }

        private bool validarIngresos()
        {
            // Validar que el título no esté vacío
            if (string.IsNullOrWhiteSpace(txbTitulo.Text))
            {
                MessageBox.Show("El título no puede estar vacío.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que la cantidad de canciones sea mayor a 0
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad de canciones debe ser mayor a 0.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya seleccionado una fecha válida
            if (dtpFechaLanzamiento.Value > DateTime.Now)
            {
                MessageBox.Show("Debe seleccionar una fecha válida.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que la URL de la imagen no esté vacía
            if (string.IsNullOrWhiteSpace(txbUrlImagen.Text))
            {
                MessageBox.Show("Debe ingresar la URL de la imagen.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya seleccionado un estilo
            if (cboxEstilo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un estilo.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validar que se haya seleccionado un tipo de edición
            if (cBoxTipoEdicion.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de edición.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Si todas las validaciones pasan, retornar true
            return true;
        }

        private void cboxEstilo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
