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
            string company()
            {

            }
            string Model()
            {

            }
            int Speed()
            {

            }
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

    }
        static void Main(string[] args)
        {
        }
    
}
