using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambdas
{
    class Program
    {
        static void Main()
        {
            Func<int, int> o1 = i => i + i;
            Console.WriteLine( o1.Invoke(5));

            Func<int, int, int> o2 = (a, b) => a * b;
            Console.WriteLine(o2.Invoke(5,3));

            Func<int, int> o3 = (i) => i % 2;
            Console.WriteLine(o3.Invoke(6));

            Predicate<int> o4 = (i) => i % 2==0;
            Console.WriteLine(o4.Invoke(7));

            Action<int> o5 = (i) => Console.WriteLine(i);
            o5.Invoke(5);
           // Console.WriteLine(o1.ToString());


            Console.ReadLine();
        }
    }
}
