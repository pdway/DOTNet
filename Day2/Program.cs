using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeclass
{
    class Program
    {
        static void Main(string[] args)
        {
            demo d1 = new demo("Amol", 123465, 10);
            Console.WriteLine();
            demo d2 = new demo("Amol", 123465);
            Console.WriteLine();
            demo d3 = new demo("Amol");
            Console.WriteLine();
            demo d4 = new demo();

            Console.WriteLine(d1.EMPNO);
            Console.WriteLine(d2.EMPNO);
            Console.WriteLine(d3.EMPNO);
           

            Console.WriteLine(d3.EMPNO);
            Console.WriteLine(d2.EMPNO);
            Console.WriteLine(d1.EMPNO);
           

            Console.ReadLine();
        }
    }

    public class demo {

       
        private int empNo;
        private string empName;
        private decimal basic;
        private short deptNo;
       

       
        public static int lastempNo = 1;
       

       
       
        public demo(string EMPNAME = null, decimal BASIC = 0, short DEPTNO = 0)
        {
            this.EMPNAME = EMPNAME;
            this.BASIC = BASIC;
            this.DEPTNO = DEPTNO;
            
            empNo = lastempNo++;
        }
       
        public int EMPNO
        {
            get
            {
                return empNo;
            }
        }

        public string EMPNAME
        {
            set
            {
                if (value != null)
                    empName = value;
                else
                    Console.WriteLine("Has to put name!");
            }

            get
            {
                return empName;
            }
        }

        public decimal BASIC
        {
            set
            {
                if (value > 25000)
                    basic = value;
                else
                    Console.WriteLine("Invalid Basic Salary !!!");
            }

            get
            {
                return basic;
            }
        }
        public short DEPTNO
        {
            set
            {
                if (value > 0)
                    deptNo = value;
                else
                    Console.WriteLine("put valid deptNo !");
            }

            get
            {
                return deptNo;
            }

        }
       

        
        public decimal GetNetSalary()
        {
            decimal sal = 0;
            sal = sal + 5000;
            return sal;
        }
        
        public void Display()
        {
            Console.WriteLine(empNo + " " + empName + " " + deptNo + " " + (basic + GetNetSalary()));
        }


    }
}
