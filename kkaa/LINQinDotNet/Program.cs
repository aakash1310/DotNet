using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQinDotNet
{
    class Program
    {
        static void Main1(string[] args)
        {
            AddRecords();

            var emps = from emp in lstemp select emp;

            foreach (var item in lstemp)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }

        static void Main1a(string[] args)
        {
            AddRecords();

            var emps = from emp in lstemp select emp;
            //deferred execution
            lstemp.RemoveAt(0);

            foreach (var item in lstemp)
            {
                Console.WriteLine(item.ToString());
            }

            lstemp.Reverse();
            foreach (var item in lstemp)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            AddRecords();

            // var emps = from emp in lstemp select emp;

            var emps = from emp in lstemp select emp.Basic;

            foreach (var item in lstemp)
            {
                Console.WriteLine(item.Basic.ToString());
            }
            Console.ReadLine();
        }
        static void Main3(string[] args)
        {
            AddRecords();

            var emps = from emp in lstemp select new { emp.Basic,emp.Name};

            foreach (var item in lstemp)
            {
                Console.WriteLine(item.Basic.ToString()+" "+item.Name.ToString());
            }
            Console.ReadLine();
        }

        static void Main4(string[] args)
        {
            AddRecords();

            //var emps = from emp in lstemp where emp.Basic > 100000 select emp;

            // var emps = from emp in lstemp where emp.Name.StartsWith("S") select emp;

            // var emps = from emp in lstemp where  emp.Gender=="M" select emp;

            var emps = from emp in lstemp where emp.Deptno > 1 select emp;

            foreach (var item in emps)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }

        static void Main5(string[] args)
        {
            AddRecords();

            //var emps = from emp in lstemp where (emp.Empno > 100 && emp.Basic > 100000) orderby emp.Name select emp;

            // var emps = from emp in lstemp orderby emp.Name ascending select emp;

            //var emps = from emp in lstemp orderby emp.Name descending select emp;
            var depts = from dept in lstdept
                      where (dept.DeptNo > 201 && dept.DeptName.StartsWith("M")) select dept;

            foreach (var item in depts)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }

        static void Main6(string[] args)
        {
            AddRecords();


            var emps = from dept in lstdept
                       join emp in lstemp on dept.DeptNo equals emp.Deptno
                       select new { emp.Name, dept.DeptNo };
                     

            foreach (var item in emps)
            {
                Console.WriteLine(item.Name + " "+ item.DeptNo);
            }
            Console.ReadLine();
        }


        static Employee GetEmployee(Employee e)
        {
            return e;
        }
        static string GetEmployee2(Employee e)
        {
            return e.Name;
        }
        static void Main7(string[] args)
        {
            AddRecords();

            //var emps = from emp in lstEmp select emp;
            var emps = lstemp.Select(GetEmployee);

            //var emps2 = from emp in lstEmp select emp.Name;
            var emps2 = lstemp.Select(GetEmployee2);

            foreach (var e in emps)
            {
                Console.WriteLine(e.ToString());
            }
            foreach (var e in emps2)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }

        static void Main8(string[] args)
        {
            AddRecords();

            //var emps = from emp in lstEmp select emp;
            //var emps = lstEmp.Select(GetEmployee);
            var emps = lstemp.Select(delegate (Employee e) { return e; });

            //var emps2 = from emp in lstEmp select emp.Name;
            //var emps2 = lstEmp.Select(GetEmployee2);
            var emps2 = lstemp.Select(delegate (Employee e) { return e.Name; });

            foreach (var e in emps2)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }

        static void Main9(string[] args)
        {
            AddRecords();

            //var emps = from emp in lstEmp select emp;
            //var emps = lstEmp.Select(GetEmployee);
            //var emps = lstemp.Select(delegate (Employee e) { return e; });
            var emps = lstemp.Select(e => e);

            //var emps2 = from emp in lstEmp select emp.Name;
            //var emps2 = lstEmp.Select(GetEmployee2);
            //var emps2 = lstemp.Select(delegate (Employee e) { return e.Name; });
            var emps2 = lstemp.Select(e => e.Name);
            var emps3 = lstemp.Select(e => new { e.Name, e.Basic });

            foreach (var e in emps3)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }

        static void Main10(string[] args)
        {
            AddRecords();
            var emps = lstemp.Where(e => e.Basic > 10000);

            var emps2 = lstemp.Where(e => (e.Basic > 100000 && e.Deptno > 200)).Select(e => new { e.Name, e.Deptno });

            foreach(var item in emps2)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }


        static void Main11(string[] args)
        {
            AddRecords();
            var emps = lstemp.OrderBy(e => e.Name).OrderByDescending(e => e.Deptno).Select(e => new { e.Name, e.Deptno });

            foreach (var item in emps)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }


        static void Main12(string[] args)
        {
            AddRecords();

            //var emps = from dept in lstdept
            //           join emp in lstemp on dept.DeptNo equals emp.Deptno
            //           select new { emp.Name, dept.DeptNo };


            var emps = lstemp.Join(lstdept, e => e.Deptno, d => d.DeptNo, (e, d) => new { e.Name, d.DeptName });

            foreach (var item in emps)
            {
                Console.WriteLine(item.Name + " " + item.DeptName);
            }
            Console.ReadLine();
        }

        static List<Employee> lstemp = new List<Employee>();
        static List<Department> lstdept = new List<Department>();

        static void AddRecords()
        {
            lstemp.Add(new Employee { Name = "kawaldeep", Empno = 101, Basic = 100203, Gender = "M", Deptno = 201 });
            lstemp.Add(new Employee { Name = "Aakash", Empno = 102, Basic = 100003, Gender = "M", Deptno = 201 });
            lstemp.Add(new Employee { Name = "Shivani", Empno = 103, Basic = 100103, Gender = "F", Deptno = 205 });
            lstemp.Add(new Employee { Name = "Pooja", Empno = 104, Basic = 1000104, Gender = "F", Deptno = 301 });
            lstemp.Add(new Employee { Name = "Abhishek", Empno = 105, Basic = 10001, Gender = "M", Deptno = 401 });
            lstemp.Add(new Employee { Name = "Aditya", Empno = 106, Basic = 100004, Gender = "M", Deptno = 204 });
            lstemp.Add(new Employee { Name = "Shraddha", Empno = 107, Basic = 10005, Gender = "F", Deptno = 203 });
            lstemp.Add(new Employee { Name = "Shreya", Empno = 108, Basic = 10006, Gender = "F", Deptno = 302 });

            lstdept.Add(new Department { DeptNo = 201, DeptName = "Sales" });
            lstdept.Add(new Department { DeptNo = 202, DeptName = "Marketing" });
            lstdept.Add(new Department { DeptNo = 203, DeptName = "Business" });
            lstdept.Add(new Department { DeptNo = 204, DeptName = "HR" });
        }
        public class Employee
        {
            public int Empno { set; get; }
            public string Name { set; get; }
            public decimal Basic { set; get; }
            public int Deptno { set; get; }
            public string Gender { set; get; }

            public override string ToString()
            {
                return Name + "  " + Empno + "  " + Basic + "  " + Deptno + "  " + Gender;
            }
        }
        
        public class Department
        {
            public int DeptNo { get; set; }
            public string DeptName { get; set; }
            public override string ToString()
            {
                return DeptName + " " + DeptNo;
            }
        }
    }
}
