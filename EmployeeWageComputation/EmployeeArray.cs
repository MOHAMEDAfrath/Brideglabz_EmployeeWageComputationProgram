using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    class EmployeeArray
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public int noOfCompany = 0;
        public CompanyEmpWage[] companyEmpWages;
        public EmployeeArray()
        {
            this.companyEmpWages = new CompanyEmpWage[6];
        }
        public void addCompanyEmpWage(string companyName, int empRatePerHour, int noOfworkingDays, int maxHours)
        {
            companyEmpWages[this.noOfCompany] = new CompanyEmpWage(companyName, empRatePerHour, noOfworkingDays, maxHours);
            noOfCompany++;
        }
        public void computeEmpWage()
        {
            for(int i = 0; i < noOfCompany; i++)
            {
                companyEmpWages[i].setTotalEmpWage(this.computeEmpWage(this.companyEmpWages[i]));
                Console.WriteLine(this.companyEmpWages[i].toString());

            }
        }
        public int computeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int emphrs = 0, totEmpHrs = 0, totalworkingdays = 0;
            
            while (totalworkingdays <companyEmpWage.numofworkingdays && emphrs <= companyEmpWage.emprateperhour)
            {
                totalworkingdays++;
                Random random = new Random();
                int employeeAttendance = random.Next(0, 3);
                switch (employeeAttendance)
                {
                    case FULL_TIME:
                        emphrs = 8;
                        break;
                    case PART_TIME:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }

                totEmpHrs += emphrs;
                Console.WriteLine("Days:"+totalworkingdays+" emphrs:"+emphrs);
            }
            return totEmpHrs * companyEmpWage.emprateperhour;




        }
    }
}
