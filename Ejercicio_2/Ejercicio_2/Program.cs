

using Ejercicio_2;

Rectangulo rectangulo = new Rectangulo();

Console.WriteLine("Ingrese alto del rectangulo: ");
rectangulo.setAncho(double.Parse(Console.ReadLine()));

Console.WriteLine("Ingrese largo del Rectangilo: ");
rectangulo.setLargo(double.Parse(Console.ReadLine()));

Console.WriteLine("Area de rectangulo: " + rectangulo.calcularArea());

Console.WriteLine("Perimetro del rectangulo: " + rectangulo.calcularPerimetro());
