using System;

namespace Employee
{
    class Program
    {
        //public const int EmpRatePerHrs= 20;

        // public const int Num_Of_Working_Days = 20;
        //public const int WorkingHrs = 60;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!\n");
            EmpWageCompute emp = new EmpWageCompute();

            emp.addCompanyEmpWage("DMart", 20, 20, 60);
            emp.addCompanyEmpWage("Reliance", 20, 15, 30);
            emp.addCompanyEmpWage("Machine", 10, 35, 60);
            emp.addCompanyEmpWage("Kraft", 30, 20, 40);
            emp.addCompanyEmpWage("Sole", 10, 25, 40);
            emp.ComputeEmpWage();

            
            Console.WriteLine("total wage for DMart comany is    :" + emp.getTotalWage("DMart"));
            Console.WriteLine("total wage for Reliance comany is :" + emp.getTotalWage("Reliance"));
            Console.WriteLine("total wage for Machine comany is  :" + emp.getTotalWage("Machine"));
            Console.WriteLine("total wage for Kraft comany is    :" + emp.getTotalWage("Kraft"));
            Console.WriteLine("total wage for Sole comany is     :" + emp.getTotalWage("Sole"));
            //emp.getTotalWage("DMart");


        // public const int Num_Of_Working_Days = 20;
        //public const int WorkingHrs = 60;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!\n");
            EmpWageCompute emp = new EmpWageCompute();

            emp.addCompanyEmpWage("DMart", 20, 20, 60);
            emp.addCompanyEmpWage("Reliance", 20, 15, 30);
            emp.addCompanyEmpWage("VMware", 10, 20, 30);
            emp.addCompanyEmpWage("Rolex", 15, 10, 60);
            emp.ComputeEmpWage();

        }

    }
}
