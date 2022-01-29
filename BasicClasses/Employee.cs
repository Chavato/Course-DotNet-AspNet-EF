using System;

namespace BasicClasses
{
    class Employee
    {

        public int Id { get; private set; }
        public string Name { get; set; }
        public double GrossSalary { get; private set; }
        private double Tax = 0.1;

        public Employee(int id, string name, double grossSalary)
        {
            Id = id;
            Name = name;
            GrossSalary = grossSalary;
        }

        public double NetSalary()
        {
            return GrossSalary - GrossSalary * Tax;

        }

        public void IncreaseSalaryPercent(double percent)
        {
            GrossSalary += GrossSalary * percent / 100;
        }

        public void IncreaseSalary(int addSalary)
        {
            GrossSalary += addSalary;
        }

        public override string ToString()
        {
            return "Id: "
            + Id
            + ", Name: "
            + Name
            + ", Salary: "
            + GrossSalary;
        }
    }
}

/*
    SCRIPT TO USE THE CLASS IN MAIN!!

    List<Employee> employee = new List<Employee>();

            System.Console.WriteLine("How many employees you want register?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Clear();

                System.Console.WriteLine();

                System.Console.WriteLine("What is the name of the Employee?");
                string name = Console.ReadLine();

                System.Console.WriteLine("What is the Gross Salary?");
                double grossSalary = double.Parse(Console.ReadLine());

                int id = employee.Count;

                employee.Add(new Employee(id, name, grossSalary));

            }


            System.Console.WriteLine("Do you want increase the salary of someone? (y/n)");
            if (Console.ReadLine() == "y")
            {
                System.Console.WriteLine("What id?");
                int id = int.Parse(Console.ReadLine());
                if (employee.Exists(a => a.Id == id))
                {

                    System.Console.WriteLine("How many you want add to the salary?");
                    int addSalary = int.Parse(Console.ReadLine());
                    employee[id].IncreaseSalary(addSalary);
                }
                else
                {
                    System.Console.WriteLine("Id Invalido =(");
                }
            }

            System.Console.WriteLine();
            System.Console.WriteLine("----------------------------------");
            System.Console.WriteLine();

            System.Console.WriteLine("Updated list of employees:");
            foreach (var element in employee)
            {
                System.Console.WriteLine(element);
            }



*/