using System;

namespace Sistema_Reserva_Vehiculos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool j = true;
            Console.WriteLine("*====*====*====* B I E N V E N I D O *====*====*====*");
            do
            {
                Console.WriteLine("\n*==> Seleccione una opción: ");
                Console.WriteLine("1. Hacer reserva de un vehiculo\n2. Salir");
                Console.Write("*--> ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.Write("*==> Ingrese el modelo del auto: ");
                        string modelo = Console.ReadLine();
                        double precio = 0;
                        int aux = 0;
                        do
                        {
                            Console.Write("*==> Ingrese el precio del auto por día: ");
                            precio = Convert.ToDouble(Console.ReadLine());
                            if (precio < 740) // precio no menor a 740 córdobas
                            {
                                Console.WriteLine("Precio demasiado bajo, intente de nuevo...");
                                continue;
                            }
                            aux++;
                        }
                        while (aux == 0);
                        Vehiculo vehiculo = new Vehiculo { Modelo = modelo, Precio = precio };
                        Console.WriteLine("\n*====*====> Descuentos disponibles: ");
                        Console.WriteLine("1. *--> Descuento de membresía: 10%\n2. *--> Descuento de Fin de año: 15%");
                        Console.WriteLine("3. *--> Descuento de nuevo modelo: 20%\n4. *--> Descuento de promoción: 5%");
                        Console.Write("* Opción *--> ");
                        int option = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Informacion_Vehiculo.MostrarInformacion(vehiculo, option);
                        break;
                    case 2:
                        j = false;
                        break;
                    default:
                        break;
                
                }
            }
            while (j);




        }
    }
}
