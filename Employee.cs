using System;

namespace EmployeePolymorphismApp
{
    // Employee class definition, implementing IQuittable interface
    public class Employee : IQuittable
    {
        // Properties for Employee class
        public int Id { get; set; }           // Unique identifier
        public string FirstName { get; set; } // Employee first name
        public string LastName { get; set; }  // Employee last name

        // Implement the Quit method from IQuittable
        public void Quit()
        {
            // Simple implementation to demonstrate quitting
            Console.WriteLine($"{FirstName} {LastName} has quit the company.");
        }
    }
}
