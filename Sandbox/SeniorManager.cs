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

        bool _BonusPaid;


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
            return _baseSalary;
        }

        public override bool IsBonusPaidOut()
        {
            throw new NotImplementedException();
        }
    }
}
