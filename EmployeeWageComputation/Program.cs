using System;

namespace EmployeeWageComputation
{
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
            if(employeeAttendance == FULL_TIME)
            {
                Console.WriteLine("Employee is Present.");
                empHours = 8;
            }
            else if(employeeAttendance == PART_TIME)
            {
                Console.WriteLine("Employee is Present for Part Time.");
                empHours = 4;

            }
            else
            {
                Console.WriteLine("Employee is Absent.");
            }
            empPerDayWage = empHours * EMPLOYEE_WAGE_PER_HOUR;
            Console.WriteLine("Employee's per day wage is : " +empPerDayWage);


        }
    }
}
