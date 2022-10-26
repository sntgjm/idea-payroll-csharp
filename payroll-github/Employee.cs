using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
//sntgjm
namespace payroll_github
{
    internal class Employee
    {
        FullTimeEmployee fullT = new FullTimeEmployee();
        PartTimeEmployee partT = new PartTimeEmployee();
        string gettingName;
        string titleJob;


        void payrollProgram()
        {

            Console.WriteLine("Welcome to Payroll Program");
            Console.WriteLine("Enter name: ");
            gettingName = Console.ReadLine();

            Console.Write("Press 'F' for Full Time or 'P' for Part Time: ");
            titleJob = Console.ReadLine();

            if (titleJob.Equals("F") || titleJob.Equals("f")) {

                Console.WriteLine();
                Console.WriteLine("You are on Full Time Payroll Page");
                Console.Write("Input your Monthly Salary: ");
                fullT.setMonthlySalary();
                Console.WriteLine();
                Console.WriteLine("This is your Payroll");

                Console.WriteLine("Name: " + gettingName);
                Console.WriteLine("Salary: " + fullT.monthSalary);

            } 
            else if (titleJob.Equals("P") || titleJob.Equals("p")) {

                Console.WriteLine();
                Console.WriteLine("You are on Part Time Payroll Page");
                Console.WriteLine("Input your Rate Per Hour: ");
                partT.setRatePerHour();
                Console.WriteLine("Input your Rate Per Worked: ");
                partT.setRatePerWorked();

                double calculate = partT.ratePerHour * partT.ratePerWorked;
                double roundoff = Math.Round(calculate * 1000.0) / 1000.0;
                Console.WriteLine();
                Console.WriteLine("This is your Payroll");

                Console.WriteLine("Name: " + gettingName);
                Console.WriteLine("Salary: " + roundoff);

            }
            else { 

                Console.WriteLine("Invalid Selection");

            }
        }


        public static void Main(string[] args)
        {
            Employee employee = new Employee();

            employee.payrollProgram();
        }
    }
}
