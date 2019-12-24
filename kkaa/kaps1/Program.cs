using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaps1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello Double A");
            Class1 obj = new Class1();
           //int result = obj.add(1,2,3);
           // Console.WriteLine(result);


            //int result1 = obj.add1(b: 3, a: 1, c: 2);
            //Console.WriteLine(result1);
            int result3 = obj.add2(b:2, a:3);
            int result4 = obj.add2(10);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.ReadLine();
        }
    }

     class Class1
    {
       public int add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int add1(int a=0, int b=0, int c=0)
        {
            Console.WriteLine(b);
            return a + b + c;
        }
        public int add2(int a=0, int b=0)
        {
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            return a + b;
        }
    }

}
