﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Project
{
    public class TalentWeaponless : TalentFighting
    {
        public TalentWeaponless(String name, String be, List<TalentDeviate> diverates, DSA_ADVANCEDVALUES at, bool parade) : base(name, be, diverates, at, parade)
        {

        }
    }
}
