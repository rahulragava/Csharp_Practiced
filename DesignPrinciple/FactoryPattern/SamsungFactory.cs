using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPrinciple.FactoryPattern.FactoryInterface;

namespace DesignPrinciple.FactoryPattern
{
    internal class SamsungFactory : IMobileFactory
    {
        public IMobile CreateMobile(MobileType type)
        {
            return type switch
            {
                MobileType.SamsungGalaxy => new SamsungGalaxy(),
                MobileType.SamsungA9 => new SamsungA9(),
                _ => throw new Exception(),
            };
        }
    }
}
