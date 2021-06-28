using System;

namespace EmployeeWageComputation
{
    /// <summary>
    /// UC4: To Solve using Switch Case statement.
    /// </summary>
    class Program
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public const int EMPLOYEE_WAGE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            int empHours = 0;
            int empPerDayWage = 0;
            Random random = new Random();
            int employeeAttendance = random.Next(0, 3);
            switch(employeeAttendance)
            {
                case FULL_TIME:
                    Console.WriteLine("Employee is Present.");
                    empHours = 8;
                    break;
                case PART_TIME:
                    Console.WriteLine("Employee is Present for Part Time.");
                    empHours = 4;
                    break;
                default:
                    Console.WriteLine("Employee is Absent.");
                    break;
            }
            empPerDayWage = empHours * EMPLOYEE_WAGE_PER_HOUR;
            Console.WriteLine("Employee's per day wage is : " +empPerDayWage);


        }
    }
}
