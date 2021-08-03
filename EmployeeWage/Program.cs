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
            int workStatus = rm.Next(0, 3);

            switch(workStatus)
            {
                case 0:
                    Console.WriteLine("Employee is absent");
                    break;
                case 1:
                    Console.WriteLine("Employee is present");
                    dailyWage = perHourWage * HoursWorked;
           
                    break;
                case 2:
                    Console.WriteLine("Employee has worked partTime");
                    dailyWage = perHourWage * PartTimeHours;
              
                    break;
                default:
                    Console.WriteLine("Something Wrong Appeared");
                    break;
            }
            Console.WriteLine("Daily Wage of Employee:" + dailyWage);
        }
    }
}
