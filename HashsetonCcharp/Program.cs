using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashsetonCcharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            while (true)
            {
                
                Console.WriteLine("1.add 2.output");
                int an = Int32.Parse(Console.ReadLine());
                if (an == 1)
                {
                    Console.WriteLine("add:");
                    set.Add(Console.ReadLine());
                }
                else if (an == 2)
                {
                    foreach(string i in set)
                    {
                        Console.WriteLine(i);
                    }
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Er");
                    Console.ReadLine();
                }
            }
        }
    }
}
