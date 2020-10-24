/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day04EmployeeWageCompuatation.exe Day04EmployeeWageCompuatation.cs
 *  Execution:    Day04EmployeeWageCompuatation.exe 103
 *  
 *  Purpose: Wages for a month
 *
 *  @author  Ramya U
 *  @version 1.0
 *  @since   22-10-2020
 *
 ******************************************************************************/

using System;

namespace Day04EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to EmployeeWageComputation!");
            //constants
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PER_HOUR = 20;
            const int IS_PART_TIME = 1;
            const int NUM_OF_WORKING_DAYS = 2;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            //Computation
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 2);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EMP_RATE_PER_HOUR;
                totalEmpWage += empWage;
                Console.WriteLine("Emp Wage : " + empWage);
            }
        }
    }
}