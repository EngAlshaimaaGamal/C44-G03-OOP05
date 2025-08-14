using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Interface
{
    internal class Types : IType
    {
        // Implementation of the property
        public int myProperty { get; set; }
        // Implementation of the method
        public void myMethod()
        {
            Console.WriteLine("This is a method in the Types class.");
        }
        // The default implementation from the interface can be used as is

        // No need to override myMethod2 unless specific behavior is needed


        public void Belonge(int myProperty)
        {

            Console.WriteLine(" method belonge to class ");
        
        
        }
    
    
    
    }
   
}
