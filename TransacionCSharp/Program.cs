using System;

namespace TransacionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cuenta = new CuentaBancaria("Nombre", 1000);
            Console.WriteLine($"Cuenta {cuenta.Numero} fue creada por {cuenta.Propietario} con {cuenta.Balance}");
        }
    }
}
