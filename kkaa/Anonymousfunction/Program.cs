using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymousfunction
{
    public delegate int Mydel(int a, int b);
    public delegate void Mydel2();
    class Program
    {
        static void Main(string[] args)
        {
            string s = "kk";
            Mydel obj = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine(obj(10,20));
            Mydel2 obj1=delegate()
        {
                Console.WriteLine("Print the display function " + s);
            };
            obj1();

            Console.ReadLine();
        }


        public static int add(int a, int b)
        {
            return a + b;
        }
        public static void Display()
        {
            Console.WriteLine("Print the display function");
        }
    }
}
