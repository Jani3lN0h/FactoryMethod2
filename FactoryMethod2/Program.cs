using FactoryMethod2.Services;
using System;

namespace FactoryMethod2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Elegir el tipo de Cuenta para retirar: ");
            Console.WriteLine("1 - Cuenta de Cheques");
            Console.WriteLine("2 - Cuenta de Ahorro");
            Console.WriteLine("3 - Cuenta de Nómina");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("********************************************");
            Console.ResetColor();
            int TipoCuenta = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingresa el número de cuenta:");
            Console.ResetColor();
            int NumeroCuenta = Convert.ToInt32(Console.ReadLine());
            var Cuenta = new Client(TipoCuenta, NumeroCuenta).CrearInstancia();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Ingresa el monto a retirar:");
            Console.ResetColor();
            int MontoRetirar = Convert.ToInt32(Console.ReadLine());
            var msg = Cuenta.RetirarFondos(MontoRetirar);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(msg);
            Console.ResetColor();
            Console.WriteLine("\r\nPresione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
