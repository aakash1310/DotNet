using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee o1 = new Employee("aakash",25000.36m,2);
            Employee o2 = new Employee("kawaldeep", 40000.65m, 3);
            Employee o3 = new Employee(Name:"pooja", Basic:40000.65m, Dptno:3);
            Employee o4 = new Employee(Name:"shivani", Basic:30000.65m, Dptno:4);

            o1.display();
            Console.WriteLine("Net salary is :" +o1.Calculatesalary() + Environment.NewLine);

            o2.display();
            Console.WriteLine("Net salary is :" + o2.Calculatesalary() + Environment.NewLine);

            o3.display();
            Console.WriteLine("Net salary is :" + o3.Calculatesalary() + Environment.NewLine);

            o4.display();
            Console.WriteLine("Net salary is :" + o4.Calculatesalary() + Environment.NewLine);
            Console.WriteLine();

            Employee1 o11 = new Employee1(Name:"aakash",Basic: 25000.36m, Dptno:2);
            Employee1 o12 = new Employee1(empno: 102,Name:"kawaldeep", Basic: 40000.65m, Dptno: 3);
            Employee1 o13 = new Employee1(Name: "pooja", Basic: 40000.65m, Dptno: 3);
            Employee1 o14 = new Employee1(Name: "shivani", Basic: 30000.65m, Dptno: 4);

            o11.display();
            Console.WriteLine("Net salary is :" + o1.Calculatesalary() + Environment.NewLine);

            o12.display();
            Console.WriteLine("Net salary is :" + o2.Calculatesalary() + Environment.NewLine);

            o13.display();
            Console.WriteLine("Net salary is :" + o3.Calculatesalary() + Environment.NewLine);

            o14.display();
            Console.WriteLine("Net salary is :" + o4.Calculatesalary() + Environment.NewLine);
           

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
        private static  int count=0;
        

        public Employee( string Name="default", decimal Basic=10000, short Dptno=1)
        {
            
            count++;
            this.empno = count;
            this.Name = Name;
            this.Basic = Basic;
            this.Dptno = Dptno;

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
                if (value >= 10000 && value <= 50000)
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
            Console.WriteLine("Employee number is "+empno);
            Console.WriteLine("Employee name is " + Name);
            Console.WriteLine("Employee salary is " + Basic);
            Console.WriteLine("Employee Department no  is " + Dptno);
            
        }
        public decimal Calculatesalary()
        {
            netsal = Basic * 12;
           return netsal; 
        }
    }

    class Employee1
    {
        private int empno;
        private string name;
        private decimal basic;
        private short dptno;
        private decimal netsal;
        


        public Employee1(int empno=100,string Name = "default", decimal Basic = 10000, short Dptno = 1)
        {

            
            this.empno = empno;
            this.Name = Name;
            this.Basic = Basic;
            this.Dptno = Dptno;

        }
        public int Empno
        {
            set
            {
                if (value >= 100)
                    empno = value;
                else
                    empno = -1;
            }
            get
            {
                return empno;
            }
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
                if (value >= 10000 && value <= 50000)
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

        //public int calcSal()
        //{
        //   decimal Basic = Basic + 1000m;
        //    return Basic;
        //}
        public decimal Calculatesalary()
        {
            netsal = Basic * 12;
            return netsal;
        }
    }
}
