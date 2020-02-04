using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public override string Name { get => name; set => name = value; }
        public override string Address { get => address; set => address = value; }
        public string School { get => school; set => school = value; }        
        public double Pay { get => pay; set => pay = value; }

        public Staff(string _name, string _address, string _school, double _pay)
        {
            name = _name;
            address = _address;
            school = _school;
            pay = _pay;
        }

        public override string ToString()
        {
            return $"Staff [Name: {name}, Address: {address}, School: {school}, Pay: {pay}]";
        }

    }
}
