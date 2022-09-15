using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport car = new Car("Машина",120);
            Transport ship = new Ship("Корабль",60);
            Transport aircraft=new Aircraft("Самолет",1000);
            car.Move();
            ship.Move();
            aircraft.Move();
            Console.ReadKey();  
        }
    }
}
