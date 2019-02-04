﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    class CalenderPrinter
    {
        public void CalenderPrinterDemo()
        {
            //// storing months in array
            string[] months = new string[]
            {
               "jan" , "feb", "march", "april", "may", "june", "july", "aug", "sept", "oct", "nov", "dec"
            };
            //// storing days
            string[] days = { "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat", "Sun" };
            //// starting date
            int day = 1, year = 0;
            Console.WriteLine("Enter the year");
            year = Utility.IsIntegerInRange(Console.ReadLine(), 999, 10000);
            Console.WriteLine("Enter the month");
            string month = Utility.IsString(Console.ReadLine());
            month = month.ToLower();
            bool flag = false;
            int monthint = 0;
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
            if(flag == false)
            {
                monthint = 0;
            }
            //// taking the input untill its a  month
            while (flag == false)
            {
                monthint = 0;
                Console.WriteLine("The string provided is not a month please try again");
                month = Utility.IsString(Console.ReadLine());
                flag = false;              
                foreach (string s in months)
                {
                    monthint++;
                    if (month.Equals(s))
                    {
                        flag = true;
                        break;
                    }                    
                }
            }
            
            int febdays = 28,i=0;
            if (Utility.LeapYear(year)==true)
            {
                febdays = 29;
            }
            int[] numdaysinmonth = { 31, febdays, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[,] calender = new string [7 , 8];
            int counter = 0,j=1;
            foreach (string s in days)
            {
                calender[ 0,counter] = days[counter++] + "\t";
            }
            counter = 0;
            string daycalulated= Utility.DayOfWeek(1, monthint+1, year);
            i = 0;
            j = 0;
            while (daycalulated.Equals(days[i])== false)
            {
                calender[1, i] = "\t";
                i++;
            }

            for (counter = 1; counter <= numdaysinmonth[monthint]; counter++)
            {
                daycalulated = Utility.DayOfWeek(day, monthint+1, year);
                for (i = 0; i < 7; i++)
                {
                    if (daycalulated.Equals(days[i]))
                    {
                        j = 1;
                        while (calender[j, i] != null) j++;
                        calender[j, i] = day.ToString()+"\t";
                     }                    
                }
                day++;
            }
            Console.WriteLine(months[monthint]+" " + year);
            for (i = 0; i < 6; i++)
            {
                for (j =0; j < 7; j++)
                {
                    Console.Write(calender[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
