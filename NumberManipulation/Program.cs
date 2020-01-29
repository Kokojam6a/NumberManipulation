using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Plus Plas = new Plus();
            Console.WriteLine(Plas.pluses(x, y));
            Division Div = new Division();
            Console.WriteLine(Div.pluses(x, y));
            Multiplication Mult = new Multiplication();
            Console.WriteLine(Mult.pluses(x, y));
            Console.ReadKey();
        }
    }
}
