
using Ejercicio_3;

string cuenta;
double monto;
int opcion = 0;

Console.WriteLine("Ingrese numero de cuenta: ");
cuenta = Console.ReadLine();

Console.WriteLine("Ingrese monto inicial: ");
monto = double.Parse(Console.ReadLine());

CuentaBancaria nuevaCuenta = new CuentaBancaria(cuenta, monto);

do
{
    Console.Clear();

    Console.WriteLine("1 - Depositar");
    Console.WriteLine("2 - Retirar");
    Console.WriteLine("3 - Ver Saldo");
    Console.WriteLine("0 - Salir");
    opcion = int.Parse(Console.ReadLine());

    Console.Clear();
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Ingrese monto a depositar: ");
            monto = double.Parse(Console.ReadLine());
            nuevaCuenta.depositar(monto);
            break;
        case 2:

            Console.WriteLine("Ingrese monto a retirar: ");
            monto = double.Parse(Console.ReadLine());
            nuevaCuenta.retirar(monto);
            break;
        case 3:
            Console.WriteLine("Saldo: " + nuevaCuenta.mostrarSaldo());
            Console.ReadKey();
            break;
        case 0:
            Console.WriteLine("Adios!");
            break;
    }
    

} while (opcion != 0);

Console.ReadKey();
