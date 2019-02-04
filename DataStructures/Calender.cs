using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class Calender
    {
        string week;
        string[] days = new string[8];

        public void SetWeekDay(string weekday)
        {
            this.week = weekday;
        }

        public string ReturnDayofWeek()
        {
            return this.week;
        }
        
        public string[] ReturnDays()
        {
            //string days1 = this.days.ToString();
            //foreach (string s in days) Console.Write(s.ToString());
            return days;
        }

        public void AddDays(int day)
        {
            int i = 0;
            while (this.days[i] != null)
            {
                i++;
            }

            this.days[i] = day.ToString() + "\t";
        }
        public void AddDays(string day)
        {
            this.days[0] = day;
        }

        public void AddSpace()
        {
            int i = 0, j=0;

            while (this.days[i].Equals(null) != false) i++;
            
            for (j = i-1; j >= 1 ; j--)
            {
                this.days[j] = this.days[j - 1];
            }
            this.days[0] = "\t";
        }
    }
}
