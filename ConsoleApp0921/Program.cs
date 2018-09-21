using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp0921
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tomb = new string[10];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Kérem adjon meg egy számot:");
                string s = Console.ReadLine();
                tomb[i] = s;
                s = "";
            }
            Console.WriteLine("A 10 számunk: ");
            foreach (var i in tomb)
            {
                Console.Write(i+" ");
            }
            Console.ReadKey();
            
        }
    }
}
