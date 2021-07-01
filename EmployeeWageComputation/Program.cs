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
        private string companyname;
        private int TOTAL_WORKING_DAY;
        private int EMPLOYEE_WAGE_PER_HOUR;
        private int EMPLOYEE_TOTAL_WORKING_HOUR;

        public Program(string companyName, int empRatePerHour, int noOfworkingDays, int maxHours)
        {
            this.companyname = companyName;
            this.TOTAL_WORKING_DAY = noOfworkingDays;
            this.EMPLOYEE_WAGE_PER_HOUR = empRatePerHour;
            this.EMPLOYEE_TOTAL_WORKING_HOUR = maxHours;

        }
        public void ComputeWage()
        {
            int empHours = 0;
            int empTotalWorkingday = 1;
            int empTotalWorkingHour = 0;
            int empPerDayWage = 0;
            int empTotalWage = 0;
            Random random = new Random();
            while (empTotalWorkingday < this.TOTAL_WORKING_DAY && empTotalWorkingHour <= this.EMPLOYEE_TOTAL_WORKING_HOUR)
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
                empPerDayWage = empHours * this.EMPLOYEE_WAGE_PER_HOUR;
                empTotalWage += empPerDayWage;
                if (employeeAttendance > 0)
                {
                    empTotalWorkingday += 1;
                }
                empTotalWorkingHour += empHours;
            }
            Console.WriteLine("Employee's wage for Working in "+this.companyname+" for days : " + empTotalWorkingday + " and Working Hour : " + empTotalWorkingHour + " is " + empTotalWage);




        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            Program program = new Program("Honda", 20, 10, 100);
            Program program1 = new Program("Micromax", 20, 25, 200);
            program.ComputeWage();
            program1.ComputeWage();

        }
    }
}
