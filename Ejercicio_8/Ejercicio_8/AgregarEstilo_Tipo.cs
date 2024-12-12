using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDiscos
{
    public partial class AgregarEstilo_Tipo : Form
    {
        public bool esEstilo { get; set; }
        public AgregarEstilo_Tipo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = txbDescripcion.Text;
            AccesoDatos datos = new AccesoDatos();

            if(esEstilo)
            {
                datos.setConsulta("INSERT INTO ESTILOS VALUES ('" + nombre + "')");
            }
            else
            {
                datos.setConsulta("INSERT INTO TIPOSEDICION VALUES ('" + nombre + "')");
            }

            datos.ejecutarAccion();

            datos.cerrarConexion();

            MessageBox.Show("Agregado " + nombre, "Agregado" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Close();
        }
    }
}
