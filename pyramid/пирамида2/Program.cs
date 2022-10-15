using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пирамида2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                int x, y, z;
                Console.WriteLine("pick a number");
               
                z = Convert.ToInt32(Console.ReadLine());

                for (x = 0; x < z; x++)
                {

                    for (y = 1; y <= z - x; y++)
                        Console.Write(" ");
                    for (y = 1; y <= 2 * x - 1; y++)
                        Console.Write("*");
                    Console.Write("\n");
                }

                }
            }
    }  
}