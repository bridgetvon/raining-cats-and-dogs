using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {
          static List<Employee> GetEmployees()
            {
                List<Employee> employees = new List<Employee>();
                while(true)
                {
                    Console.WriteLine("PLease enter a name: (leave empty to exit) :" );

                    string firstName = Console.ReadLine();
                    if(firstName == "")
                    {
                        break;
                    }
                    Console.Write("Enter last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write("Enter ID: ");
                    // cast Id to an int
                    int id = Int32.Parse(Console.ReadLine());
                    Console.Write("Enter phot URL: ");
                    string photoUrl = Console.ReadLine();
                    // Create a new employee instance.
                    Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
                    employees.Add(currentEmployee);
                }
                // return the list so it can be passed to another method.
                return employees;
            }
        static void Main(string[] args)
        {
            // Employee getting code. 
            List<Employee> employees = GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
        }
    }
}