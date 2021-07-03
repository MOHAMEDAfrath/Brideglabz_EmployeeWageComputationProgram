using System;

namespace EmployeeWageComputation
{
    /// <summary>
    /// UC6: To calculate wage till a maximum working day of 20 or maximum working hour of 100 is reached
    /// UC7: static method is added 
    /// UC8: Multiple company wages are calculated using methods.
    /// UC9: Saved the wages with constructors and objects.
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            EmployeeArray employee = new EmployeeArray();
            employee.addCompanyEmpWage("Micromax", 20, 10, 100);
            employee.addCompanyEmpWage("Nokia", 20, 20, 100);
            employee.computeEmpWage();

        }
    }
}
