using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example_01
{
    internal class TypeB : ISeriers
    {
        public int Current { get; set; }

        public void GetNext()
        {
            Current += 3;

        }

       
    }
}
 