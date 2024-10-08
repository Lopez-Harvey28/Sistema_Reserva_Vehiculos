using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Reserva_Vehiculos
{
    public static class Informacion_Vehiculo
    {
        public static void MostrarInformacion(this Vehiculo vehiculo,int option,int dias)
        {
            Console.WriteLine("*====*====* Información del vehículo *====*====*");
            Console.WriteLine($"*---> Modelo: {vehiculo.Modelo}\n*---> Precio: C${vehiculo.Precio}");
            Console.WriteLine($"*--> Precio con descuento aplicado: C${Vehiculo.Descuento.AplicarDescuento(vehiculo.Precio,option)}");
            Console.WriteLine($"*--> Precio de {dias} días con descuento aplicado por día: C${CalcularReserva.CalcReserva(Vehiculo.Descuento.AplicarDescuento(vehiculo.Precio,option),dias)}");
        }
    }
}
