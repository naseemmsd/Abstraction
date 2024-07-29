using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay; // 25000---house rent,----5000,, covence allowance ---4000
        private const double TaxDeduction = 0.1; // 10%
        double netSalary;
        public Employee(int empId, string empName, double grossPay)
        {
            EmpId = empId;
            EmpName = empName;
            GrossPay = grossPay;
        }


        void CalculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("your Salary is:{0}", GrossPay);
            }
            else
            {
                Console.WriteLine("your Salary is:{0}", GrossPay);
            }

        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Id is:{0}", this.EmpId);
            Console.WriteLine("Employee Name is:{0}", this.EmpName);
            this.CalculateSalary();
        }

        static void Main(string[] args)
            {
             Employee Ali = new Employee(867,"Ali Khan",70000);
             Ali.ShowEmployeeDetails();
             Console.ReadLine();

            }
        
    }
}