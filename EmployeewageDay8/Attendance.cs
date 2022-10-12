using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageDay8
{
    public class Attendance
    {
        public  int ispresent = 1;
        public  void attend()
        {
            Console.WriteLine("Attendance of employee");
            Random random = new Random();
            int empcheck = random.Next(0, 2);
            if (empcheck == 1)
            {
                Console.WriteLine("employee is present");
            }
            else
            {
                Console.WriteLine("employee is absent");
            }
        }
    }
}
