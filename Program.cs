using System;

namespace Lab_12_Class_UML
{
    class Program
    {
        static void Main(string[] args)
        {
            Student clay = new Student("Clayton Weaver", "3311 Birchwood", "C#", 2020, 10000);
            Student john = new Student("John Smith", "4532 Blaine", "Java", 2020, 9000);
            Staff bob = new Staff("Laurie Smee", "2929 Wicker", "Grand Circus", 60000);

            Person[] people = { clay, john, bob };
            
            foreach(var p in people)
            {
                Console.WriteLine(p.ToString()); 
            }
                 
        }
    }
}
