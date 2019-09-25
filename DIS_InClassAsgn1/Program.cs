using System;

namespace Project02_ObjectOrientedProgramming
{
    class Program
    {

        static void Main(string[] args)
        {
            Person Student = new Person { firstName = "John", lastName = "Doe" };
        }
    }

    /// <summary>
    /// Define a class for people
    /// </summary>
    class Person
    {
        public string firstName;
        public string lastName;
        public string salutation;

        public string getName()
        {
            return salutation + " " + firstName + " " + lastName;
        }
    }


}