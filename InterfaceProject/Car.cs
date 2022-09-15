using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class Car : IMoveble
    {
        public string Name { get; set; }

        public void Move()
        {
            Console.WriteLine("Машина едет"); ;
        }
    }
}
