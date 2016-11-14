using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class JuniorManager : Manager
    {
        int _baseSalary;
        int _bonus;
        int _hoursWorked;

       

        public JuniorManager(string name, int baseSalary, int hoursWorked ,int bonus) : base(name)
        {
            _baseSalary = baseSalary;
            _bonus = bonus;
            _hoursWorked = hoursWorked;
               

        }

        public override int GetBonusPerMonth()
        {
            return _bonus;
        }

        public override int GetSalaryPerMonth()
        {
            if (_hoursWorked >= 180)
            {
                return _baseSalary + _bonus;
                
            }
            return _baseSalary;
        }

        public override bool IsBonusPaidOut()
        {
            if (_hoursWorked >= 180)
            {
                return true;
            }
            else
                return false;
        }
    }
}
