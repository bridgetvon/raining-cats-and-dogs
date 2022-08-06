using System;
using System.Collections.Generic;
using System.IO;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        public static void PrintEmployees(List<Employee> employees)
        {
                for (int i = 0; i < employees.Count; i++)
                {
                    // {0, -10} left aligned and padded at least ten characters
                    // \t the tab character
                    // {1,-20} left aligned and padded twenty characters
                    string template = "{0, -10}\t{1,-20}\t{2}";
                    Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetName(), employees[i].GetPhotoUrl()));
                }
        }
        public static void MakeCSV(List<Employee> employees)
        {
            // Write the CSV to the data folder 
            if(!Directory.Exists("data"))
            {
                Directory.CreateDirectory("data");
                // using to temporarily use this resource to help memory allocation.
                // whatever is defined in the parenthesis is only available in the subsequent curly braces
                // once the block runs the resource (here the streamwriter) is removed.
               using (StreamWriter file = new StreamWriter("data/employees.csv"))
               {
                   file.WriteLine("ID,Name,PhotoUrl");
               }
            }
        }

    }

}
