using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example02
{
    internal class Car : Vehical, IMoveOnGround
    {
        public void Backward()
        {
            Console.WriteLine("Move on ground BackWard");
        }

        public void Forward()
        {
            Console.WriteLine("Move on ground Forward");
        }

        public void Left()
        {
            Console.WriteLine("Move on ground Left");
        }

        public void Right()
        {

            Console.WriteLine("Move on ground Rigth");
        }
    }
}
