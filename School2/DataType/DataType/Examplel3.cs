using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType
{
    class Examplel3
    {
        static void Main(String[] args)
        {
            int valueVal = 5;
            Test(valueVal);
            Console.WriteLine("the value of the variable is {O}", valueVal);
            Console.ReadLine();
        }
        static void Test(int valueVal)
        {
            int temp = 5;
            valueVal= temp * 2;
        }
    }
}
