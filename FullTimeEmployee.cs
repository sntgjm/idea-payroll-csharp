using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sntgjm
namespace payroll_github
{
    internal class FullTimeEmployee
    {
        public double monthSalary;

        public void setMonthlySalary()
        {
            monthSalary = double.Parse(Console.ReadLine());    
        }
    }
}
