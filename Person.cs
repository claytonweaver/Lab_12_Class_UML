using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML
{
   abstract class Person
    {
        protected string name;
        protected string address;

        public abstract string Name { get; set; }
        public abstract string Address { get; set;}

        

        public override string ToString()
        {
            return $"Person [Name: {name}, Address: {address}]";
        }
    }
}
