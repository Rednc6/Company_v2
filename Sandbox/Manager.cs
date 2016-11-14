﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    abstract class Manager 
    {

        private String name;

        public Manager(String name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return name;
        }

        public abstract int GetSalaryPerMonth();

        public abstract int GetBonusPerMonth();

        public abstract bool IsBonusPaidOut();
    }
}
