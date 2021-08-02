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
    class Ejercicio3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Favor de ingresar numeros enteros para realizar la siguiente división");
            Console.WriteLine("Rellene los siguientes campos para a y b");
            Console.WriteLine("Ingrese el dato para 'a'");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el dato para 'b'");
            var b = double.Parse(Console.ReadLine());



            if (b == 0)
            {

                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            else
            {

                var division = (a / b);
                Console.WriteLine("La división resultante entre a y b es: ");
                Console.WriteLine(division);
 

            }

            Console.ReadKey();



        }
    }
}



