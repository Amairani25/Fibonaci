using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1, b = 1, c;
            Console.WriteLine("Calcula la serie fibonacci:");
			    int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Los numeros son: ");
			Console.Write(a + "," + b);
			while (i != 0)
			{
				c = b;
				Console.Write( "," + (a + b));
				b = c + a;
				a = c;
				i--;
			}
			Console.Write( ".");
			Console.ReadKey();
		}
	}
}
