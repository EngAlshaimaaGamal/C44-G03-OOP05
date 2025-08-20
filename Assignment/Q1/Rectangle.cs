using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Q1
{
   public class Rectangle : IRectangle
    {
        public double Area { get; set; }

        public void DisplayInfo()
        {
           Console.WriteLine("Shape is Rectangle");
        }
    }
}
