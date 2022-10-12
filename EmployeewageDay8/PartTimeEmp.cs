using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageDay8
{
    public class PartTimeEmp
    {
        public const int WAGE_PER_HR = 20;
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int ABSENT = 0;
        public  void Wages()
        {
            int emphr = 0;
            int Empwage = 0;

            Console.WriteLine("Daily wages of employee");
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == FULL_TIME)
            {
                Console.WriteLine("employee is fulltime");
                emphr = 10;

            }
            else if (empcheck == PART_TIME)
            {
                Console.WriteLine("employee is parttime");
                emphr = 8;

            }
            else
            {
                Console.WriteLine("employee is absent");
                emphr = 0;
            }
            Empwage = emphr * WAGE_PER_HR;
            Console.WriteLine("Daily wage of employee is {0}", Empwage);
        }
    }
}
