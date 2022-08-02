using System;

namespace DateAndTime
{
    class Date
    {
        public static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2022,08,02,16,00,00);
            DateTime date2 = new DateTime(2022,07,03,12,00,00);
            DateAndTime.Difference.CalcDiff(date1,date2);
        }
    }

    class Difference
    {
        public static void CalcDiff(DateTime date1,DateTime date2)
        {
            TimeSpan timediff = date1 - date2;
            Console.WriteLine("Time Difference between Date2 and Date1 is : " + timediff);
        }
    }
}

    
