using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaps6_Ref_and_Value_
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o1 = new Class1();
            Class1 o2 = new Class1();
            o1.i = 100;
            o2.i = 200;
            o1 = o2;
            o2.i = 300;
            Console.WriteLine(o1.i);
            Console.WriteLine(o2.i);
            Console.ReadLine();
        }
        static void Main11()
        {
            int o1, o2;
            o1 = 100;
            o2 = 200;
            o1 = o2;
            o2 = 300;
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }
        static void Main12()
        {
            string o1, o2;
            o1 = "100";
            o2 = "200";
            o1 = o2;
            o2 = "300";
            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();
        }
    }
    public class Class1
    {
        public int i;
    }
}

namespace Ref_and_Val1
{
    class Program
    {
        static void Main2121()
        {
            int i = 10;
            int j = 20;
            Initialize(out i, out j);
            Swap( i, j);
            Console.WriteLine(i);
            Console.WriteLine(j);

            Swap1(ref i, ref j);
            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.ReadLine();
        }
        static void Swap( int i,  int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static void Swap1(ref int i, ref int j)
        {
            int temp = i;
            i = j;
            j = temp;
        }
        static void Initialize(out int i, out int j)
        {
            //Console.WriteLine(i);
            i = 100;
            j = 200;
        }
    }
}

namespace Ref_and_Val2
{
    class Program
    {
        static void Main()
        {
            Class1 o = new Class1();
            o.i = 1;
            //DoSomething1(o);
            //DoSomething2(o);
           DoSomething3(ref o);

            Console.WriteLine(o.i);
            Console.ReadLine();
        }

        static void DoSomething1(Class1 o2)
        {
            o2.i = 100;
        }
        static void DoSomething2(Class1 o2)
        {
            Console.WriteLine(o2.i);
            o2 = new Class1();
            o2.i = 100;
            Console.WriteLine(o2.i);
        }
        static void DoSomething3(ref Class1 o2)
        {
            Console.WriteLine(o2.i);
            o2 = new Class1();
            o2.i = 100;

        }
    }
    public class Class1
    {
        public int i;
    }
}
