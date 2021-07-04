using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    public class EmployeeArray: ICompanyEmpWage
    {
        public const int FULL_TIME = 1;
        public const int PART_TIME = 2;
        public int noOfCompany = 0;
        private LinkedList<CompanyEmpWage> companyEmpList;
        private Dictionary<string, CompanyEmpWage> companyandempwage;

        internal LinkedList<CompanyEmpWage> CompanyEmpList { get => companyEmpList; set => companyEmpList = value; }

        public EmployeeArray()
        {
            this.CompanyEmpList = new LinkedList<CompanyEmpWage>();
            this.companyandempwage = new Dictionary<string, CompanyEmpWage>();
        }
        public void addCompanyEmpWage(string companyName, int empRatePerHour, int noOfworkingDays, int maxHours)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(companyName, empRatePerHour, noOfworkingDays, maxHours);
            this.CompanyEmpList.AddLast(companyEmpWage);
            this.companyandempwage.Add(companyName, companyEmpWage);
        }
        public void computeEmpWage()
        {
            foreach(CompanyEmpWage company in this.CompanyEmpList)
            {
                company.setTotalEmpWage(this.computeEmpWage(company));
                Console.WriteLine(company.toString());
            }
            
        }
        private int computeEmpWage(CompanyEmpWage companyEmpWage)
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

       

        public int getTotaWage(string company)
        {
            return this.companyandempwage[company].totalempwage;
        }
    }
}
