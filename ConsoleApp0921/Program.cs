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
            Console.WriteLine("Adja meg hány darab számot kíván megadni!");
            int  N = Convert.ToInt32(Console.ReadLine());
            string[] tomb = new string[N];

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine("Kérem adjon meg egy számot:");
                string s = Console.ReadLine();
                tomb[i] = s;
                s = "";
            }
            Console.WriteLine("A számaink: ");
            foreach (var i in tomb)
            {
                Console.Write(i+" ");
            }
            int max = Convert.ToInt32(tomb[0]);
            int min = Convert.ToInt32(tomb[0]);
            for (int i = 0; i < tomb.Length; i++)
            {
                if (max< Convert.ToInt32(tomb[i]))
                {
                    max = Convert.ToInt32(tomb[i]);
                }
                else if (min > Convert.ToInt32(tomb[i]))
                {
                    min = Convert.ToInt32(tomb[i]);
                }
            }
            Console.WriteLine("\nA minimum értékünk: " +min +", a maximum értékünk: " +max);
            Console.ReadKey();
            
        }
    }
}
