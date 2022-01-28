using System;

namespace BasicClasses
{
    class Employee
    {

        public string Name;
        public double GrossSalary;
        public double Tax;


        double NetSalary()
        {
            return GrossSalary - Tax;

        }

        void IncreaseSalary(double percent)
        {
            GrossSalary += GrossSalary * percent / 100;
        }


    }
}