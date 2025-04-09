using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    abstract class Staff
    {
        public abstract void StaffJoining();

        public void LeaveApplication()
        {
            Console.WriteLine("Leave application submitted..!");
        }
        
    }
}
