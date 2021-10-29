using System;

namespace Employee
{
    public class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;


        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;
        public EmpWageBuilderObject(String company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0, totalWorkDays = 0, totalEmpHrs = 0;
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkDays < this.numOfWorkingDays)
            {
                totalWorkDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 4);

                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkDays + " Emp Hrs : " + empHrs);
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            Console.WriteLine("Total Employee Wage for company:" + company + " is: " + totalEmpWage);
        }
        class Program
        {
            public static void Main(String[] args)
            {
                EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
                EmpWageBuilderObject Vguard = new EmpWageBuilderObject("Vguard", 10, 2, 10);
                EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliancet", 10, 4, 20);
                dMart.computeEmpWage();
                Console.WriteLine(dMart.ToString());
                Vguard.computeEmpWage();
                Console.WriteLine(Vguard.ToString());
                reliance.computeEmpWage();
                Console.WriteLine(reliance.ToString());

            }
        }

    }
}
