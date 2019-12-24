using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager(111,"kk",101010,11);

            Clerk c = new Clerk(12, "aa", 10101, 121);

            GeneralManager g = new GeneralManager("paid vacation", 121, "ss", 102010, 111);

            Console.ReadLine();
        }
    }
    public interface IDBFunctions
    {
        void Insert();
        void Update();
        void Delete();
    }
    public abstract class  Employee : IDBFunctions
    {
        public int empno;
        public string name;
        public decimal basic;
        public short dptno;
        public static int count = 0;

        public Employee(string Name = "default", decimal Basic = 10000, short Dptno = 1)
        {

            count++;
            this.empno = count;
            this.Name = Name;
            this.Basic = Basic;
            this.Dptno = Dptno;

        }

        public abstract decimal CalcNetSalary();
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

        public abstract decimal Basic
        {
            set;
           
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
            Console.WriteLine("Employee basicsalary is " + basic);
            Console.WriteLine("Employee Department no  is " + Dptno);
            //Console.WriteLine("Employee netsalary is " + sal);
        }

        void IDBFunctions.Insert()
        {
            Console.WriteLine("this is insert ");
        }

        void IDBFunctions.Update()
        {
            Console.WriteLine("this is update");
        }

        void IDBFunctions.Delete()
        {
            Console.WriteLine("this is delete");
        }
    }

    public class Manager : Employee,IDBFunctions
    {
        private int ProjectId;
        public int PROJECTID
        {
            set
            {
                if (value > 0)
                    ProjectId = value;
            }
            get
            {
                return ProjectId;
            }
        }

        public Manager(int PROJECTID, string Name ="default",decimal Basic=10000, short Dptno=1):base(Name,Basic,Dptno)
        {
            this.PROJECTID = PROJECTID;
            Console.WriteLine("Employee project id is :"+PROJECTID);
            this.display();
           
            
        }
        

       
        public override decimal Basic
        {
            set
            {
                    if (value > 10000)
                        basic = value;
            }
        }

        public override decimal CalcNetSalary()
        {
            Console.WriteLine("Manager Salaray: " + (basic * 10));
            return 0m;
        }
    }

    public class Clerk : Employee,IDBFunctions
    {

        public Clerk(int OVERTIMEHOURS, string Name = "default", decimal Basic = 10000, short Dptno = 1) : base(Name, Basic, Dptno)
        {
            this.OVERTIMEHOURS = OVERTIMEHOURS;
            this.display();
            Console.WriteLine("Clerk Overtime is :" + this.OVERTIMEHOURS);

        }
        private int OverTimeHours;

        public int OVERTIMEHOURS
        {
            set
            {
                if (value > 0)
                    OverTimeHours = value;
            }
            get
            {
                return OverTimeHours;
            }
        }

        public override decimal Basic
        {
            set
            {
                if (value > 1000)
                    basic = value;
            }

        }

        public override decimal CalcNetSalary()
        {
            Console.WriteLine("Clerk salary is: " + (basic * 5)) ;
            return 0;
        }
    }

    public class GeneralManager : Manager,IDBFunctions
    {
        String Perks;
        public GeneralManager(string perks,int PROJECTID, string Name = "default", decimal Basic = 10000, short Dptno = 1) : base (PROJECTID,Name,Basic,Dptno)
        {
            this.Perks = perks;
            this.display();
            Console.WriteLine("General manager Perks is :" + this.Perks);

        }

        public override decimal CalcNetSalary()
        {
            Console.WriteLine("GeneralManager Salary is : "+ (basic * 15));
            return 0;
                
        }
    }
}
