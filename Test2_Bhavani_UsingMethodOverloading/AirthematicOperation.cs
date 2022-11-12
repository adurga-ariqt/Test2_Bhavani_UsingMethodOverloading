using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2_Bhavani_UsingMethodOverloading
{
    public  class AirthematicOperation
    {
        public void Add( int a,int b)
        {
            int sum = a + b;
            Console.WriteLine("The sum of two numbers is :" + sum);
        }
        public void Add(int a, int b ,int c)
        {
            int sum = a + b+c;
            Console.WriteLine("The sum of Three numbers is :" + sum);
        }

    }
}
