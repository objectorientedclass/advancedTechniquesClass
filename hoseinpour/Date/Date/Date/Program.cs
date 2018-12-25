using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
     class Date
     {
          private int Day;
          private int Month;
          private int Year;
          public int day
          {
               set
               {
                         Day = value;
               }
          }
          public int month
          {
               set
               {
                         Month = value;
               }
          }
          public int year
          {
               set
               {
                         Year = value;
               }
          }
          private string ChangeMonthToString (int MonthNumber)
          {
               switch(MonthNumber)
               {
                    case 1:
                         return "January";
                    case 2:
                         return "February ";
                    case 3:
                         return "March";
                    case 4:
                         return "April";
                    case 5:
                         return "May";
                    case 6:
                         return "June";
                    case 7:
                         return "July";
                    case 8:
                         return "August";
                    case 9:
                         return "September";
                    case 10:
                         return "October";
                    case 11:
                         return "November";
                    case 12:
                         return "December";
               }
               return "Wrong Number";
          }
          private int ChangeMonthToDay(int MonthNumber)
          {
               switch (MonthNumber)
               {
                    case 1:
                         return Day;
                    case 2:
                         return Day+31;
                    case 3:
                         return Day+59;
                    case 4:
                         return Day+90;
                    case 5:
                         return Day+120;
                    case 6:
                         return Day+151;
                    case 7:
                         return Day+181;
                    case 8:
                         return Day+212;
                    case 9:
                         return Day+243;
                    case 10:
                         return Day+273;
                    case 11:
                         return Day+304;
                    case 12:
                         return Day+334;
               }
               return 0;
          }
          public Date (int Year , int Month , int Day)
          {
               day = Day;
               month = Month;
               year = Year;
               Console.Clear();
               PrintMonthDayYear();
               PrintDayYear();
               PrintMonthNameDayYear();
          }
          private void PrintMonthDayYear()
          {
               Console.WriteLine("Date(MM/DD/YYYY) is : {0}/{1}/{2}\n",Month , Day , Year);
          }
          private void PrintMonthNameDayYear()
          {
               Console.WriteLine("Date(Month Name DD YYYY) is : {0} {1} {2}\n", ChangeMonthToString(Month) , Day , Year);
          }
          private void PrintDayYear()
          {
               Console.WriteLine("Date(DDD.YYYY) is : {0}.{1}\n", ChangeMonthToDay(Month) , Year);
          }
     }
     class Program
     {
          static void Main(string[] args)
          {
               bool Loop = true;
               while (Loop)
               {
                    int Day = 0, Month = 0, Year = 0;
                    Console.WriteLine("Enter Day Please : ");
                    int.TryParse(Console.ReadLine(), out Day);
                    while (Day < 1 || Day > 31)
                    {
                         Console.WriteLine("Day Must Be Between 1 And 31");
                         Console.WriteLine("Enter Day Again Please : ");
                         Day = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Enter Month Please : ");
                    int.TryParse(Console.ReadLine(), out Month);
                    while (Month < 1 || Month > 12)
                    {
                         Console.WriteLine("Month Must Be Between 1 And 12");
                         Console.WriteLine("Enter Month Again Please : ");
                         Month = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("Enter Year Please : ");
                    int.TryParse(Console.ReadLine(), out Year);
                    while (Year < 1 || Year > 9999)
                    {
                         Console.WriteLine("Year Must Be Between 1 And 9999");
                         Console.WriteLine("Enter Year Again Please : ");
                         Year = Convert.ToInt32(Console.ReadLine());
                    }
                    Date OBJ = new Date(Year, Month, Day);
                    Console.WriteLine("Press Enter To Continue Or Any Key To Exit : ");
                    ConsoleKeyInfo KeyInfo = Console.ReadKey();
                    if (KeyInfo.Key != ConsoleKey.Enter)
                         Loop = false;  
               }
          }
     }
}
