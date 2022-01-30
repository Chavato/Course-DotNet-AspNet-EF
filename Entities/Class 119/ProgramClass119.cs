// using System;
// using System.Collections.Generic;
// using System.Globalization;
// using BasicClasses;
// using Entities.Class119;
// using Entities.Enums.Class119;

// namespace Course_DotNet_AspNet_EF
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             System.Console.WriteLine("Enter department's name: ");
//             string deptName = Console.ReadLine();

//             System.Console.WriteLine("Enter worker data: ");
//             System.Console.Write("Name: ");
//             string name = Console.ReadLine();

//             System.Console.Write("Level (Junior/MidLevel/Senior): ");
//             WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

//             System.Console.WriteLine("Base salary: ");
//             double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//             Department dept = new Department(deptName);

//             Worker worker = new Worker(name, level, baseSalary, dept);

//             System.Console.WriteLine("How many contract to this worker?");
//             int n = int.Parse(Console.ReadLine());

//             for (int i = 1; i <= n; i++)
//             {
//                 System.Console.WriteLine("Enter with the information of {0} contract", i);

//                 System.Console.WriteLine("Date (DD/MM/YYYY): ");
//                 DateTime date = DateTime.Parse(Console.ReadLine());

//                 System.Console.WriteLine("Value per hour");
//                 double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//                 System.Console.WriteLine("Duration (hours): ");
//                 int hours = int.Parse(Console.ReadLine());

//                 HourContract contract = new HourContract(date, valuePerHour, hours);

//                 worker.AddContract(contract);
//             }

//             System.Console.WriteLine();
//             System.Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
//             string monthAndYear = Console.ReadLine();

//             int month = int.Parse(monthAndYear.Substring(0, 2));
//             int year = int.Parse(monthAndYear.Substring(3));

//             System.Console.WriteLine("Name: " + worker.Name);
//             System.Console.WriteLine("Department: " + worker.Department.Name);
//             System.Console.WriteLine("Income for " + monthAndYear + ":" + worker.Income(month, year).ToString(CultureInfo.InvariantCulture));



//         }
//     }
// }
