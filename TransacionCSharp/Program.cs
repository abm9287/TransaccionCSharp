using System;

namespace TransacionCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cuenta = new CuentaBancaria("Nombre", 1000);
            Console.WriteLine($"Cuenta {cuenta.Numero} fue creada por {cuenta.Propietario} con {cuenta.Balance}");

            cuenta.HacerDeposito(500, DateTime.Now, "PAGO DE ALQUILER");
            Console.WriteLine(cuenta.Balance);

            cuenta.HacerDeposito(100, DateTime.Now, "AMIGO ME DEVOLVIÓ");
            Console.WriteLine(cuenta.Balance);


            Console.WriteLine(cuenta.ObtenerHistorialDeCuenta());
            //Prueba
            try
            {
                var cuentaInvalida = new CuentaBancaria("invalido", -55);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Excepción detectada al crear una cuenta con saldo negativo ");
                Console.WriteLine(e.ToString());
            }
        }
    }
}
