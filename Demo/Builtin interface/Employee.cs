using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Builtin_interface
{
    internal class Employee : ICloneable  ,IComparable<Employee>
    {
      
        public int Id { get; set; }
        public string? Name { get; set; }    
        public double Salary { get; set; }

       
        public override string ToString()
        {
            return $" Id {Id}  name {Name} Salary {Salary}";
        }

        public Employee()
        { 
            Id= 0 ; 
            Name= null ;    
            Salary= 0 ; 
        
        
        }

        // copy constructor 


        public Employee( Employee emp) 
        {
            Id = emp.Id ;   
            Name = emp.Name ;
            Salary = emp.Salary ;

        
        
        
        }


        public object Clone() 
        {
            return new Employee() 
            {
              Id = this.Id,  
              Name = this. Name,  
              Salary = this.Salary   

            
            };

        
        
        
        }

        public int CompareTo(Employee? emp1)
        {

            //if (this.Salary > emp1?.Salary)
            //    return 1;
            //else if(this.Salary<emp1?.Salary)
            //    return -1;
            //else
            //    return 0;
            //    
            return this .Salary.CompareTo(emp1?.Salary);    
            
        }
    }
}
