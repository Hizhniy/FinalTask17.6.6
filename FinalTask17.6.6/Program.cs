using System;

namespace FinalTask17._6._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            calculator.GetInterest(new AccountSalary());
            calculator.GetInterest(new AccountGeneral());

            Console.ReadKey();
        }
    }
}