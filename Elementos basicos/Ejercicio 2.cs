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
    class Ejercicio2

    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("a continuación se hara un calculo matetematico por favor llenar los campos requeridos de a y b  ");
            Console.WriteLine("Por favor ingrese el valor de 'a'");
            var a = double.Parse(Console.ReadLine());

            Console.WriteLine("Por favor ingrese el valor de 'b'");
            var b = double.Parse(Console.ReadLine());

            Console.WriteLine("el valor de (a+b)*(a-b) es igual:");
            Console.WriteLine((a + b) * (a - b));
            Console.ReadKey();
            

        }
    }
}
