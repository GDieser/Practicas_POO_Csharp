using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
    public partial class frmAnimal : Form
    {
        public frmAnimal()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string raza = txbRaza.Text;
            float peso = float.Parse(txbPeso.Text);
            float altura = float.Parse(txbAltura.Text);

            Animal animal = new Animal(nombre, raza, peso, altura);

            MessageBox.Show("Nombre : " + animal.getNombre() + Environment.NewLine +
                            "Raza   : " + animal.getRaza() + Environment.NewLine + 
                            "Peso   : " + animal.getPeso() + Environment.NewLine +
                            "Altura : " + animal.getAltura());

        }
    }
}
