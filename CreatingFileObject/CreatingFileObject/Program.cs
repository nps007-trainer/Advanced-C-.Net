using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CreatingFileObject
{
    class Person 
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }

        public Person(string fname, string lname, string e)
        {
            firstname = fname;
            lastname = lname;
            email = e;
        }
        public override string ToString()
        {
            return "firstname " + firstname + " lastname " + lastname + " email " + email;
        }
      
    }
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"E:\Nandini\Advanced .net with csharp\test.txt";
            List<string> lines=new List<string>();
            List<Person> people=new List<Person>();

            lines=File.ReadAllLines(filepath).ToList();

            foreach(string line in lines){
                string[] items=line.Split(',');
                Person p=new Person(items[0],items[1],items[2]);
                people.Add(p);

            }
            List<string> outcontents = new List<string>();
            foreach(Person p in people){
            Console.WriteLine(p);
            outcontents.Add(p.ToString());
            }


            string outfile=@"E:\Nandini\Advanced .net with csharp\outfile.txt";
         
            File.WriteAllLines(outfile, outcontents);
            Console.ReadLine();
        }
    }
}
