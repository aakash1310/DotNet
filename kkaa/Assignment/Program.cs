using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("hello");
            //Class1 obj = new Class1();
            //Class1 obj1 = new class1(1000);

            Class1 o = new Class1();
            o.Prop2=1212;

            Class1 o1 = new Class1();
            o1.Prop3 = 8;

            Console.WriteLine(o.Prop2);
            Console.WriteLine(o1.Prop3);
            //Console.WriteLine(Class1.Prop5);
            //you cannot initialize a static property to do that we use static constructor

            Console.WriteLine(Class1.Prop5);
            Console.WriteLine(Class2.add(10, 5));
            Console.WriteLine(Class2.Prop6);
            Console.ReadLine();

        }
    }

    public class Class1
    {
        private static int prop5;


        public static int Prop5
        {
            set
            {
                prop5 = value;
            }
            get
            {
                return prop5;
            }
        }
        static Class1()
        {
             Prop5 = 10;
        }

        private int prop1;
        public int Prop1
        {
            set
            {
                if (value < 100)
                    prop1 = value;
                else
                    Console.WriteLine("invalid value");
            }
            get
            {
                return prop1;
            }
        }

        public int Prop2
        {
            set;
            get;
        }
        private int prop3;
        public int Prop3
        {
            set
            {
                if(value<10)
                prop3 = value;
            }
            get
            {
                return prop3;
            }
        }
        private int prop4;

        public int Prop4
        {
            set
            {
                prop4 = value;
            }
            get
            {
                return prop4;
            }
        }
       //public Class1()
       // {
       //     Console.WriteLine("no parameter constructor");
       // }

       // public Class1(int Prop1)
       // {
       //     this.Prop1 = Prop1;
       //     Console.WriteLine("parameter constructor " + prop1);
       // }
    }

     static class Class2
    {
        public static int add(int a, int b)
        {

            return a + b;
        }
        static Class2()
        {
            Prop6 = 19;
        }
        private static int  prop6;

        public static int Prop6
        {
            set
            {
                if (value < 20)
                    prop6 = value;
                else
                    Console.WriteLine("Invalid input");
            }
            get
            {
                return prop6;
            }
        }
    }
}
