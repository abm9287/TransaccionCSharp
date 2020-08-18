using System;
using System.Collections.Generic;

namespace TransacionCSharp
{
    public class CuentaBancaria
    {
        
        public string Numero { get; set; }
        public string Propietario { get; set; }
        
       
       
        private List<Transaccion> Transacciones = new List<Transaccion>();
        //Balance de cálculo
        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach(var articulo in Transacciones)
                {
                    balance += articulo.Cantidad;
                }
                return balance;
            }
        }
        private static int semillaNumeroDECuenta = 1234567890;
        public CuentaBancaria(string nombre, decimal balanceInicial)
        {
            this.Numero = semillaNumeroDECuenta.ToString();
            semillaNumeroDECuenta++;

            this.Propietario = nombre;
            HacerDeposito(balanceInicial, DateTime.Now, "Balance inicial");
        }
        public void HacerDeposito(decimal cantidad, DateTime fecha, string nota)
        {
            if(cantidad<=0)
            {
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cuenta de depósito debe ser positivo");
            }
            var deposito = new Transaccion(cantidad, fecha, nota);
            Transacciones.Add(deposito);
        }

        public void HacerRetiro(decimal cantidad, DateTime fecha, string nota)
        {
            if (cantidad <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(cantidad), "La cantidad de retiro debe ser positiva ");
            }
            if(Balance - cantidad < 0)
            {
                throw new InvalidOperationException("No hay fondos suficientes para este retiro");
            }
            var retiro = new Transaccion(-cantidad, fecha, nota);
            Transacciones.Add(retiro);
        }
         
        public string ObtenerHistorialDeCuenta()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Fecha\t\tCantidad\tBalance\tNota");
            foreach (var articulo in Transacciones)
            {
                balance += articulo.Cantidad;
                report.AppendLine($"{articulo.Fecha.ToShortDateString()}\t{articulo.Cantidad}\t{balance}\t{articulo.Notas}");
            }
            return report.ToString();
        }
    }
}
