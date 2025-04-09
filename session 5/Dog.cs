using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    internal class Dog : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The Dog makes a sound");
        }
    }
}
