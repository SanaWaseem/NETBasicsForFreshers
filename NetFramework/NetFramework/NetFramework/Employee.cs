using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFramework
{
    public class Employee
    {

        private string Designation;
        private int Id;
        private string locationName;

        //////Public Default Constructor
        public Employee()
        {
            Id = 0;
            Name = "";
            Designation = "";
        }

        public string Name
        {
            get => locationName;
            set => locationName = value;
        }

        //Private Default Contructor 
        //Cannot create instance

        //Employee()
        //{
        //    Id = 1;
        //    Name = String.Empty;
        //    Designation = String.Empty;
        //}

        //Public Parameterized Constructor
        public Employee(int _Id, string _Name, string _Designation)
        {
            this.Name = _Name;
            this.Designation = _Designation;
            this.Id = _Id;
        }

        //Private Parameterized Constructor 
        //cannot create instance
        //private Employee(int _Id, string _Name, string _Designation)
        //{
        //    this.Name = _Name;
        //    this.Designation = _Designation;
        //    this.Id = _Id;
        //}

        //Static constructor

    }


    public class Person
    {
        private static int maxAge;
        private string last;
        private string first;

        //Copy constructor
        //public Person(Person prevPerson)
        //{
        //    first = prevPerson.first;
        //    last = prevPerson.last;
        //}


        //// Alternate copy constructor calls the instance constructor.
        public Person(Person previousPerson)
            : this(previousPerson.last, previousPerson.first)
        {
        }
        public Person(string lastName, string firstName)
        {
            last = lastName;
            first = firstName;
        }

        static Person()
        {
            maxAge = 55;
        }

        // Remaining implementation of Person class.
    }
    public class Adult : Person
    {
        private static int minimumAge;

        public Adult(string lastName, string firstName) : base(lastName, firstName)
        { }

        static Adult() : base() // static constructor cannot be inherited. Called only once before the instance of a class. 
        {/*
          Severity	Code	Description	Project	File	Line	Suppression State
          Error	CS5001	Program does not contain a static 'Main' method suitable for an entry point	NetFramework	D:\Projects\NETBasicsForFreshers\NetFramework\NetFramework\NetFramework\CSC	1	N/A

          */
            minimumAge = 18;
        }

        // Remaining implementation of Adult class.
    }

  
}


