using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplicitVariables
{
    class Program
    {
        static void Main1(string[] args)
        {
            var x = 10;
            var y = "kawaldeep";

            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine(x.GetType());
            Console.WriteLine(y.GetType());
            Console.ReadLine();
        }
    }
}


namespace AnonymousTypes
{
    class Program
    {
        static void Main2(string[] args)
        {
            var myEmp = new {Name= "kawaldeep" , Empno = 1234 , Basic = 15000 };
            var myEmp1 = new { Name = "Aakash", Empno = 1235, Basic = 12000 };

            Console.WriteLine("{0} {1} {2}" , myEmp.Name,myEmp.Empno,myEmp.Basic);
            Console.WriteLine("{0} {1} {2}", myEmp1.Name, myEmp1.Empno, myEmp1.Basic);

            Console.WriteLine( myEmp.GetType().ToString());
            Console.WriteLine(myEmp1.GetType().ToString());
            Console.ReadLine();
        }
    }
}

namespace ExtentionMethods
{
    //- Extension methods must be declared inside a static class
    //- Mark a method as an extension method by using the --this-- keyword as a modifier 
    //           on the first parameter of the method
    //- Every extension method can be called either from the object 
    //   or statically via the defining static class
    static class ExtMethodClass
    {
        public static void M1(this int i)
        {
            Console.WriteLine("this is a extention method of int " +i);
        }
        public static void M2(this String i)
        {
            Console.WriteLine(i);
        }
        public static void baseobjectExtMethod(this object i)
        {
            Console.WriteLine(i);
        }
    }
        class Program
        {
        static void Main3()
        {
            int i = 100;
            i.M1();
            i.baseobjectExtMethod();
            ExtMethodClass.M1(i);
            

            String s = "Kawaldeep Kashyap";
            s.M2();
            s.baseobjectExtMethod();
            ExtMethodClass.M2(s);

            Myclass obj = new Myclass();
            int res =  obj.sub(20, 5);
            Console.WriteLine("the extention method of interface :" +res);
            Console.ReadLine();
        }
         
        }

    public interface Myinterface
    {
        int add(int a, int b);
        int mul(int a, int b);
    }
    public class Myclass : Myinterface
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int mul(int a, int b)
        {
            return a * b;
        }
    }

    public static class ExtMethodOfInterface
    {
        public static int sub(this Myinterface mio, int a, int b)
        {
            return a - b;
        }
    }

    
}

namespace PartialClasses
{
    public partial class C1
    {
        public int i;
    }
    public partial class C1
    {
        public string s;
    }
    public partial class C1
    {
        public decimal d;
    }

    public class Program
    {
        static void Main4()
        {
            C1 o = new C1();
            o.d = 1010m;
            o.i = 1;
            o.s = "kawaldeep";

        }
    }
}

namespace PartialMethods
{
    //Partial methods can only be defined within a partial class.
    //Partial methods must return void.
    //Partial methods can be static or instance level.
    //Partial methods cannnot have out params
    //Partial methods are always implicitly private.

    public class Program
    {
        static void Main()
        {
            Myclass o = new Myclass();
            Console.WriteLine(  o.check()  );

            Console.ReadLine();
        }
    }

    public partial class Myclass
    {
        private bool vali = true;
        partial void validate();
        public bool check()
        {
            validate();
            return vali;
        }
    }
    public partial class Myclass
    {

        partial void validate()
        {
            vali = false;
        }
    }
}