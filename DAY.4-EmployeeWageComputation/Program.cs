/******************************************************************************
*  Compilation:  csc.exe /t:exe /out:Day03EmployeeWageCompuatation.exe Day03EmployeeWageCompuatation.cs
*  Execution:    Day04EmployeeWageCompuatation.exe 103
*  
*  Purpose: Calculation of employee wage using Class methods
*
*  @author  Ramya U
*  @version 1.0
*  @since   21-10-2020
*
******************************************************************************/

using System;
namespace EmployeeWageComputation
{
    class Program
    {
        //constants
        const int IS_PRESENT_PART_TIME = 1;
        const int IS_PRESENT_FULL_TIME = 2;
        const int IS_ABSENT = 0;
        const int EMP_RATE_PER_HOUR = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_WORKING_HOURS_IN_A_MONTH = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("total employee wage for a month " + ComputeEmpWage());
        }
        public static int ComputeEmpWage()
        {
            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;
            int totalWorkingDays = 0;
            int totalEmpHrs = 0;
            ///While loop is used to check maximum working hours and number of working days.
            ///if it is true then it allows.
            while (totalEmpHrs <= MAX_WORKING_HOURS_IN_A_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                ///Switch case is used to check wheather employee is working as for part time or full time
                ///according to that employee attendsance employee hours will be taken.
                switch (random.Next(1, 3))
                {
                    case IS_PRESENT_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_PRESENT_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_ABSENT:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day " + totalWorkingDays + " : " + "Emp Hr: " + empHrs);
                empWage = EMP_RATE_PER_HOUR * empHrs;
                totalEmpWage += empWage;
            }
            return totalEmpWage;
        }
    }
}