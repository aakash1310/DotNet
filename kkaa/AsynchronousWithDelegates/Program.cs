using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

//call a method asynchronously using DelgateObject.BeginInvoke()
namespace AsynchronousWithDelegates1
{
    public delegate void Mydel();
    class Program
    {
        static void Main1(string[] args)
        {
             Mydel o = show;
            Console.WriteLine("before show is called ");
            o.BeginInvoke(null, null);
            Console.ReadLine();

        }
        static void show()
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("this is show function whis is called asyn-ly");
        }
    }
}

//call a method with parameters asynchronously using DelgateObject.BeginInvoke()

namespace AsynchronousWithDelegates2
{
    public delegate void Mydel(string s);
    class Program
    {
        static void Main2(string[] args)
        {
            Console.WriteLine("before show is called ");
            Mydel obj = show;
            obj.BeginInvoke("kawaldeep", null, null);
            Console.ReadLine();
        }
        static void show(string s)
        {
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("this is show function with paramaters which is called async-ly with parameter :" +s);

        }
    }
}


//call a method with parameters asynchronously using DelgateObject.BeginInvoke() and use a Callback fn
namespace AsynchronousWithDelegates3
{
    public delegate string  Mydel(string s);
    class Program
    {
        static void Main3(string[] args)
        {
            Console.WriteLine("before show is called ");
            Mydel obj = show;
            obj.BeginInvoke("kawaldeep", CallBackMethod, null);
            Console.ReadLine();
        }

        private static void CallBackMethod(IAsyncResult ar)
        {
            Console.WriteLine("callback method");
        }


        static string show(string s)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Display string "+s);
            return s.ToUpper();
        }
    }
}

//call a method with parameters asynchronously using DelgateObject.BeginInvoke() and use a Callback fn
//use a global object(objDel) to access it in the callback method
//use objDel.EndInvoke to get the return value
namespace AsynchronousWithDelegates4
{
    public delegate string Mydel(string s);
    class Program
    {
        static Mydel obj;
        static void Main4(string[] args)
        {
            Console.WriteLine("before show is called ");
            obj = show;
           IAsyncResult ar = obj.BeginInvoke("kawaldeep", CallBackMethod, null);
            Console.ReadLine();
        }

        private static void CallBackMethod(IAsyncResult ar)
        {
            string val = obj.EndInvoke(ar);
            Console.WriteLine("callback method");
            Console.WriteLine("value returned from function: " +val.ToString());
        }


        static string show(string s)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Display string " + s);
            return s.ToUpper();
        }
    }
}


//call a method with parameters asynchronously using DelgateObject.BeginInvoke() and use a Callback fn
//pass objDel as the last parameter in BeginInvoke
//use objDel.EndInvoke to get the return value
namespace AsynchronousWithDelegates5
{
    public delegate string Mydel(string s);
    class Program
    {
       
        static void Main5(string[] args)
        {
            Console.WriteLine("before show is called ");
             Mydel obj = show;
            IAsyncResult ar = obj.BeginInvoke("kawaldeep", CallBackMethod, obj);
            Console.ReadLine();
        }

        private static void CallBackMethod(IAsyncResult ar)
        {
            Mydel obj = (Mydel)ar.AsyncState;
            string val = obj.EndInvoke(ar);
            Console.WriteLine("callback method");
            Console.WriteLine("value returned from function: " + val.ToString());
        }


        static string show(string s)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Display string " + s);
            return s.ToUpper();
        }
    }
}


//call a method with parameters asynchronously using DelgateObject.BeginInvoke() and use a Callback fn
//use AsyncResult.AsyncDelegate to get objDel
//use objDel.EndInvoke to get the return value
namespace AsynchronousWithDelegates6
{
    public delegate string Mydel(string s);
    class Program
    {
        static void Main6(string[] args)
        {
            Console.WriteLine("before show is called ");
            Mydel obj = show;
            IAsyncResult ar = obj.BeginInvoke("kawaldeep", CallBackMethod, null);
            Console.ReadLine();
        }

        private static void CallBackMethod(IAsyncResult ar)
        {
            AsyncResult objresult = (AsyncResult)ar;
            Mydel obj = (Mydel)objresult.AsyncDelegate;
            string val = obj.EndInvoke(ar);
            Console.WriteLine("callback method");
            Console.WriteLine("value returned from function: " + val.ToString());
        }


        static string show(string s)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Display string " + s);
            return s.ToUpper();
        }
    }
}


//call a method with parameters asynchronously using DelgateObject.BeginInvoke() and use a Callback fn
//using Anon method
//use objDel.EndInvoke to get the return value
namespace AsynchronousWithDelegates7
{
    public delegate string Mydel(string s);
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("before show is called ");
            Mydel obj = show;
            obj.BeginInvoke("kawaldeep", delegate(IAsyncResult ar)
               { 


                string val = obj.EndInvoke(ar);
                Console.WriteLine("callback method");
                Console.WriteLine("value returned from function: " + val.ToString());
            }, null);

            Console.ReadLine();
        }
        static string show(string s)
        {
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Display string " + s);
            return s.ToUpper();
        }
    }
}
