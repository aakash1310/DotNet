using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaps5_Interfaces_
{
    class Program
    {
        static void Main1(string[] args)
        {
            Class1 o = new Class1();
            o.Delete();
            o.Update();
            o.Insert();

            Console.ReadLine();
        }
    }

    public  interface  IDBFunctions
    {
         void Insert();
         void Update();
         void Delete();
    }


    public class Class1 : IDBFunctions
    {
        public void Delete()
        {
            Console.WriteLine("delete of class1");
        }

        public void Insert()
        {
            Console.WriteLine("insert of class1");
        }

        public void Update()
        {
            Console.WriteLine("update of class1");
        }
    }
}

namespace Interface2
{
    public class Program
    {
        public static void Main1()
        {
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();
            obj1.Insert();
            obj2.Insert();

            IDBFunctions idbObj;
            idbObj = obj1;
            idbObj.Update();

            idbObj = obj2;
            idbObj.Update();

            Console.ReadLine();
        }
        public static void Main121()
        {
            Class1 obj1 = new Class1();
            Class2 obj2 = new Class2();
            obj1.Insert();
            obj2.Insert();

            CallMethods(obj1);
            CallMethods(obj2);
           
            Console.ReadLine();

        }
        static void CallMethods(IDBFunctions o)
        {
            o.Insert();
        }
    }

    public interface IDBFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public class Class1 : IDBFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete method of Class1");
        }

        public void Insert()
        {
            Console.WriteLine("Insert method of Class1");
        }

        public void Update()
        {
            Console.WriteLine("Update method of Class1");
        }
        public void Display()
        {
            Console.WriteLine("Display method of Class1");
        }
    }

    public class Class2 : IDBFunctions
    {
        public void Delete()
        {
            Console.WriteLine("Delete method of Class2");
        }

        public void Insert()
        {
            Console.WriteLine("Insert method of Class2");
        }

        public void Update()
        {
            Console.WriteLine("Update method of Class2"); ;
        }
        public void Show()
        {
            Console.WriteLine("Show method of Class2");
        }
    }
}

namespace Interface3
{

    public class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.Insert();
            obj.Update();

            IDBFunctions oiDb;
            oiDb = obj;
            oiDb.Delete();

            IFileFunctions oiFile;
            oiFile = obj;
            oiFile.Delete();



            Console.ReadLine();
        }

    }

    public interface IDBFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }

    public interface IFileFunctions
    {
        void Open();
        void Close();
        void Delete();
    }


    public class Class1 : IDBFunctions, IFileFunctions
    {
        public void Close()
        {
            Console.WriteLine("Class1.Close");
        }

         void IDBFunctions.Delete()
        {
            Console.WriteLine("Class1.IDB.Delete");
        }

        public void Insert()
        {
            Console.WriteLine("Class1.Insert");
        }

        public void Open()
        {
            Console.WriteLine("Class1.Open");
        }

        public void Update()
        {
            Console.WriteLine("Class1.Update");
        }
        void IFileFunctions.Delete()
        {
            Console.WriteLine("Class1 Ifile.Delete ");
        }
    }
}