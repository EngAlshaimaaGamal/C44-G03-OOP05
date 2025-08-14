using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal interface IType
    {
        // signature of a property    
        public int myProperty { get; set; }
        //signature of a method
        public void myMethod();

        // signature of a method with a default implementation
        public void myMethod2()
        {
            Console.WriteLine("This is a default method in an interface.");
        }   


    }
}
