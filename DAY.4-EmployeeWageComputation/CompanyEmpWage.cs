using System;
using System.Collections.Generic;
using System.Text;

namespace DAY._4_EmployeeWageComputation
{
    public class CompanyEmpWage
    {
        //EmpWageBuilderobject has private data members 
             public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpWage;
            public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
            {
                // Used this to qualify the members of the class
                // instead of the constructor parameters.
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMonth;
            }
            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }
            public string toString()
            {
                return "Total Emp Wage for company: " + this.company + " is: " + this.totalEmpWage;
            }
        }
    }

