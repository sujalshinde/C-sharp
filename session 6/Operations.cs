using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingApp
{
    internal class Operations
    {
        public delegate void HelloFunctionDelegate(string Message);

        public int Addition(int x, int y)
        {
            return x + y;
        }

        public double Addition(double x, double y) 
        { 
            return x + y; 
        }

        //generic method
        public static bool AreEqual<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }

        public static void Hello(string strMessge)
        {
            Console.WriteLine(strMessge);
        }
    }
}
