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
    class ejercicio6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A continuación se le pedira ingresar 3 notas para hacer el calculo de la nota final");
            Console.WriteLine("Por favor ingrese la primera nota equivalente al 35% de la calificación final");
            var a = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la segunda nota equivalente al 30% de la calificación final");
            var b = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la tercera nota equivalente al 25% de la calificación final");
            var c = double.Parse(Console.ReadLine());

            var nota1 = a * 0.35;
            var nota2 = b * 0.30;
            var nota3 = c * 0.25;
            Console.WriteLine("La calificación final es: ");

            var NotaFinal =  nota1 + nota2 + nota3;


            Console.WriteLine(NotaFinal);

            Console.WriteLine("el 10% restante de la nota final corresponde a la asistencia ");

            Console.ReadKey();

        }
    }
}
