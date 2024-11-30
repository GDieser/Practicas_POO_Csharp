using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = txbNombre.Text;

            int numero1 = 0;
            int numero2 = 0;
            if(!string.IsNullOrWhiteSpace(txbNombre.Text))
            {
                numero1 = int.Parse(txbNombre.Text);
            }

            if (!string.IsNullOrWhiteSpace(txbNumero.Text))
            {
                numero2 = int.Parse(txbNumero.Text);
            }

            label1.Text = "Resultado: " + (numero1 + numero2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido");
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            int numero2 = 0;

            if (!string.IsNullOrWhiteSpace(txbNombre.Text))
            {
                numero1 = int.Parse(txbNombre.Text);
            }

            if (!string.IsNullOrWhiteSpace(txbNumero.Text))
            {
                numero2 = int.Parse(txbNumero.Text);
            }

            label1.Text = "Resultado: " + (numero1 - numero2);
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int numero1 = 0;
            int numero2 = 0;

            if (!string.IsNullOrWhiteSpace(txbNombre.Text))
            {
                numero1 = int.Parse(txbNombre.Text);
            }

            if (!string.IsNullOrWhiteSpace(txbNumero.Text))
            {
                numero2 = int.Parse(txbNumero.Text);
            }

            label1.Text = "Resultado: " + (numero1 * numero2);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            float numero1 = 0;
            float numero2 = 0;

            if (!string.IsNullOrWhiteSpace(txbNombre.Text))
            {
                numero1 = float.Parse(txbNombre.Text);
            }

            if (!string.IsNullOrWhiteSpace(txbNumero.Text))
            {
                numero2 = float.Parse(txbNumero.Text);
            }

            label1.Text = "Resultado: " + (numero1 / numero2);
        }
    }
}
