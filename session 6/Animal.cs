using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    internal class Animal
    {
        //virtual method 
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
        //To inherit from a class, use the : symbol.
    }
}
