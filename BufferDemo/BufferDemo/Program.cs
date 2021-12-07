using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BufferDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarr1 = new int[5] { 1, 2, 3, 4, 5 };
            int[] myarr2 = new int[10] { 0, 0, 0, 0, 0, 6, 7, 8, 9, 10 };

            Console.Write("Before Array copy operation\n");
            Console.Write("Myarr1 and Byte Length{0}\n", myarr1.Length);

            foreach (int i in myarr1)
                Console.Write("{0} \t", i);
            Console.WriteLine("\nMyarr2 and Byte Length:{0} \n", myarr2.Length);

            foreach (int i in myarr2)
                Console.Write("{0} \t", i);

          //  Array.Copy(myarr1, 0, myarr2, 0, 5);

            Buffer.BlockCopy(myarr1, 0, myarr2, 0, 20);
            foreach (int i in myarr1)
                Console.Write("{0} \t", i);

            Console.WriteLine("\nMyarr2: \n");

            foreach (int i in myarr2)
                Console.Write("{0} \t", i);

            Console.WriteLine("================== Array Byte Length====");
            Console.WriteLine(Buffer.ByteLength(myarr1));
            Console.ReadLine();
        }
    }
}
