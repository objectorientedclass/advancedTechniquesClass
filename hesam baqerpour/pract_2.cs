using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class NewDate {
        private int month;
        private int day;
        private int year;

        public NewDate(int theMonth, int theDay, int theYear) {
            if (theMonth > 0 && theMonth <= 12)
                month = theMonth;
            else {
                month = 1;
                Console.WriteLine("Month {0} invalid. Set to month 1.", theMonth);
                year = theYear;
                day = CheckDay(theDay);
            }
        }
        private int CheckDay(int testDay)
        {
            int[] daysPerMonth =
                { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (testDay > 0 && testDay <= daysPerMonth[month])
                return testDay;
            if (month == 2 && testDay == 29 &&
                (year % 400 == 0 ||
                (year % 4 == 0 && year % 100 != 0)))
                return testDay;
            Console.WriteLine("Day {0} invalid. Set to day 1.", testDay);
            return 1;

        }

        public string ToDateString(){
            return month + "/" + day + "/" + year;
            }
        }
    }


    class Student {
        public int counter = 0;
        int std_id;
        string name, family;
        NewDate birthDate, successDate;
        

    public Student(string name, string family, int std_id, NewDate birthDate, Date successDate) {
        this.name = name;
        this.family = family;
        this.std_id = std_id;
        this.birthDate = birthDate;
        this.successDate = successDate;
        this.counter = counter++;
    }

    public Student(NewDate birthDate, NewDate successDate) {
	this.birthDate = birthDate ;
	this.successDate = successDate ;
    }

    public void showDateInfo() {
        Console.WriteLine("student information is : \n"
            + name + family +"\n"+ std_id + "\n" + "birthdate : " + birthDate
            + "successdate : " + successDate + "\n this much students are online : "+counter);
    }

    }

    class Main
    {
        static void Main(string[] args)
        {
        
        Student std1 = new Student("hesam", "Bagherpour", "9714,"12 / 14 / 97","1 / 1 / 18");
        Student std2 = new Student("ali", "mirzade", "7112", "12/14/97", "1/1/18");

        std1.showDateInfo();
        std2.showDateInfo();
        
        
    }
    }
}