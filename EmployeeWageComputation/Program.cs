using System;

namespace EmployeeWageComputation
{
    /// <summary>
    /// UC6: To calculate wage till a maximum working day of 20 or maximum working hour of 100 is reached
    /// </summary>
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int TOTAL_WORKING_DAY = 20;
        public const int EMPLOYEE_WAGE_PER_HOUR = 20;
        public const int EMPLOYEE_TOTAL_WORKING_HOUR = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            int empHours = 0;
            int empTotalWorkingday = 1;
            int empTotalWorkingHour = 0;
            int empPerDayWage = 0;
            int empTotalWage = 0; 
            Random random = new Random();
            while(empTotalWorkingday <= TOTAL_WORKING_DAY && empTotalWorkingHour <= EMPLOYEE_TOTAL_WORKING_HOUR )
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
                empPerDayWage = empHours * EMPLOYEE_WAGE_PER_HOUR;
                empTotalWage += empPerDayWage;
                if (employeeAttendance > 0)
                {
                    empTotalWorkingday += 1;
                }
                empTotalWorkingHour += empHours;
            }
            Console.WriteLine("Employee's wage for Working Hour : " +empTotalWorkingday+ " and Working Hour : "+empTotalWorkingHour+ " is "+empTotalWage);
            
            

        }
    }
}
