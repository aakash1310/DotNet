using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaps3
{
    class Program
    {
        static void Main1(string[] args)
        {

        }
    }

    public class BaseClass
    {
        public int PUBLIC = 10;
        private int PRIVATE = 20;
        internal int INTERNAL = 30;
        protected int PROTECTED = 40;
        protected internal int PROTECTED_INTERNAL = 50;
    }

    public class DerivedClass : ClassLibrary.BaseClass
    {
        int a = 60;
        static void Main2(string[] args)
        {
            DerivedClass o = new DerivedClass();
            Console.WriteLine(o.PROTECTED);
            Console.WriteLine(o.PROTECTED_INTERNAL);
            Console.WriteLine(o.PUBLIC);
            
            Console.ReadLine();
        }
       
    }
}

namespace Inheritance
{

    public class Program
    {
        public static void Main3()
        {
            DerivedClass o = new DerivedClass(3,4);
            //Baseclass o1 = new Baseclass(4);
            Console.ReadLine();
        }
    }
    public class Baseclass
    {
        public int i = 10;

        public Baseclass()
        {
            this.i = 11;
            Console.WriteLine("BaseClass non Param Constructor  "+i);
        }

        public Baseclass(int i)
        {
            this.i = i;
            Console.WriteLine("Baseclass Param Constructor " +i);
        }
    }

    public class DerivedClass: Baseclass
    {
        int j = 20;
        public DerivedClass()
        {
            this.j = 21;
            Console.WriteLine("Derived Class no param constructor "+j);
        }
        public DerivedClass(int j,int i) : base(i)
        {
            this.j = j;
            Console.WriteLine("Derived Class  param constructor " + j);
        }

    }
}
namespace Inheritance2
{

    public class Program
    {
        public static void Main22()
        {
            // DerivedClass d = new DerivedClass();

            BaseClass b;
            b = new DerivedClass();

            b.Display1();
            
            b.Display2();
            Console.ReadLine();
        }
        public static void Main()
        {
            // DerivedClass d = new DerivedClass();

            BaseClass b;
            b = new SubsubDerivedClass();

            b.Display1();

            b.Display2();

            SubsubDerivedClass ss = new SubsubDerivedClass();
            ss.Display2();
            Console.ReadLine();
        }
    }

    public class BaseClass
    {

        public virtual void Display1()
        {
            Console.WriteLine("Display 1 of base class");
        }

        public  void Display2()
        {
            Console.WriteLine("Display 2 of base class ");
        }
        public void Display3()
        {
            Console.WriteLine("Display 3 of base class");
        }

    }

    public class DerivedClass: BaseClass
    {
        //overload the base class method
        public void Display1(string s)
        {
            Console.WriteLine("derived class is "+s);
        }
        //hide the base class method
        public  override void Display1()
        {
            Console.WriteLine("Display 1 of Derived class ");
        }
        public void Display2()
        {
            Console.WriteLine("Display 2 of Derived class ");
        }
    }

    public class SubDerivedClass : DerivedClass
    {
        public override sealed void  Display1()
        {
            Console.WriteLine("display1 of SubDerivedClass ");
        }
       
    }

    public class SubsubDerivedClass : SubDerivedClass
    {
        public new void  Display1()
        {
            Console.WriteLine("display1 of SubsubDerivedClass ");
        }
    }
}
