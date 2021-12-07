using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gcdemo
{
   
    class Program
    {
        static void Main(string[] args)
        {
            List<string> obj = new List<string>() { "Nandini", "S" };
            Console.WriteLine(System.GC.GetGeneration(obj));
            System.GC.Collect();
            Console.WriteLine(System.GC.GetGeneration(obj));
            System.GC.Collect();
            Console.WriteLine(System.GC.GetGeneration(obj));

            Console.ReadLine();

        }
    }
}
