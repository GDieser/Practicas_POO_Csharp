using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    internal class Rectangulo
    {
        private double Largo;
        private double Ancho;

        public void setLargo(double Largo)
        {
            this.Largo = Largo;
        }

        public void setAncho(double Ancho)
        {
            this.Ancho = Ancho;
        }

        public double calcularArea()
        {
            double area;

            area = Largo * Ancho;

            return area;
        }

        public double calcularPerimetro()
        {
            double perimetro;

            perimetro = Ancho * 2 + Largo * 2;

            return perimetro;
        }
    }
}
