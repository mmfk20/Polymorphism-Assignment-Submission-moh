using System;

namespace EmployeePolymorphismApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee1 = new Employee
            {
                Id = 101,
                FirstName = "Alice",
                LastName = "Smith"
            };

            // Use polymorphism: create an object of type IQuittable
            IQuittable quittableEmployee = employee1;

            // Call the Quit method via the IQuittable interface reference
            quittableEmployee.Quit();

            // Keep the console open until a key is pressed
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
