﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Reserva_Vehiculos
{
    public static class Informacion_Vehiculo
    {
        public static void MostrarInformacion(this Vehiculo vehiculo)
        {
            Console.WriteLine("*====*====* Información del vehículo *====*====*");
            Console.WriteLine($"*---> Modelo: {vehiculo.Modelo}\n*---> Precio: {vehiculo.Precio}");
        }
    }
}
