using System;
using System.Collections.Generic;
using System.Text;

namespace TransacionCSharp
{
    class Transaccion
    {
        public decimal Cantidad { get; set; }
        public DateTime Fecha { get; set; }
        public string Notas { get; set; }
       

        public Transaccion(decimal cantidad, DateTime fecha, string notas)
        {
            this.Cantidad = cantidad;
            this.Fecha = fecha;
            this.Notas = notas;
        }
        
    }
}
