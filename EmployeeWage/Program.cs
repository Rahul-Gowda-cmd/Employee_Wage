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
            int dailyWage;
            int PartTimeHours = 4;
            int noofHoursWorked = 0;
            int daysWorked = 0;
            int monthlyWage = 0;
            Random rm = new Random();
            while (noofHoursWorked <= 100 && daysWorked <=20)
            {
                dailyWage = 0;
                int workStatus = rm.Next(0, 3);

                switch (workStatus)
                {
                    case 0:
                        Console.WriteLine("Employee is absent");
                        break;
                    case 1:
                        Console.WriteLine("Employee is present");
                        dailyWage = perHourWage * HoursWorked;
                        noofHoursWorked += HoursWorked;
                        daysWorked++;
                        break;
                    case 2:
                        Console.WriteLine("Employee has worked partTime");
                        dailyWage = perHourWage * PartTimeHours;
                        noofHoursWorked += PartTimeHours;
                        daysWorked++;
                        break;
                    default:
                        Console.WriteLine("Something Wrong Appeared");
                        break;
                }
                Console.WriteLine("Daily Wage of Employee:" + dailyWage);
                monthlyWage += dailyWage;
            }
            Console.WriteLine("Days Worked"+daysWorked);
            Console.WriteLine("MonthlyWage" + monthlyWage);
        }
    }
}
