/******************************************************************************
*  Compilation:  csc.exe /t:exe /out:Day04EmployeeWageCompuatation.exe Day04EmployeeWageCompuatation.cs
*  Execution:    Day04EmployeeWageCompuatation.exe 103
*  
*  Purpose: Employee wage using switch case
*
*  @author  Ramya U
*  @version 1.0
*  @since   21-10-2020
*
******************************************************************************/

using System;

namespace Day03EmployeeWageComputation
{
    class Program
    {
        private static object getRandom;

        public static object EMP_WAGE_DETAILS { get; private set; }

        static void Main(string[] args)
        {
            //constants
            const int IS_FULL_TIME = 8;
            const int IS_PART_TIME = 4;
            int empHrs = 20;

            ///Switch case statements to check employee wages      
            switch (EmpCheck())
            {
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    empHrs = 0;
                    break;
            }
            Console.WriteLine("Employee wage is " + 20 * empHrs);
        }

        public static int EmpCheck()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}