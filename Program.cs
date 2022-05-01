using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicación_rusa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;

            Console.WriteLine("Ingrese el multiplicador");
            int multiplicando=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el multiplicando");
            int multiplicador=Convert.ToInt32(Console.ReadLine());

            int m1 = multiplicando;
            int m2 = multiplicador;
            

            //El bucle terminara hasta que el Multiplicando sea 1
            while (multiplicando > 1)
            {

                //Si el multiplicando es impar quedara un residuo, por lo que
                //si es impar, se guardara el valor actual del multiplicador en 
                //el resultado
                if (multiplicando % 2 != 0)
                {
                    resultado += multiplicador;  
                }


                multiplicando = multiplicando / 2;
                multiplicador = multiplicador * 2;

            }

           
            resultado += multiplicador;

            Console.WriteLine($"Multiplicando = {m1}");
            Console.WriteLine($"Multiplicador = {m2}");
            Console.WriteLine($"Resultado = {resultado}");
            Console.ReadLine();
        }
    }
}
