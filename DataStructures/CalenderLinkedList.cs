﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    class CalenderLinkedList
    {
        public void CalenderLinkedlistDemo()
        {
            string[] months = new string[]
           {
               "jan" , "feb", "march", "april", "may", "june", "july", "aug", "sept", "oct", "nov", "dec"
           };
            //// storing days of week
            string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
            int year;
            Console.WriteLine("Enter the year");
            year = Utility.IsIntegerInRange(Console.ReadLine(), 999, 10000);
            Console.WriteLine("Enter the month");
            string month = Utility.IsString(Console.ReadLine());
            //// to check even if it is entered in uppercase
            month.ToLower();
            bool flag = false;
            int monthint = 0, indexofcurrent=0;
            //// checking if the string is a month
            foreach (string s in months)
            {
                if (month.Equals(s))
                {
                    flag = true;
                    break;
                }
                monthint++;
            }
            if (flag == false)
            {
                Console.WriteLine("The string you mentioned is not a month");

                return;
            }
            int febdays = 28, i = 0;
            //// if leapyear feb has 29 days
            if (Utility.LeapYear(year) == true)
            {
                febdays = 29;
            }
            int[] numdaysinmonth = { 31, febdays, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int day = 1;
            Utility.DayOfWeek(day,monthint,year);
            LinkedList<Calender> cals = new LinkedList<Calender>();
            int counter = 0;
            string daycalulated = Utility.DayOfWeek(1, monthint+1, year);
            int indexoffirst = 0;

            
            foreach (string e in days)
            {
                if (e.Equals(daycalulated))
                {
                    indexoffirst = i;
                }
                i++;
            }
            //// Console.WriteLine("the day calculated is {0}, index of first is {1}", daycalulated, indexoffirst);
            Calender c;
            for (counter = 1; counter <= 7; counter++)
            {
                c = new Calender();
                c.SetWeekDay(days[counter-1]);
                for (day = 1; day <= numdaysinmonth[monthint]; day++)
                {
                    daycalulated = Utility.DayOfWeek(day,monthint+1,year);
                    if (daycalulated.Equals(days[counter - 1]))
                    {
                        c.AddDays(day);
                    }
                }
                cals.AddLast(c);
            }

            //// adding spaces to the places where there should not  be any vale
            
            i = 0;
            foreach (Calender o in cals)
            {
                if (i < indexoffirst && i<7)
                {
                    o.AddSpace();
                }
                else
                {
                    break;
                }
                i++;
            }
            

            Console.WriteLine("Printing the calender Vertically");
            foreach (Calender o in cals)
            {
                Console.Write(o.ReturnDayofWeek() + "\t");
                string[] temp = o.ReturnDays();
                foreach (string s in temp) Console.Write(s);
                Console.WriteLine();
            }
        }
    }    
}
