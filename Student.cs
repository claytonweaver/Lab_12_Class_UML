using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public override string Name { get => name; set => name = value; }
        public override string Address { get => address; set => address = value; }
        public string Program { get => program; set => program = value; }
        public int Year { get => year; set => year = value; }
        public double Fee { get => fee; set => fee = value; }
        

        public Student(string _name, string _address, string _program, int _year, double _fee)
        {
            name = _name;
            address = _address;
            program = _program;
            year = _year;
            fee = _fee;
        }

        public override string ToString()
        {
            return $"Student [Name: {name}, Address: {address}, Program: {program}, Year: {year}, Fee: {fee}]";
        }


    }
}
