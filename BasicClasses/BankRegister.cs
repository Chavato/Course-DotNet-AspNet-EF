using System;

namespace BasicClasses
{
    class RegisterAccount
    {

        public double MoneyBalance { get; private set; }
        public int AccNumber { get; private set; }
        public string Name { get; set; }

        public RegisterAccount(int accNumber, string name)
        {
            AccNumber = accNumber;
            Name = name;

        }
        public RegisterAccount(int accNumber, string name, double initialMoney) : this(accNumber, name)
        {
            PostMoney(initialMoney);

        }

        public void PostMoney(double money)
        {
            MoneyBalance += money;
            ShowInfoAcc();
        }

        public void GetMoney(double money)
        {
            MoneyBalance -= money + 5;
            ShowInfoAcc();
        }

        public void ShowInfoAcc()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Account Information");
            System.Console.WriteLine("Account Number: {0}, Name: {1}, Balance: {2}", AccNumber, Name, MoneyBalance);
            System.Console.WriteLine();
        }
    }

}