using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kaps7_Collectionsss_
{
    class Program
    {
        static void Main()
        {
            List<Employee> list = new List<Employee>();
            try
            {
                list.Add(new Employee { Empno = 1, Name = "kawaldeep", Basic = 75000, Dptno = 1 });
                list.Add(new Employee { Empno = 2, Name = "aakash", Basic = 45000, Dptno = 2 });
                list.Add(new Employee { Empno = 3, Name = "shivani", Basic = 55000, Dptno = 3 });
                list.Add(new Employee { Empno = 4, Name = "pooja", Basic = 500000, Dptno = 4 });
                list.Add(new Employee { Empno = 5, Name = "tanmay", Basic = 45000, Dptno = 2 });
            }
            catch(MyException e )
            {
                Console.WriteLine(e.Message);
            }

            foreach (Employee e in list)
            {
                Console.WriteLine(e.Empno + " " + e.Name + " " + e.Basic + " " + e.Dptno);
            }
            
            decimal max = decimal.MinValue;
            int ind = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Basic > max)
                {
                    max = list[i].Basic;
                    ind = i;
                }
            }
            Console.WriteLine("the employee with highest salary is: " + list[ind].Name);
            Console.WriteLine("enter the empno to be searched:");
            int empno = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].Empno == empno)
                {
                    Console.WriteLine("the employee is: " + list[i].Name);

                    break;
                }
            }
            Console.ReadLine();
        }

    }
    public class Employee
    {
        private int empno;
        private decimal basic;
        private string name;
        private int dptno;
        
        public int Empno
        {
            set
            {
                if (value > 0)
                    empno = value;
                else
                    throw new MyException("value less then 0");
            }
            get
            {
                return empno;
            }
        }
        public decimal Basic
        {
            get
            {
                return basic;
            }
            set
            {
                if (value > 1000)
                    basic = value;
                else
                    throw new MyException("Invalid basic salary");
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                    name = value;
                else
                {
                    throw new MyException("Please enter valid name");
                }
            }
        }

        public int Dptno
        {
            get
            {
                return dptno;
            }
            set
            {
                if (value > 0)
                    dptno = value;
                else
                {
                    throw new MyException("Department not found");
                }
            }
        }
    }

    public class MyException : ApplicationException
    {
        public MyException(String s) : base(s)
        {

        }
    }
}
