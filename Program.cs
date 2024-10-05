using System;

namespace Sistema_Reserva_Vehiculos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*====*====*====* B I E N V E N I D O *====*====*====*");
            Vehiculo vehiculo = new Vehiculo { Modelo = "Mazda RX-7", Precio = 350.00 };
            Console.WriteLine("*====* Descuentos disponibles: ");
            Console.WriteLine("1. *--> Descuento de membresía: 10%\n2. *--> Descuento de Fin de año: 15%");
            Console.WriteLine("3. *--> Descuento de nuevo modelo: 20%\n4. *--> Descuento de promoción: 5%");
            Console.Write("* Opción *--> ");
            int option = Convert.ToInt32(Console.ReadLine());
            Informacion_Vehiculo.MostrarInformacion(vehiculo, option);
        }
    }
}
