using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple.DependencyInjection
{
    public class Injector
    {
        public static IServiceProvider serviceProvider()
        {
            var provider = new ServiceCollection()
                .AddSingleton<IFoo, Foo>()
                .AddSingleton<IAnotherFoo,AnotherFoo>()
                .BuildServiceProvider();
            return provider;
        }
    }
}
