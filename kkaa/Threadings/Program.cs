using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threadings
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("before");
            Thread t1 = new Thread(new ThreadStart(show));
            Thread t2 = new Thread(display);
            t1.Start();
            
            t2.Start();
            //t2.IsBackground = true;
            //t2.Join();
             if(t1.ThreadState == ThreadState.Running) ;
            {
                Console.WriteLine("t1 is running state");
            }
           
            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("main " + i);
            }
            Console.WriteLine("after");
             Console.ReadLine();

        }
        static void show()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("show method" +i);
            }
        }
        static void display()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("display method" +i);
            }
        }
        
    }
}

namespace Threadings1
{
    class Program
    {
        static void Main1()
        {

            Thread t1 = new Thread(add);
            Thread t2 = new Thread(new ParameterizedThreadStart(sub));
            t1.Start("kk");
            // t2.Start(new Class1 { i = 10, j = 20 });
            t2.Start(new Employee { Name="kk",Empno=100});
            for(int i = 0; i < 50; i++)
            {
                Console.WriteLine("Main Thread"+i);
            }
            Console.ReadLine();
        }

        static void add(Object o)
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine("Method 1 "+o+i);
            }
        }
        static void sub(Object o)
        {
            Employee obj = (Employee)o;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Method 2 " +" "+ obj.Name.ToString() +" "+ obj.Empno.ToString());
            }
        }
    }
    class Class1
    {
        public int i, j;
    }

    class Employee
    {
        private int empno;
        private string name;
        public int Empno
        {
            set;
            get; 
        }
        public string Name
        {
            set;get;
        }
    }
}

namespace Threadings2
{
    class Program
    {
        static void Main2()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc1), "kk");
            ThreadPool.QueueUserWorkItem(new WaitCallback(PoolFunc2));
            int wor;
            int port;
            ThreadPool.GetMaxThreads(out wor,out port);
            Console.WriteLine(wor + " " + port);
            
            Console.ReadLine();
        }

        static void PoolFunc1(Object o)
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("First Thread "+o.ToString()+i.ToString());
            }
        }

        static void PoolFunc2(Object o)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Second Thread "  + i.ToString());
            }
        }
    }
}

namespace Threadings3
{
    class MainClass
    {
        static object lockObject = new object();
        static int i = 0;
        static void Main()
        {
            Thread t1 = new Thread(new ThreadStart(FuncLock));
            Thread t2 = new Thread(new ThreadStart(FuncMonitor));
            Thread t3 = new Thread(new ThreadStart(FuncInterlocked));
            t1.Start();
            t2.Start();
            t3.Start();

            Console.WriteLine("Finished Main");
            Console.ReadLine();
        }
        static void FuncLock()
        {
            lock (lockObject)   //Monitor.Enter(lockObject)
            {
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
                i++;
                Console.WriteLine("First FuncLock " + i);
            }  //Monitor.Exit(lockObject)
        }

        static void FuncMonitor()
        {
            Monitor.Enter(lockObject);
            {
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
                i++;
                Console.WriteLine("Second Monitor " + i.ToString());
            }
            Monitor.Exit(lockObject);

        }

        static void FuncInterlocked()
        {


            Interlocked.Add(ref i, 10);
            Console.WriteLine("Third Interlocked " + i.ToString());
            Interlocked.Increment(ref i);
            Console.WriteLine("Third Interlocked " + i.ToString());
            Interlocked.Decrement(ref i);
            Console.WriteLine("Third Interlocked " + i.ToString());
            Interlocked.Exchange(ref i, 100);
            Console.WriteLine("Third Interlocked " + i.ToString());
        }

    }
}