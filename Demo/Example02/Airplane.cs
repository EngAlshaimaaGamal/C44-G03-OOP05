using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Example02
{
    internal class Airplane : Vehical, IMoveOnGround, IMoveOnAir
    {
        void IMoveOnGround.Backward()
        {
            Console.WriteLine("move AirPlane Backword");
        }

        void IMoveOnAir.Backward()
        {
            Console.WriteLine("move AirPlane on Air Backward");
        }

      

        public void Forward()
        {
            Console.WriteLine("move AirPlane Forward");
        }

        void IMoveOnGround.Left()
        {
            Console.WriteLine("move AirPlane Left");
        }

        void IMoveOnAir.Left()
        {
            Console.WriteLine("move AirPlane on Air Left");
        }

        void IMoveOnGround.Right()
        {
            Console.WriteLine("move AirPlane Rigth");
        }

        void IMoveOnAir.Right()
        {
            Console.WriteLine("move AirPlane on Air Rigth");
        }
    }
}
