using kaps4_Inheritance_Abstration_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaps4_Inheritance_Abstration_
{
    class Program
    {
        static void Main1(string[] args)
        {
            DerivedClass o = new DerivedClass();
            o.display();
            o.display2();
            Console.ReadLine();
        }
    }

    public abstract class BaseClass
    {
        public void display()
        {
            Console.WriteLine("display of abstract class");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void display2()
        {
            Console.WriteLine("display of derived class");
        }
    }
}

namespace abs
{
    class Program
    {
        static void Main2()
        {
            DerivedClass o = new DerivedClass();
            o.show();
            o.display();
            Console.ReadLine();
        }
    }
    public abstract class BaseClass
    {
        public abstract void show();
        public virtual void display()
        {
            Console.WriteLine("display of asbtract baseclass");
        }

        
    }

    public class DerivedClass : BaseClass
    {
        public override void show()
        {
            Console.WriteLine("show method implemented in derived class");
        }
        public override void display()
        {
            Console.WriteLine("display of derived class ");
        }
    }

    
}


namespace Abs3
{
    class Program
    {
        static void Main()
        {
            //BaseClass o = new BaseClass();
            SubDerivedClass o2 = new SubDerivedClass();
            o2.Display();
            o2.Display2();
            o2.Show3();
            Console.ReadLine();
        }
    }
    public abstract class BaseClass
    {
        public abstract void Show1();
        public abstract void Show2();
        public abstract void Show3();
        public void Display()
        {
            Console.WriteLine("base display1");
        }
    }

    public abstract class DerivedClass : BaseClass
    {
        public override void Show1()
        {
            Console.WriteLine("show");
        }
        public void Display2()
        {
            Console.WriteLine("derived display2");
        }
    }

    public class SubDerivedClass : DerivedClass
    {
        public override void Show2()
        {
            Console.WriteLine("subderived show 2");
        }

        public override void Show3()
        {
            Console.WriteLine("subderived show 3");
        }
    }
}
