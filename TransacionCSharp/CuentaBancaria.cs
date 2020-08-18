using System;
using System.Collections.Generic;
using System.Text;

namespace TransacionCSharp
{
    public class CuentaBancaria
    {
        private static int semillaNumeroDECuenta = 1234567890;
        public string Numero { get; set; }
        public string Propietario { get; set; }
        public decimal Balance { get; set; }

        public void HacerDeposito(decimal cantidad, DateTime fecha, string nota)
        {

        }

        public void HacerRetiro(decimal cantidad, DateTime fecha, string nota)
        {

        }
         
        public CuentaBancaria(string nombre, decimal balanceInicial)
        {
            this.Propietario = nombre;
            this.Balance = balanceInicial;
            this.Numero = semillaNumeroDECuenta.ToString();
            semillaNumeroDECuenta++;
        }
    }
}
