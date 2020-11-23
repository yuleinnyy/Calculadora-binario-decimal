using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_binario_decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("potaxio");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                String cadena = "";
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
                Console.WriteLine(cadena);
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("0");
                }
                else
                {
                    Console.WriteLine("Ingrese solo numeros positivos");
                }
            }
            Console.ReadLine();

            int n = 0;
            string bin = "";
            bool v = true;
            Console.WriteLine("Escribe un numero binario: ");
            bin = Console.ReadLine();
            for (int x = bin.Length - 1, y = 0; x >= 0; x--, y++)
            {
                if (bin[x] == '0' || bin[x] == '1')
                {
                    n += (int)(int.Parse(bin[x].ToString()) * Math.Pow(2, y));
                }
                else
                {
                    v = false;

                }
            }
            if (v == false)
            {
                Console.WriteLine("'" + bin + "' No es binario");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Decimal: {0}", n);
            }

            Console.ReadLine();
        }
    }
}
