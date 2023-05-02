using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPrinciple.Adapter_Pattern
{

    public class Program
    {
       public static void Main()
        {
            Duck duck = new Duck();
            Turkey? turkey = new Turkey();

            IDuck duckAdapter = new DuckAdapter(turkey);
            duckAdapter.Quack();
            duckAdapter.Fly();
        }
        

    }
}
