using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPrinciple.FactoryPattern.FactoryInterface;

namespace DesignPrinciple.FactoryPattern
{
    internal class SamsungA9 : IMobile
    {
        public void MobileDescription()
        {
            Console.WriteLine("this is samsung A9");
        }
    }
}
