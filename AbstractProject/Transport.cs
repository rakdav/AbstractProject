using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    abstract class Transport
    {
        public string Name { get; }
        public abstract int Speed { get; set; }
        protected Transport(string name,int speed)
        {
            Name = name;
            Speed = speed;
        }

        public abstract void Move();
        //{
        //    Console.WriteLine("{0} движется",Name);
        //}
    }
}
