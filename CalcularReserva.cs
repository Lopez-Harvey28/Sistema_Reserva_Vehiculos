using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Reserva_Vehiculos
{
    public static class CalcularReserva
    {
        public static double CalcReserva(double precio, int dias)
        {
            double valor = 0;
            valor = precio * dias; 
            return valor;
        }
    }
}
