using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactPattern
{
    class Program
    {
        class car
        {
            public string company { get; set; }
            public string Model { get; set; }
            public int Speed { get; set; }
        }
        class Suzuki : car 
        {
            string company;
            string model;
            int speed;
        }
        class Toyota : car
        {
            string company;
            string model;
            int speed;
        }

        class CarFactory
        {

        }
        class SuzukiFactory
        {
            public SuzukiFactory()
            {
                this.company = "Suzuki";
                this.model = "idontknow";
                this.speed = 60;

            }
            public SuzukiFactory(String model, int speed)
            {
                this.company = "Suzuki";
                this.model = model;
                this.speed = speed;
            }
            string model;
            int speed;

        }
    }
        static void Main(string[] args)
        {
        }
    
}
