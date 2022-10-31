using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeewageDay8
{
    public  class EmployeeWageBuildArray
    {
        public const int ISPARTTIME = 1;
        public const int ISFULLTIME = 2;
        private int NoOFCompany = 0;
        private CompanyEmpWage[] companyEmpwageArray=new CompanyEmpWage[0];

        public EmployeeWageBuildArray()
        {
            this.companyEmpwageArray = new CompanyEmpWage[5];
        }
        public void AddCompany(string company,int EmpRateprhr, int NumWorkingDay, int MaxHrPrMonth)
        {
            companyEmpwageArray[this.NoOFCompany] = new CompanyEmpWage(company, EmpRateprhr, NumWorkingDay, MaxHrPrMonth);
            NoOFCompany++;
        }
        public void ComputeEmpWage()
        {
            for(int i = 0; i < NoOFCompany; i++)
            {
                companyEmpwageArray[i].TotalEmpWage(this.ComputeEmpWage(this.companyEmpwageArray[i]));
                Console.WriteLine(this.companyEmpwageArray[i].tostring());
            }

        }
        private int ComputeEmpWage(CompanyEmpWage companyempwage)
        {
            int emphr = 0, totalempHR = 0, totalworkingday = 0;
            while (totalempHR <= companyempwage.MaxHrPrMonth && totalworkingday < companyempwage.NumWorkingDay) 
            {
                totalworkingday++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
                {
                    case ISFULLTIME:
                        emphr = 8;
                        break;
                    case ISPARTTIME:
                        emphr = 4;
                        break;  
                    default:
                        emphr = 0;  
                        break;
                        
                }
                totalempHR+=emphr;
                Console.WriteLine("days: "+totalworkingday+"emphrs:"+emphr);
            }
            return totalempHR * companyempwage.EmpRateprhr;

        }
    }
}
