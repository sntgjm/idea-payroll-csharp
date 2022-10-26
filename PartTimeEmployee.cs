using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sntgjm
namespace payroll_github
{
    internal class PartTimeEmployee
    {
        public double ratePerHour;
        public int ratePerWorked;

        public void setRatePerHour() {

            ratePerHour = double.Parse(Console.ReadLine());

        }

        public void setRatePerWorked() {

            ratePerWorked = int.Parse(Console.ReadLine());

        }
    }
}
