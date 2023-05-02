using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple.DependencyInjection
{
    public interface IFoo
    {
        void Message(int i);
    }
    internal class Foo : IFoo
    {
        public void Message(int i)
        {
            Console.WriteLine($"from foo {i}");
        }
    }
}
