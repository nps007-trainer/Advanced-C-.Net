using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace memorymanagment
{
    
    class Calculator
    {
        public int addition(int a, int b)
        {
            return a + b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
      Calculator calc=new Calculator();
            Console.WriteLine(calc.addition(2,3));

            Console.ReadLine();
        }
    }
}
