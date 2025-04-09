using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    internal class Country : ICountry
    {
        public void AddCountry()
        {
            Console.WriteLine("Bharat");
        }

        public void RemoveCountry()
        {
            Console.WriteLine("All Countries deleted");
        }
    }
}
