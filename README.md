using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage72
{
    
    class Computation
    { 
        
        public const int IS_FullTime = 1;
        public const int EMP_RET_PR_HR = 50;

        static void Main(string[] args)
        {
            
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();

            
            int empInput = random.Next(0, 2);
            
            if (IS_FullTime == empInput)
            {
                Console.WriteLine("Employee is prsent");
                
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is absent ");
                empHrs = 0;
            }
            empWage = EMP_RET_PR_HR * empHrs;
               Console.WriteLine("Employee Wage {0}" , empWage);
               Console.ReadLine();
        }
    }
}
