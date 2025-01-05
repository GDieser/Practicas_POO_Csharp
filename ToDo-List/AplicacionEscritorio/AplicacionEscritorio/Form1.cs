using System;

namespace AplicacionEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string nuevoItem = tboxItem.Text;

            try
            {
                clLista.Items.Add(nuevoItem);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Debe ingresar un item");
            }
        }

    }
}
