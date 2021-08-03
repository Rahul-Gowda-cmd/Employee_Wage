using System;

namespace EmployeeWage
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program");
            int perHourWage = 1000;
            int HoursWorked = 8;
            int dailyWage = 0;
            int PartTimeHours = 4;
            Random rm = new Random();
            int present = rm.Next(0, 3);

            if (present == 1)
            {
                Console.WriteLine("Employee is present");
                dailyWage = perHourWage * HoursWorked;
            }
            else if (present == 2)
            {
                Console.WriteLine("Employee is absent");
                dailyWage = perHourWage * PartTimeHours;
            }
            Console.WriteLine("Daily Wage of Employee:" + dailyWage);
        }
    }
}
