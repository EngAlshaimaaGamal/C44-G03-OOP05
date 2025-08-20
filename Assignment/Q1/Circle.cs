using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q1
{
    public class Circle : ICircle
    {
        public double Area { get ; set ; }

        public void DisplayInfo()
        {
           Console.WriteLine("shape is circle");
        }
    }
}
