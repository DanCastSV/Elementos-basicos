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
    class Ejercicio1
    {
        static void Main(string[] args)

        //Crear un programa que escriba un saludo y muestre su nombre 
        {
            string nombre = " "; // Declaramos la cadena que almacena el nombre.
            string cadena = " "; // Declaramos una cadena..
            Console.WriteLine("Hola. ¿Como te llamas?"); // Muestra mensa en pantalla.
            Console.WriteLine("*************************************************************\n");
            nombre = Console.ReadLine();
            Console.WriteLine("\n**************************************************************");
            Console.WriteLine("Hola {0}", nombre);
            Console.WriteLine("¿Qué me cuentas de interesante?"); // Muestra mensa en pantalla.
            Console.WriteLine("**************************************************************\n");
            cadena = Console.ReadLine();
            Console.WriteLine("\n***************************************************************");
            Console.WriteLine("Que bueno me parece muy interesante. ");
            Console.WriteLine("Mucho gusto " + nombre + ", Es todo un placer haberte conocido."); // Muestra mensaje.
            Console.WriteLine("*************************************************************");
            Console.ReadKey();
        }


    }
}
