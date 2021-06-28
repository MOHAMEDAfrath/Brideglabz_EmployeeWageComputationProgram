using System;

namespace EmployeeWageComputation
{
    /// <summary>
    /// UC1: To check whether employee is present or absent using random class
    /// </summary>
    class Program
    {
        public const int FULL_TIME = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            Random random = new Random();
            int employeeAttendance = random.Next(0, 2);
            if(employeeAttendance == FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }

        }
    }
}
