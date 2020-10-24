﻿using System;

namespace DAY._4_EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dmart = new EmpWageBuilderObject("Dmart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}
