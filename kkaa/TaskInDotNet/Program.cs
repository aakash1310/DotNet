using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//calling a method with void return type using taskobj.Start
namespace TaskInDotNet
{
    class Program
    {
        static void Main1()
        {
            Action obj = func1;
            Task t1 = new Task(obj);
            t1.Start();

            Task t2 = new Task(func2);
            t2.Start();

            Console.ReadLine();
        }

        static void func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("First fun called from {0}",Thread.CurrentThread.ManagedThreadId);
            }
        }
        static void func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Second fun called from {0}", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}

//calling a method with void return type using Task.Run and Task.Factory.StartNew
namespace TaskInDotNet1
{
    class Program
    {
        static void Main2()
        {
            Action obj = func1;
            Task t1 = Task.Run(obj);

            Task t2 = Task.Factory.StartNew(func2);

            Console.ReadLine();
        }

        static void func1()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("First fun called from {0}", Thread.CurrentThread.ManagedThreadId);
            }
        }
        static void func2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Second fun called from {0}", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}


//calling a method with void return type and parameters

namespace TaskInDotNet2
{
    class Program
    {
        static void Mai4()
        {
            Action<object> objAction1 = Func1;
            Task t1 = new Task(objAction1, "aaa");

            int i = 100;
            //Task.Run - cannot be used with parameters. 
            //use anonymous methods instead to access variables declared in calling code
            //Action objAction1 = Func1;
            //Task t1 = Task.Run(objAction1);

            //this is with anonymous function
            Task t3 = Task.Run(delegate () { Console.WriteLine("task called {0}", i); });


            Action<object> objAction2 = Func2;
            Task t2 = Task.Factory.StartNew(objAction2, "bbb");

            t1.Start();
            //t1.RunSynchronously()
            t1.Wait();

            



            Console.ReadLine();
        }
        static void Func1(object obj)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("first Func called {0}{1}", i, obj.ToString());
            }
        }
        static void Func2(object obj)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("second Func called {0},{1}", i, obj.ToString());
            }
        }
    }


    
}


//calling methods with return type

namespace TaskInDotNet3
{
    class Program
    {
        static void Main()
        {
            Func<int> objFunc1 = Func1;
            Task<int> t1 = new Task<int>(objFunc1);
            t1.Start();

            Func<object, int> objFunc2 = Func2;
            Task<int> t2 = new Task<int>(objFunc2, "bbb");
            t2.Start();


            if (!t1.IsCompleted)
                t1.Wait();

            Console.WriteLine(t1.Result);

            if (!t2.IsCompleted)
                t2.Wait();
            Console.WriteLine(t2.Result);

            Console.ReadLine();
        }
        static int Func1()
        {
            int i;
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine("first Func called {0}", i);
            }
            return i;
        }
        static int Func2(object obj)
        {
            int i;
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine("second Func called {0},{1}", i, obj.ToString());
            }
            return i;
        }
    }
}