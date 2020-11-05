using Interfaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("car: c");
            Car c = new Car();
            Console.WriteLine(c.IsOn);
            c.Start();
            c.SteerLeft();
            c.SteerRight();
            c.Reverse();
            c.Break();
            c.Stop();
            Console.WriteLine(c.IsOn);

            Console.WriteLine("motorbike: m");
            MotorBike m = new MotorBike();
            Console.WriteLine(m.IsOn);
            m.Start();
            m.SteerLeft();
            m.SteerRight();
            m.Break();
            m.Stop();
            Console.WriteLine(m.IsOn);

            Console.WriteLine("boat: b");
            Boat b = new Boat();
            Console.WriteLine(b.IsOn);
            b.Start();
            b.SteerLeft();
            b.SteerRight();
            b.Reverse();
            b.Stop();
            Console.WriteLine(b.IsOn);




        }
    }
}
