using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    internal class Ship : Transport
    {
        public Ship(string name,int speed) : base(name,speed)
        {
        }

        public override int Speed { get;set; }

        public override void Move()
        {
            Console.WriteLine("Корабль движется со скоростью "+Speed);
        }
    }
}
