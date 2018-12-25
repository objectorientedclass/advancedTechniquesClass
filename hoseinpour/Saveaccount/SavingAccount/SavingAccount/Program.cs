using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
     class SavingAccount
     {
          private static double AnnualInterestRate;
          private double SavingBalance;
          public double savingbalance
          {
               set
               {
                    if (value > 0)
                         SavingBalance = value;
               }
          }
          public static double annualinteresrate
          {
               set
               {
                    if (value >= 0)
                         AnnualInterestRate = value / 100;
               }

          }


          public SavingAccount(double Deposite)
          {
               savingbalance = Deposite;
          }
          public double CalculateMonthlyInterest()
          {
               return SavingBalance * AnnualInterestRate / 12;
          }
          public void AddMonthlyInterest()
          {
               SavingBalance = SavingBalance + CalculateMonthlyInterest();
          }
          public static void ModifyInterestRate(double annualinterestrate)
          {
               AnnualInterestRate = annualinterestrate;
          }

     }
     class Program
     {
          static void Main(string[] args)
          {
               SavingAccount Saver1 = new SavingAccount(2000);
               SavingAccount Saver2 = new SavingAccount(3000);
               SavingAccount.annualinteresrate = 4;
               Console.WriteLine("With 4% AnnualInterestrate");
               Console.WriteLine("First Saver Monthly Income : {0}", Saver1.CalculateMonthlyInterest());
               Console.WriteLine("Second Saver Monthly Income : {0}", Saver2.CalculateMonthlyInterest());
               SavingAccount.annualinteresrate = 5;
               Console.WriteLine("With 5% AnnualInterestrate");
               Console.WriteLine("First Saver Monthly Income : {0}", Saver1.CalculateMonthlyInterest());
               Console.WriteLine("Second Saver Monthly Income : {0}", Saver2.CalculateMonthlyInterest());
               Console.ReadKey();


          }
     }
}
