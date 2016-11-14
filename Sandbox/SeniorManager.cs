using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class SeniorManager : Manager
    {
        int _baseSalary;
        int _bonus;
        int _hoursWorked;
        int _performanceLevel;

        


        public SeniorManager(string name, int baseSalary, int hoursWorked, int bonus, int performanceLevel) : base(name)
        {
            _baseSalary = baseSalary;
            _hoursWorked = hoursWorked;
            _bonus = bonus;
            _performanceLevel = performanceLevel;

        }

        public override int GetBonusPerMonth()
        {
      
            return _bonus;
        }

        public override int GetSalaryPerMonth()
        {
            if (_performanceLevel >= 6)
            {
                return _baseSalary + _bonus;
            }
            return _baseSalary;
        }

        public override bool IsBonusPaidOut()
        {
            if (_performanceLevel >= 6)
            {
                return true;
            }
            return false;
        }
    }
}
