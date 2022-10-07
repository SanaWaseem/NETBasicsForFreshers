using System;
using NetFramework;

namespace NetFramework
{

   internal class Program
    {
        static void Main()
        {

            //Call to public ctor
            //Employee employeeClass = new();

            //Call to private constructor
            //This is not possible; Give protection level inssue
            //Cannot inherit a class
            //restrict creating instance of class

            //Call to parameterised constructor 
            Employee employeeClass2 = new(1, "Sana Waseem", "Staff Software Engineer");
            employeeClass2.Name = "SW";


            //static constructor is called here

            //Parameterised constructor
            Person person = new Person("Shaikh" ,"Faraz");
            Person person2 = new Person(person); //copy constructor
            
        }
         

    }



}
