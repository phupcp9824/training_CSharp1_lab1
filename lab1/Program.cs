using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Studen
    {
        public static void printName(string firstname, string lastname)
        {
            string name = string.Format("{0} {1}", firstname, lastname);
            Console.WriteLine("Studen name:"+name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Studen.printName("fpoly","cntt");
            Studen.printName("tkdh", "ptpt");
            Console.ReadKey();
        }

    }
}
