using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo_de_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Escribe un numero para elevarlo al cuadrado ");
            try
            {
                numero = Int32.Parse(Console.ReadLine());
                Console.WriteLine(numero * numero);
            }
            catch (FormatException )
            {

                Console.WriteLine("El tipo de dato no es entero pruebe con un que no tenga punto decimal");
                Console.WriteLine("Presione enter para salir");
                Console.ReadKey();
            }
            catch(OverflowException )
            {
                Console.WriteLine("El numero es demasiado grande ");
                Console.WriteLine("Presione enter para salir");
                Console.ReadKey();
            }


            
        }
    }
}
