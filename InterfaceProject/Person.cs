using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class Person : IMoveble
    {
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("Человек идет"); ;
        }
    }
}
