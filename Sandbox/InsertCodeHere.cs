using System;
using System.Collections.Generic;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            var worker01 = new Worker("Mike", 120, 38);
            Console.WriteLine($"Employee Name: {worker01.GetName()}");
            Console.WriteLine($"Salary: {worker01.GetSalaryPerMonth()}");
            Console.WriteLine($"Bonus paid: {worker01.IsBonusPaidOut()}");


            var jmanager01 = new JuniorManager("Junior Boss", 1, 179, 5000);
            Console.WriteLine($"Junior Manager Name: {jmanager01.GetName()}");
            Console.WriteLine($"Junior Manager Salary: {jmanager01.GetSalaryPerMonth()}");
            Console.WriteLine($"Bonus Paid: {jmanager01.IsBonusPaidOut()}");
            Console.WriteLine($"");
            // The LAST line of code should be ABOVE this line
        }
    }
}
