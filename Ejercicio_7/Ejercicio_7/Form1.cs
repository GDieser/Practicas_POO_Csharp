namespace Ejercicio_7
{
    public partial class Persona : Form
    {
        public Persona()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string apellido = txbApellido.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string nacionalidad;
            if (rbArgentina.Checked)
                nacionalidad = "Argentina";
            else if (rbParaguay.Checked)
                nacionalidad = "Paraguay";
            else
                nacionalidad = "Uruguay";

            Persona persona = new Persona();
            persona.Nombre = nombre;
            persona.Apellido = apellido;
            persona.Nacionalidad= nacionalidad;
            persona.FechaNacimiento = fecha;

            MessageBox.Show("Nombre: " + persona.Nombre + ", Apellido: " + persona.Apellido+
                            ", Nacionalidad: " + persona.Nacionalidad + ", Fecha Nacimiento: " + persona.FechaNacimiento.ToString());

        }
    }
}
