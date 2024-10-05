using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Reserva_Vehiculos
{
    public class Vehiculo
    {
        public string Modelo {  get; set; } //incluye la marca
        public double Precio {  get; set; }

        public class Descuento
        {
            public const double Descuento_Membresia = 0.1; //10% de descuento
            public const double Descuento_FinAño = 0.15; //15% de descuento
            public const double Descuento_NewModel = 0.2; //20% de descuento
            public const double Descuento_Promocion = 0.05; //5% de descuento

            public static double AplicarDescuento(double precio, int option)
            {
                switch (option)
                {
                    case 1:
                        precio -= precio * Descuento_Membresia;
                        break;
                    case 2:
                        precio -= precio * Descuento_FinAño;
                        break;
                    case 3:
                        precio -= precio * Descuento_NewModel;
                        break;
                    case 4:
                        precio -= Descuento_Promocion;
                        break;
                    default:
                        break;
                }
                return precio;
            }
        }
       
    }
}
