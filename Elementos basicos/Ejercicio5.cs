using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Integrantes: Daniel Enrique Zaldaña Castillo SMIS068421
 * Moises Antonio Martinez Matinez SMIS071221
 */
namespace Elementos_basicos
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            Double impuesto, precio, preconimpuesto;
            int producto;

            Console.Write("--Menu de opciones");
            Console.Write("\n1) CARNES");
            Console.Write("\n2) LACTEOS");
            Console.Write("\n3) MEDICINA");
            Console.Write("\nSelecciona una opcion: ");
            producto = Int32.Parse(Console.ReadLine());

            Console.Write("\nIngresa el impuesto (%): ");
            impuesto = double.Parse(Console.ReadLine());

            if (producto == 1 || producto == 2)
            {
                Console.Write("\nIngrese el precio del producto: ");
                precio = double.Parse(Console.ReadLine());
                preconimpuesto = ((impuesto / 100) * precio) + precio;
                Console.WriteLine("\nEl precio del producto es: " + preconimpuesto);
            }

            else if (producto == 3)
            {
                Console.Write("\nIngrese el precio del producto: ");
                precio = double.Parse(Console.ReadLine());
                Console.WriteLine("\nEl precio del producto es: " + precio);
            }
            else
            {
                Console.WriteLine("\nEl producto no esta disponible");
            }

            Console.ReadKey();
        }
    }
}
