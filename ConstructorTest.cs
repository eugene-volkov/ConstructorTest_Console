using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorTest_Console
{
    class ConstructorTest
    {
        public int i = 1;
        public ConstructorTest()
        {
            Console.WriteLine($"i is {i}");
        }
    }
}
