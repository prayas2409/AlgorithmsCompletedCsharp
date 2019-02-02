using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Calender
    {
        string[] months = { "january", "february", "march", "april", "may", "june", "july", "august", "september", "october", "november", "december" };

        public void CalenderDemo()
        {
            int year;
            Console.WriteLine("Enter the year");
            year = Utility.IsIntegerInRange(Console.ReadLine(), 999, 10000);
            Console.WriteLine("Enter the month");
            string month = Utility.IsString(Console.ReadLine());
            month.ToLower();
            if (month.Equals(months))
            {

            }
        }
    }
}
