using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            //person.Move();
            Car car = new Car();
            //car.Move();
            DoAction(person);
            DoAction(car);
            Message message = new Message("Сообщение");
            message.Print();
            Console.ReadKey();
        }
        private static void DoAction(IMoveble moveble)
        {
            moveble.Move();
        }
    }
}
