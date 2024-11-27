
using Ejemplo1;

Persona persona = new Persona("Pepe");
Persona persona1 = new Persona("Lola");
Persona p1;

p1  = new Persona("Popa");

p1.setNombre("German");

persona.setEdad(20);

Console.Write("Nombre: ");

persona.setNombre(Console.ReadLine());

Console.WriteLine("La edad es: " + persona.getEdad());

Botella botella = new Botella();

botella.Capacidad = 200;

Console.WriteLine(persona.GetHashCode());
Console.WriteLine(persona1.GetHashCode());

