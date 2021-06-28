using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int TOTAL_WORKING_DAY = 20;
        public const int EMPLOYEE_WAGE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            int empHours = 0;
            int empAbsentDays = 0;
            int empFullTimeDays = 0;
            int empPartTimeDays = 0;
            int empPerDayWage = 0;
            int empTotalWage = 0; 
            Random random = new Random();
            for (int workingday = 1; workingday <= TOTAL_WORKING_DAY; workingday++)
            {
                int employeeAttendance = random.Next(0, 3);
                switch (employeeAttendance)
                {
                    case FULL_TIME:
                        empHours = 8;
                        empFullTimeDays += 1;
                        break;
                    case PART_TIME:
                        empHours = 4;
                        empPartTimeDays += 1;
                        break;
                    default:
                        empAbsentDays += 1;
                        empHours = 0;
                        break;
                }
                empPerDayWage = empHours * EMPLOYEE_WAGE_PER_HOUR;
                empTotalWage += empPerDayWage;
            }
            Console.WriteLine("Employee was absent for: "+empAbsentDays+ " days.");
            Console.WriteLine("Employee was present full time for: " +empFullTimeDays+" days.");
            Console.WriteLine("Employee was present Part time for: " + empPartTimeDays + " days.");
            Console.WriteLine("Employee's wage for " + (TOTAL_WORKING_DAY - empAbsentDays) + "/20 days is "+empTotalWage);
            

        }
    }
}
