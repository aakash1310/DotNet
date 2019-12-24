using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayss
{
    class Program
    {
        static void Main1(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("enter marks for 5 students");

            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("entr marks for {0} student",i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
                Array.Sort(arr);
            Console.WriteLine("the lowest marks is :" +arr[0]);
            Array.Reverse(arr);
            Console.WriteLine("the highest marks is :" +arr[0]);

            Console.ReadLine();
        }
    }
}

namespace Arrays2
{
    class Program
    {
        static void Main2(string[] args)
        {
            Employee[] e = new Employee[5];

            Employee o1 = new Employee("aakash", 1111111m, 2);
            Employee o2 = new Employee("kawaldeep", 222222m, 3);
            Employee o3 = new Employee( "pooja",  333333m,  3);
            Employee o4 = new Employee( "shivani",  444444m,  4);
            Employee o5 = new Employee("tanmay", 555555m, 4);

            e[0] = o1;
            e[1] = o2;
            e[2] = o3;
            e[3] = o4;
            e[4] = o5;

            Console.WriteLine("All the Emploues are");
            Console.WriteLine();

            foreach (Employee a in e)
            {
                
                Console.WriteLine(a.Empno+" "+a.Name + " " + a.Basic + " "+ a.Dptno);

            }
            decimal maxsal = o1.Basic;
            int maxsalindex=0;

            for(int i=0; i<e.Length; i++)
            {
                if (maxsal < e[i].Basic)
                {
                    maxsal = e[i].Basic;
                    maxsalindex = i;
                    
                }
            }
            Console.WriteLine("Employee with higest salary is" );
            Console.WriteLine( e[maxsalindex].Empno+ " " +e[maxsalindex].Name + " " + e[maxsalindex].Basic);

            Console.ReadLine();
        }
    }

    class Employee
    {
        private int empno;
        private string name;
        private decimal basic;
        private short dptno;
        private decimal netsal;
        private static int count = 0;


        public Employee(string Name = "default", decimal Basic = 10000, short Dptno = 1)
        {

            count++;
            this.Empno = count;
            this.Name = Name;
            this.Basic = Basic;
            this.Dptno = Dptno;

        }
        public int Empno
        {
            set;
            get;
        }
        public String Name
        {
            set
            {
                if (value != "")
                    name = value;
                else
                    Console.WriteLine("not valid employee name");
            }
            get
            {
                return name;
            }
        }
        public decimal Basic
        {
            set
            {
                if (value >= 1000 && value <= 5000000000)
                    basic = value;
                else
                    Console.WriteLine("not valid salary");
            }
            get
            {
                return basic;
            }
        }

        public short Dptno
        {
            set
            {
                if (value >= 1)
                    dptno = value;
                else
                    Console.WriteLine("Department is empty");
            }
            get
            {
                return dptno;
            }
        }

        public void display()
        {
            Console.WriteLine("Employee number is " + empno);
            Console.WriteLine("Employee name is " + Name);
            Console.WriteLine("Employee salary is " + Basic);
            Console.WriteLine("Employee Department no  is " + Dptno);

        }
        
    }
}

namespace Arrays2d
{
    class Program
    {
        static void Main3(string[] args)
        {
            int[,] arr = new int[5, 3];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("enter the marks of {0} student of {1} subject",i,j);
                    arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int[] agg = new int[5];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                int temp = 0;
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    temp = temp + arr[i, j];
                }
                agg[i] = temp;
            }

            int highest = agg[0];
            int ind = 0;
            for (int i = 0; i < agg.Length; i++)
            {
                if (highest < agg[i])
                {
                    highest = agg[i];
                    ind = i;  
                }
            }

            Console.WriteLine("index of highest aggregate is: " +ind);
            Console.ReadLine();
        }
    }
}

