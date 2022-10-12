using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageDay8
{
    public class DailyEmpWages
    {
        public  int ispresent = 1;
        public  int WAGE_PER_HR = 20;
        public  int FULL_TIME = 1;
        public  void Wages()
        {
            int emphr = 0;
            int Empwage = 0;

            Console.WriteLine("Daily wages of employee");
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == FULL_TIME)
            {
                Console.WriteLine("employee is fulltime");
                emphr = 8;

            }
            else
            {
                Console.WriteLine("employee is parttime");
                emphr = 4;

            }
            Empwage = emphr * WAGE_PER_HR;
            Console.WriteLine("Daily wage of employee is {0}", Empwage);
        }
    }
}
