using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centavos_a_pesos_consola
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalcentavos, tpesos, tcentavos;
            Console.WriteLine("Ingrese cantidad de centavos: ");
            totalcentavos = Convert.ToInt32(Console.ReadLine());
            Calcular(totalcentavos, out tpesos, out tcentavos);

            Console.WriteLine("El resultado es: " + tpesos +" " +" Pesos " +"\t"+tcentavos+" "+" centavos ");



             void Calcular(int tocentavos, out int pesos, out int centavos)
            {
                pesos = totalcentavos / 100;
                centavos = totalcentavos % 100;
            }

            Console.ReadKey();
        }
    }
}
