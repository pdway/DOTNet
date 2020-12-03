using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanceassig
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager gm1 = new Manager("manager",111,22000,"man");
            Console.WriteLine(gm1.EMPNO + " " + gm1.EMPNAME + " " + gm1.DEPTNO + " " + gm1.Basic + " " + gm1.Designation + " " + gm1.Getnetsalary());

           GeneralManager gm = new GeneralManager("g.manager", 112, 52000,"gman","ALL");
            Console.WriteLine(gm.EMPNO + " " + gm.EMPNAME + " " + gm.DEPTNO + " " + gm.Designation + " " + gm.Basic + " " + gm.Perks + " " + gm.Getnetsalary());

            CEO gm2 = new CEO("ceo", 111, 122000);
            Console.WriteLine(gm2.EMPNO + " " + gm2.EMPNAME + " " + gm2.DEPTNO + " " + gm2.Basic + " " + gm2.Getnetsalary());

            Console.ReadLine();

        }


        public abstract class employee {
            private int empNo;
            private string empName;
            protected decimal basic;
            private short deptNo;
            private static int lastempNo = 1;
            public employee(string EMPNAME = null, short DEPTNO = 0, decimal Basic = 0)
            {
                this.EMPNAME = EMPNAME;
                this.DEPTNO = DEPTNO;
                this.Basic = Basic;
                EMPNO = lastempNo++;


            }
            public int EMPNO
            {
                private set {
                    empNo = value;
                }
                get {
                    return empNo;
                }
            }

            public string EMPNAME
            {
                set {
                    if (value != null)
                        empName = value;
                    else
                        Console.WriteLine("has to put name");
                }
                get {
                    return empName;
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
            public abstract decimal Basic{
                set;
                get;
            }

            public abstract decimal Getnetsalary();





        }
        public class Manager : employee {
            private string designation;
            public Manager(string EMPNAME = "null", short DEPTNO = 0, decimal Basic = 0, string Designation="null"):base(EMPNAME,DEPTNO,Basic)
            {
                this.Designation = Designation;
            }

            public string Designation {
                set {
                    if (value != null)
                        designation = value;
                    else
                        Console.WriteLine("invalid designation");
                
                }

                get {
                    return designation;
                }
            
            }

            public override decimal Basic {
                get {
                    return basic;
                }
                set {
                    if (value > 20000)
                        basic = value;
                    else
                        Console.WriteLine(  "Invalid salary");
                }
            }

            public override decimal Getnetsalary()
            {
                decimal salary;
                salary = Basic + 3000;
                return salary;

            }
        }

        public class GeneralManager : Manager {
            private string perks;
            public string Perks
            {
                set { perks = value; }
                get { return perks; }
            }

            public GeneralManager(string EMPNAME = null, short DEPTNO = 0, decimal Basic = 0, string Destination = null,string Perks=null):base(EMPNAME, DEPTNO, Basic,Destination)
            {
                this.Perks = Perks;
            }

            public override decimal Basic
            {
                get
                {
                    return basic;
                }
                set
                {
                    if (value > 50000)
                        basic = value;
                    else
                        Console.WriteLine("Invalid salary");
                }
            }

            public override decimal Getnetsalary()
            {
                decimal salary;
                salary = Basic + 5000;
                return salary;

            }

        }

        public class CEO : employee {

            public CEO(string EMPNAME = null, short DEPTNO = 0, decimal Basic = 0):base(EMPNAME,DEPTNO,Basic)
            {
                this.Basic = Basic;
            }

            public override decimal Basic {
                get
                {
                    return basic;
                }
                set
                {
                    if (value > 100000)
                        basic = value;
                    else
                        Console.WriteLine("Invalid salary");
                }

            }

            public override decimal Getnetsalary()
            {
                decimal salary;
                salary = Basic + 10000;
                return salary;
            }
        }

       
    }
}
