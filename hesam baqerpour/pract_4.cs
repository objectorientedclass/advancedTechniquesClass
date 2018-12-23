using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    class SavingAccount {
        static float annualIntrestRate = 1000;
        float savingBalance;
        float monthlyAnnualIntrest;
        float intrestRate ;

        public SavingAccount(float savingBalance) {
            this.savingBalance = savingBalance;
        }

        public void calculateMonthlyIntrest() {
            monthlyAnnualIntrest = (annualIntrestRate * savingBalance) / intrestRate;
        }

        public static void modifyIntrestRate()
        {

        }

        public void changeIntrestRate(float value){
            this.intrestRate = value;
        }

        public void showSaverInfo() {
            Console.WriteLine("this saver's info is :\n" +
                "saving balance : {0} \nmonthly annual intrest : {1} \nintrest rate : {2}"
                ,savingBalance,monthlyAnnualIntrest,intrestRate);
        }

    }



    class MySavingAccount
    {

        static void Main(string[] args)
        {
            SavingAccount saver1 = new SavingAccount(2000);
            SavingAccount saver2 = new SavingAccount(3000);

            saver1.changeIntrestRate(0.4f);
            saver2.changeIntrestRate(0.4f);

            Console.WriteLine(saver1.showSaverInfo());
            Console.WriteLine(saver2.showSaverInfo());



            saver1.changeIntrestRate(0.5f);
            saver2.changeIntrestRate(0.5f);

            Console.WriteLine(saver1.showSaverInfo());
            Console.WriteLine(saver2.showSaverInfo());

            Console.ReadKey();
        }

    }

}