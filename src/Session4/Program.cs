using System;

namespace Session4
{
    class Program
    {
        static void Main(string[] args)
        {

            Person personObject1 = new Person();

            personObject1.Name = "Aaron";
            personObject1.Address = "1438 Ft Street";
            personObject1.Age = 50;
            
            Console.WriteLine("Program starts here");
            Console.WriteLine(personObject1.Name);
            Console.WriteLine(personObject1.Age);

            Person personObject2 = new Person();
            personObject2.Name = "Pragyan";
            personObject2.Address = "1438 Ft Street";

            Person personObject3 = new Person("Chintan");
        }
    }
}