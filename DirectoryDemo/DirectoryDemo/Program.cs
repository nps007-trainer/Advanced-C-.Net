using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryDemo
{

    class Program
    {
        static void SaveCurrentTime()
        {
            FileStream fs = new FileStream(@"E:\Nandini\Advanced .net with csharp\time.bin", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(DateTime.Now.Hour);
            bw.Write(DateTime.Now.Minute);
            bw.Close();
            fs.Close();
        }

        static void ShowTime()
        {
            FileStream fs = new FileStream(@"E:\Nandini\Advanced .net with csharp\time.bin", FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
          string tm=  br.ReadInt32() + ":" +br.ReadInt32();
          Console.WriteLine("The time captured was : {0}", tm);
        }
        static void Main(string[] args)
        {
            DirectoryInfo mydirinfo=new DirectoryInfo(@"E:\Nandini\Advanced .net with csharp");

            FileInfo[] myfileinfo = mydirinfo.GetFiles();
            foreach (FileInfo file in myfileinfo)
            {
                Console.WriteLine("File Name {0} - Size {1}  ", file.FullName, file.Length);
                
            }
            Console.WriteLine("==============Reading Test.Txt=====================");
            FileStream fs = new FileStream(@"E:\Nandini\Advanced .net with csharp\test.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            Console.WriteLine(str);
            while (str != null)
            {
                str = sr.ReadLine();
                Console.WriteLine(str);
            }

            FileStream fs2 = new FileStream(@"E:\Nandini\Advanced .net with csharp\test1.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs2);
            string str1;
            Console.WriteLine("Enter any string");
            str1 = Console.ReadLine();
            sw.Write(str1);
            sw.Flush();
            sw.Close();
            fs.Close();

            Console.WriteLine("============ Working with Binary file=======================");
            SaveCurrentTime();
            ShowTime();
            Console.ReadLine();
        }
    }
}
