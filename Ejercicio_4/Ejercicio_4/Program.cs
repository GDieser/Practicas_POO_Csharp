
using Ejercicio_4;
using System.Threading.Tasks.Sources;

Vehiculo vehiculo = new Vehiculo();

vehiculo.Marca = "Honda";
vehiculo.Velocidad = 100;

int velociad;
int opcion = 0;

do
{
    Console.Clear();
    Console.WriteLine("1 - Acelerar");
    Console.WriteLine("2 - Frenar");
    Console.WriteLine("3 - Estado");
    Console.WriteLine("0 - Salir");
    opcion = int.Parse(Console.ReadLine());

    Console.Clear();
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese velcidad: ");
            velociad = int.Parse(Console.ReadLine());
            vehiculo.acelerar(velociad);
            break;
        case 2:
            Console.WriteLine("Ingrese velcidad: ");
            velociad = int.Parse(Console.ReadLine());
            vehiculo.frenar(velociad);
            break;
        case 3:
            vehiculo.mostrarEstado();
            Console.ReadKey();
            break;
        case 0:
            Console.WriteLine("Adios");
            break;
    }

} while (opcion != 0);

Console.ReadKey();
