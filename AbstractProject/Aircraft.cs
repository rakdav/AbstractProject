using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    internal class Aircraft : Transport
    {
        private int speed;
        public Aircraft(string name,int speed) : base(name,speed)
        {
        }

        public override int Speed 
        {
            get => speed;
            set => speed=value;
        }

        public override void Move()
        {
            Console.WriteLine("Самолет движется со скоростью "+Speed);
        }
    }
}
