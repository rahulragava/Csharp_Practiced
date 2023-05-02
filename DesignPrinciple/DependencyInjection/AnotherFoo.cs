using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple.DependencyInjection
{
    public interface IAnotherFoo
    {
        public void printFoo();
    }
    internal class AnotherFoo : IAnotherFoo
    {
        private IFoo foo;
        public AnotherFoo(IFoo foo)
        {
            this.foo = foo;
        }
        public void printFoo()
        {
            for (int i = 0; i < 10; i++)
            {
                foo.Message(i);
            }

        }
    }
}
