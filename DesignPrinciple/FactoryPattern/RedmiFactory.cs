using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPrinciple.FactoryPattern.FactoryInterface;

namespace DesignPrinciple.FactoryPattern
{
    internal class RedmiFactory : IMobileFactory
    {
        public IMobile CreateMobile(MobileType type)
        {
            return type switch
            {
                MobileType.Redmi => new Redmi(),
                MobileType.RedmiPro => new RedmiPro(),
                _ => throw new Exception(),
            };
        }
    }
}
