using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class Worker : Employee
    {
        int _hourlyWage;
        int _hoursWorked;


        public Worker(string name, int hourlyWage, int hoursWorked) : base(name)
        {
            _hourlyWage = hourlyWage;
            _hoursWorked = hoursWorked;

        }

        public override int GetBonusPerMonth()
        {
            return 0;
        }

        public override int GetSalaryPerMonth()
        {
            return _hourlyWage * _hoursWorked * 4;
        }

        public override bool IsBonusPaidOut()
        {
            return false;
        }
    }
}
