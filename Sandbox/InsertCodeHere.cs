using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {

        List<Employee> ListofEmployees = new List<Employee>();

        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            var worker01 = new Worker("Mike", 120, 38);
            Console.WriteLine($"Employee Name: {worker01.GetName()}");
            Console.WriteLine($"Salary: {worker01.GetSalaryPerMonth()}");
            Console.WriteLine($"Bonus paid: {worker01.IsBonusPaidOut()} \n");


            var jmanager01 = new JuniorManager("Small Boss", 1, 181, 5000);
            Console.WriteLine($"Junior Manager Name: {jmanager01.GetName()}");
            Console.WriteLine($"Junior Manager Salary: {jmanager01.GetSalaryPerMonth()}");
            Console.WriteLine($"Bonus Paid: {jmanager01.IsBonusPaidOut()} \n");


            var Smanager01 = new SeniorManager("Big Boss", 2, 180, 50000, 6);
            Console.WriteLine($"Senior Managers Name: {Smanager01.GetName()}");
            Console.WriteLine($"Senior Managers Salary: {Smanager01.GetSalaryPerMonth()}");
            Console.WriteLine($"Bonus Paid: {Smanager01.IsBonusPaidOut()} \n");

            ListofEmployees.Add(worker01);
            ListofEmployees.Add(jmanager01);
            ListofEmployees.Add(Smanager01);

            foreach (var item in ListofEmployees)
            {
                Console.WriteLine($"Name: {item.GetName()}");
                Console.WriteLine($"Salary: {item.GetSalaryPerMonth()}");
                Console.WriteLine($"Bonus Paid: {item.IsBonusPaidOut()} \n");
            }
            
            // The LAST line of code should be ABOVE this line
        }
    }
}
