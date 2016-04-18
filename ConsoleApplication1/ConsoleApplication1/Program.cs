using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            C1 obj1 = new C1();

            obj1.Method1();

            //C1.TestVar += 10;

            C1 obj2 = new C1();
            obj2.Method1();


            obj1.Method1();
        }
    }


    public class C1
    {
        public int TestVar ;

        public void Method1()
        {
            Console.WriteLine("Value of TestVar " + TestVar);
        }
    }
}
