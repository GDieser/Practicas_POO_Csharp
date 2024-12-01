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
    public partial class frmBotella : Form
    {
        public frmBotella()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella botella = new Botella();
            int capacidad = 0;

            if(rb200cc.Checked)
            {
                capacidad = 200;
            }
            else if(rb400cc.Checked)
            {
                capacidad = 400;
            }
            else
            {
                capacidad = 600;
            }

            botella.Capacidad = capacidad;
            botella.Material = txbMaterial.Text;
            botella.Color = txbColor.Text;

            MessageBox.Show("Material  : " + botella.Material + Environment.NewLine + 
                            "Capacidad : " + botella.Capacidad + "cc" + Environment.NewLine +
                            "Color     : " + botella.Color);

        }
    }
}
