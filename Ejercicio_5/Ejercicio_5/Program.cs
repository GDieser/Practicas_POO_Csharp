

using Ejercicio_5;

Curso curso = new Curso();

string nombre;
double nota;
int opcion;

do
{
    Console.Clear();
    Console.WriteLine("1 - Agregar Estudiante: ");
    Console.WriteLine("2 - Ver promedio de notas");
    Console.WriteLine("3 - Ver Todos los estudiantes");
    Console.WriteLine("0 - Salir");
    opcion = int.Parse(Console.ReadLine());

    Console.Clear();
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Nota: ");
            nota = double.Parse(Console.ReadLine());

            curso.agregarEstudiante(nombre, nota);

            break;
        case 2:
            curso.calcularPromedio(); 
            Console.ReadKey();
            break;
        case 3:
            curso.mostrarEstudiante();
            Console.ReadKey();
            break;
        case 0:
            Console.WriteLine("Adios");
            Console.ReadKey();
            break;
    }

} while (opcion != 0);

Console.ReadKey();

