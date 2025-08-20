//using Demo.Example_01;
//using Demo.Example02;
using Demo.Builtin_interface;
using Demo.Interface;
using System.Text;


namespace Demo

{
    internal class Program
    {

        /*public static void PrintTheNumberOfSeries(ISeriers? series) 
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
        */

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


            #region Shallow copy and Deep copy 

            #region value type 


            //int[] arr1 = [1, 2, 3, 5];
            //int[] arr2 =new int[5];

            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]); 
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());  


            //#region Shallow copy

            //arr2 = arr1; // copy of identity (address)

            //Console.WriteLine("After shallow copy");
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());




            //#endregion
            //#region Deep Copy
            //arr2 = (int[])arr1.Clone(); // deep copy  in heap
            //                                // create new object and get  copy od states instance
            //                                // inside shallow copy with same  value / caller
            //Console.WriteLine("After shallow Deep");
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]);
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());

            //arr1[0] = 100;
            //Console.WriteLine(arr1[0]);
            //Console.WriteLine(arr2[0]); 


            #endregion

            #region Reference type array

            #region Array of Immutable type [string]
            //string[] names01 = ["Amer", "Omer"];
            //string[] names02 = new string[2];

            //Console.WriteLine(names01[0]); // Amer
            //Console.WriteLine(names02[0]); // null
            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());

            #region Shallow copy

            //names01 = names02;

            //Console.WriteLine("After Shallow copy");
            //Console.WriteLine(names01[0]); //amer
            //Console.WriteLine(names02[0]);//amer
            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());



            #endregion

            #region DeepCopy

            //names02 = (string[])names01.Clone();
            //Console.WriteLine("After deep copy");
            //Console.WriteLine(names01[0]); 
            //Console.WriteLine(names02[0]);
            //Console.WriteLine(names01[1]);
            //Console.WriteLine(names02[1]);
            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());

            //names01[0] = "shaimaa";

            //Console.WriteLine(names01[0]);
            //Console.WriteLine(names02[0]);
            //Console.WriteLine(names01.GetHashCode());
            //Console.WriteLine(names02.GetHashCode());

            #endregion


            #endregion

            #region Array of mutable type[stringBuilder]

            //StringBuilder[] name1 = [new StringBuilder("Amer")];

            //StringBuilder[] name2 = new StringBuilder[1];

            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2.GetHashCode());



            #region Shallow copy 

            //name2 = name1;

            //Console.WriteLine("After Shallow copy ");
            //Console.WriteLine(name2.GetHashCode()); 
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2[0]);
            //Console.WriteLine(name1[0]);
            //name2[0].Append("Ahmed Gamal");

            //Console.WriteLine(name2.GetHashCode());
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2[0]);
            //Console.WriteLine(name1[0]);





            #endregion
            #region Deep Copy

            //name2 = (StringBuilder[])name1.Clone();


            //Console.WriteLine("After Deep copy ");
            //Console.WriteLine(name2.GetHashCode());
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2[0]);
            //Console.WriteLine(name1[0]);


            //name2[0].Append("Ahmed");
            //Console.WriteLine(name2.GetHashCode());
            //Console.WriteLine(name1.GetHashCode());
            //Console.WriteLine(name2[0]);
            //Console.WriteLine(name1[0]);

            #endregion

            #endregion


            #endregion








            #endregion

            #region IClonable

            //Employee e1 = new Employee() { Id = 2, Name = "Ahmed", Salary = 5000 };


            //Employee e2 = new Employee() { Id = 3, Name = "Amer", Salary = 9000 };


            //Console.WriteLine(e1);
            //Console.WriteLine(e2);
            // // shallow copy
            ////e2 = e1;
            ////Console.WriteLine(e1);
            ////Console.WriteLine(e2);




            // // Deep copy By clone method
            //e2 = (Employee)e1.Clone();
            //Console.WriteLine(e2.GetHashCode());
            //Console.WriteLine(e1.GetHashCode());    
            //Console.WriteLine(e1);
            //Console.WriteLine(e2);


            //// copy constructor

            //Employee e3 = new Employee(e1);

            //Console.WriteLine("After copy constructor");  
            //Console.WriteLine(e3.GetHashCode());

            //Console.WriteLine(e3);  




            #endregion


            #region  IComparable


            //int[] arr1 = [1, 2, 3, 4, 5, 6];
            // Array.Sort(arr1);
            //foreach (int item in arr1) 
            //{

            //    Console.WriteLine(item);




            //}



            //Employee[] emp1 =
            //{
            //    new Employee() {Id=10 , Name = "Ahmed" ,Salary=5000 } ,
            //    new Employee() {Id=20 ,Name ="Ali" ,Salary=6000 },
            //    new Employee() {Id=21 , Name= "Omer" ,Salary=9000 }



            //};

            //Array.Sort(emp1);  //.InvalidOperationException

            //Array.Reverse(emp1);

            //foreach (Employee item in emp1) 
            //{
            //    Console.WriteLine(item);



            //}




            #endregion


            #region IComparer

            //Employee[] emp1 =
            //{
            //    new Employee() {Id=10 , Name = "Ahmed" ,Salary=5000 } ,
            //    new Employee() {Id=20 ,Name ="Ali" ,Salary=6000 },
            //    new Employee() {Id=21 , Name= "Omer" ,Salary=9000 }



            //};

            //Array.Sort(emp1, new EmployeeComparerName()); 
            //Array.Reverse(emp1);

            //foreach (Employee item in emp1)
            //{
            //    Console.WriteLine(item);



            //}



            #endregion









        }
    }
}
