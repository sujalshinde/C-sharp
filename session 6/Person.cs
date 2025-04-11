using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    internal class Person
    {
        private string PersonName;
        public string Age;
        public string City;

        public string Name
        {
            get { return PersonName; }

            set { PersonName = value; }
        }
    }
}
