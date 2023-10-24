using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_Miguel_Nuñez
{
    public class Multa
    {
        public string Placa { get; set; }
        public DateTime Fecha{get; set; }
        public TimeSpan Hora { get; set; }
        public int Velocidad { get; set; }

        public decimal MultaAsignada { get; set; }

        public Multa(string placa, DateTime fecha, TimeSpan hora, int velocidad) 
        {
            Placa = placa;
            Fecha= fecha;
            Hora = hora;
            Velocidad = velocidad;

            CalcularMulta();

        }

        private void CalcularMulta()
        {
            if (Velocidad < 70) 
            {
                MultaAsignada = 0;
            }
            if (Velocidad < 90)
            {
                MultaAsignada = 2000;
            }
            if (Velocidad < 100)
            {
                MultaAsignada = 3500;
            }
            if (Velocidad > 100)
            {
                MultaAsignada = 5000;
            }
        }
    }
}
