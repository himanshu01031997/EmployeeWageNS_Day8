using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageDay8
{
    public interface IcomputeEmpwage
    {
        public void AddCompany(string company, int empRatePerHour, int numOfWorkingDays, int maxHourPerMonth);
        public void computeEmpWage();
        public int getTotalEmpWage(int value);

    }
    public class CompanyEmpWage
    {
        public string company;
        public int EmpRateprhr;
        public int NumWorkingDay;
        public int MaxHrPrMonth;
        public int totalEmpWage;
        public CompanyEmpWage(string company, int EmpRateprhr, int NumWorkingDay, int MaxHrPrMonth)
        {
            this.company = company;
            this.EmpRateprhr = EmpRateprhr;
            this.NumWorkingDay = NumWorkingDay;
            this.MaxHrPrMonth = MaxHrPrMonth;
        }
        public void TotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }
        public string tostring()
        {
            return "total empwage for the company" + this.company + " is :" + this.totalEmpWage;
        }
       
    }
}
