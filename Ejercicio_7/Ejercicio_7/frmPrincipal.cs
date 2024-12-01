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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            Persona ventana = new Persona();
            ventana.ShowDialog();
        }

        private void agregarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.ShowDialog();
        }

        private void btnBotella_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmBotella))
                {
                    return;
                }
            }

            frmBotella botella = new frmBotella();

            botella.Show();
        }

        private void agregarBotellaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construcción...");
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(frmAnimal))
                { return; }

            }
            frmAnimal frmAnimal = new frmAnimal();
            frmAnimal.ShowDialog();
        }

        private void agregarAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En construcción...");
        }
    }
}
