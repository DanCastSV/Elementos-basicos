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
    class ejercicio_4
    {
        static void Main(string[] args)
        {
            //Convertir temperatura de grados Centigrados a Fahrenheit
            //Sabiendo que F = (9/5)*c+32

            //declaración de variables
            double c, f;

            //Ingreso de los datos
            Console.WriteLine("Ingresar Cantidad de Grados Centigrados: ");
            c = Convert.ToDouble(Console.ReadLine());

            //Conversión de grados centigrados a fahrenheit
            f = (9 / 5) * c + 32;

            //Salida de datos
            Console.WriteLine("Resultados en Grados Fahrenheit: " + f);
            Console.ReadKey();
        }
    }
}
