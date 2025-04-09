using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    internal class Car
    {
        public string model;
        public string brand;
        public string year;


        public void StartCar()
        {
            Console.WriteLine($"{brand}, {model} is starting");
        }

        public void Brake()
        {
            Console.WriteLine($"{brand}, {model} applying breaks");
        }


    }
}
