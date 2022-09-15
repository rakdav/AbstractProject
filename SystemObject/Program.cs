using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 5;
            Console.WriteLine(i.ToString());
            Clock clock = new Clock { Houres=12,Minutes=34,Seconds=56};
            Console.WriteLine(clock.ToString());
            Clock clock1 = new Clock { Houres = 12, Minutes = 23, Seconds = 1 };
            Console.WriteLine(clock1.ToString());
            Console.WriteLine(clock.GetHashCode());
            if(clock.GetHashCode()==clock1.GetHashCode())
                Console.WriteLine("Было в районе часа");
            Console.WriteLine(clock.GetType());
            if(clock.GetType()==typeof(Clock))
                Console.WriteLine("Yes");
            if (clock.Equals(clock1)) Console.WriteLine("Y");
            else Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
