﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple.FactoryPattern.FactoryInterface
{
    public interface IMobileFactory
    {
        IMobile CreateMobile(MobileType type);
    }
}
