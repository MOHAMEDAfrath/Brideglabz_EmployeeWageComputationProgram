using System;

namespace EmployeeWageComputation
{
    /// <summary>
    /// UC6: To calculate wage till a maximum working day of 20 or maximum working hour of 100 is reached
    /// UC7: static method is added 
    /// UC8: Multiple company wages are calculated using methods.
    /// </summary>
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public static void ComputeWage(string companyName,int empRatePerHour, int noOfworkingDays,int maxHours )
        {
            int empHours = 0;
            int empTotalWorkingday = 1;
            int empTotalWorkingHour = 0;
            int empPerDayWage = 0;
            int empTotalWage = 0;
            Random random = new Random();
            while (empTotalWorkingday < noOfworkingDays && empTotalWorkingHour <= maxHours)
            {
                int employeeAttendance = random.Next(0, 3);
                switch (employeeAttendance)
                {
                    case FULL_TIME:
                        empHours = 8;
                        break;
                    case PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }
                empPerDayWage = empHours * empRatePerHour;
                empTotalWage += empPerDayWage;
                if (employeeAttendance > 0)
                {
                    empTotalWorkingday += 1;
                }
                empTotalWorkingHour += empHours;
            }
            Console.WriteLine("Employee's wage for Working in "+companyName+" for days : " + empTotalWorkingday + " and Working Hour : " + empTotalWorkingHour + " is " + empTotalWage);




        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            ComputeWage("Honda",20,40,100);
            ComputeWage("Micromax", 10, 40, 200);

        }
    }
}
