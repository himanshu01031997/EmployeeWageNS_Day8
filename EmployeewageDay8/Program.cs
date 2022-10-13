namespace EmployeewageDay8
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("welcome to employee wage computation");

            //Attendance attendance = new Attendance();
            //attendance.attend();

            //DailyEmpWages dailyEmpWages = new DailyEmpWages();
            //dailyEmpWages.Wages();

            //PartTimeEmp partTimeEmp = new PartTimeEmp();
            //partTimeEmp.Wages();

            //SwitchCase switchCase = new SwitchCase();
            //switchCase.Wages();

            //MonthlyWages monthlyWages = new MonthlyWages();
            //monthlyWages.wages();

            //Refactoring code = new Refactoring();
            //code.monthlywages();

            //MultipleCompany company1 = new MultipleCompany();
            //company1.wages("Dmart", 20, 14, 40);
            //MultipleCompany company2 = new MultipleCompany();
            //company2.wages("jio", 23, 13, 50);

            TotalWages total = new TotalWages("Dmart", 20, 15, 23);
            total.ComputeEmpWage();
            Console.WriteLine(total.toString());  
            //TotalWages total1 = new TotalWages("jio", 21, 25, 13);
            //total1.ComputeEmpWage();
            //Console.WriteLine(total1.ToString());




        }
    }
}