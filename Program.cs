using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskInterface1

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("....Calculator....");
            Console.WriteLine();
            Console.WriteLine("Basic Calculator Interface");
            Console.WriteLine();
            BasicCalc b = new BasicCalc();
            Console.WriteLine("Summation Function Result");

            b.sum(23,7);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("Subtraction Function Result");
            // Console.WriteLine();
            b.sub(25, 5);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("Multiplication Function Result");
            //Console.WriteLine();
            b.multiplication(16, 9);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine("Division Function Result");
            // Console.WriteLine();
            b.division(25, 5);
            b.printStates();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Scientific Calculator Interface ");
            Console.WriteLine();
            SciCal s = new SciCal();
            Console.WriteLine();
            Console.WriteLine("Division Function Result");
            Console.WriteLine();
            s.division(22, 6);
            //b.printStates();
            Console.WriteLine("Factorial Function Result");
            Console.WriteLine();
            s.factorial(7);
            Console.WriteLine();
            Console.WriteLine("X to Y Function Result");
            Console.WriteLine();
            s.XtoY(200, 1000);

        }
    }
}