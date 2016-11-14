using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    abstract class Manager : Employee
    {

        public Manager(string name) : base(name)
        {

        }

        public override int GetBonusPerMonth()
        {
            throw new NotImplementedException();
        }

        public override int GetSalaryPerMonth()
        {
            throw new NotImplementedException();
        }

        public override bool IsBonusPaidOut()
        {
            throw new NotImplementedException();
        }
    }
}
