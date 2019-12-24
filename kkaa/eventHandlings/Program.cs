using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eventHandlings
{
    class Program
    {
        static void Main1()
        {
            Class1 obj = new Class1();
            obj.FalseData += Obj_FalseData;
            obj.Name = "kk";

            Console.ReadLine();
        }

        private static void Obj_FalseData()
        {
            Console.WriteLine("event handler it is!");
        }
    }
    public delegate void FalseDataEventHandeler();
    public class Class1
    {
        public event FalseDataEventHandeler FalseData;

        private string name;
        public string Name
        {
            set
            {
                if (value != "")
                    name = value;
                else
                    FalseData();
            }
            get
            {
                return name;
            }
        }
    } 
}

namespace eventHandlings2
{
    class Program
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.InvalidData += Obj_InvalidData;
            obj.Data = 1000;
            Console.ReadLine();

        }

        private static void Obj_InvalidData(int i)
        {
            Console.WriteLine("event handeler " + i.ToString());
        }
    }

    public delegate void InvalidDataEventHandler(int i);

    class Class1
    {
        public event InvalidDataEventHandler InvalidData;
        private int data;
        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                if (value < 100)
                    data = value;
                else
                    if (InvalidData != null)
                    InvalidData(value);
            }
        }
    }
}



