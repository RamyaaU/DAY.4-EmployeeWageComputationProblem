/******************************************************************************
 *  Compilation:  csc.exe /t:exe /out:Day04EmployeeWageCompuatation.exe Day04EmployeeWageCompuatation.cs
 *  Execution:    Day04EmployeeWageCompuatation.exe 103
 *  
 *  Purpose: Calculates Daily employee wage
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
            const int IS_FULL_TIME = 1;
            const int EMP_RATE_PER_HOUR = 20;
            //Variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Computation
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}