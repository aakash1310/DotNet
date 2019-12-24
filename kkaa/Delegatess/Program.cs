using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegatess
{

    public delegate void Mydele(int a);
    public delegate int Mydele1(int a);
    public delegate int Mydel2(int a, int b);
    public delegate int Mydel3(int a, int b);
    public delegate void dele();
    class Program
    {
        static void Main1(string[] args)
        {
            Mydele obj = new Mydele(Display);
            obj(5);

            Mydele1 obj1 = new Mydele1(add);
            int i = obj1(5);
            Console.WriteLine("add method called with delegate and addition is: "+i);
            Mydel2 obj2 = new Mydel2(multiply);
            int c= obj2(5, 6);
            Console.WriteLine("Multiply method called "+c);

            //Method in another class
            Class1 o = new Class1();
            Mydel3 obj3 = Class1.divide;
            int d = obj3(25, 25);
            Console.WriteLine("Divide method called " + d);

            dele ob = o.dis;
            ob();
            Console.ReadLine();
        }

        static void Display(int a)
        {
            Console.WriteLine("display with parameter :" + a);
        }

        static int add(int a)
        {
            return a + a;
        }
        static int multiply(int a,int b)
        {
            return a * b;
        }
    }

    public class Class1
    {
        public void dis()
        {
            Console.WriteLine("this is a method of other class which is called with a delegate");
        }
       public static  int  divide(int a,int b)
        {
            return a / b;
        }
       
    }
}

namespace MulticastDelegates
{
    public delegate int dele(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            dele obj = (dele)Delegate.Combine(new dele(subtract), new dele(add));
            Console.WriteLine(obj(20, 10));

            //dele obj = add;
            //Console.WriteLine( obj(10, 20));
            //obj = subtract;
            //Console.WriteLine( obj(20,10) );
            Console.ReadLine();
        }

        static int add(int a,int b)
        {
            return a + b;
        }

        static int subtract(int a,int b)
        {
            return a - b;
        }
    }
}
