using Demo.Example_01;
using Demo.Example02;
using Demo.Interface;


namespace Demo

{
    internal class Program
    {

        public static void PrintTheNumberOfSeries(ISeriers? series) 
        {
            if (series is not null) 
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine($"Current  =  {series.Current}");
                    series.GetNext();


                }

                series.Reset();



            }
           
           else 
            {
                return;
            
            
            }




        }


        static void Main(string[] args)
        {


            #region interface

            // IType type1; //new IType(); invalid
            //  type1 = new Types(); // valid, as Types implements IType
            // type1.myProperty = 10;
            // type1.myMethod();
            // type1.myMethod2(); // Calls the default implementation from the interface   

            //// type1.Belonge();  invalid

            // Types t1 = new Types(); 
            // t1.myProperty = 20;
            // t1.myMethod();  
            // t1.Belonge(30); 



            #endregion

            #region Example 01 

            //Type_A typeA = new Type_A();
            //PrintTheNumberOfSeries(typeA);


            //Console.WriteLine("===================================");
            //TypeB typeB = new TypeB();
            //PrintTheNumberOfSeries(typeB);  







            #endregion


            #region Example 02

            //Car c1 = new Car();
            //c1.Backward();
             // implacit implemention
            //c1.Forward();   

            //c1.Left();  

            //c1.Right();
            //c1.speed = 500;
            //Console.WriteLine(c1.speed);  

           // Airplane A1 = new Airplane();
           // A1.speed = 1;
           // A1.Forward();
           //// A1.Backward(); // invalide 

           // IMoveOnAir A2 = new Airplane(); // using interface  by referenc of interface (explecit implemention)
           // A2.Backward();
           // A2.Forward();   
           //A2.Left();   
           //// A2.Right(); ; // invalid

           // IMoveOnGround A3 = new Airplane();  
           // A3.Backward();  
           // A3.Forward();   
           // A3.Left();  
           // A3.Right();









            #endregion







        }
    }
}
