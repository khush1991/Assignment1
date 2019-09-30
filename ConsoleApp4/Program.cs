using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {



            int sideaa;
            int sidebb;
            int sidecc;

            System.Console.Write("Enter 1 For triangle Dimension And Enter 2 for Exit :");
            int input = int.Parse(Console.ReadLine());
            while (input == 1)
            {
                System.Console.WriteLine("Enter Triangle Dimensions ");

                Console.Write("Enter side 1 of triangle: ");
                sideaa = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter side 2 of triangle: ");
                sidebb = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter side 3 of triangle: ");
                sidecc = Convert.ToInt32(Console.ReadLine());

                String output =TriangleSolver.Analyze(sideaa, sidebb, sidecc);
                Console.WriteLine(output);
            }

        }
    }
}
    
    

