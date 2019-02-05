// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalenderStack.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Prayas Pagade"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DataStructures
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The class to execute the Calendar stack
    /// </summary>
    public class CalenderStack
    {
        /// <summary>
        /// The method to execute the calendar using stack
        /// </summary>
        public void CalenderStackDemo()
        {
            try
            {
                string[] months = new string[]
                {
               "jan", "feb", "march", "april", "may", "june", "july", "aug", "sept", "oct", "nov", "dec"
                };
                //// storing days
                string[] days = { "Sun", "Mon", "Tues", "Wed", "Thurs", "Fri", "Sat" };
                int year;
                Console.WriteLine("Enter the year");
                year = Utility.IsIntegerInRange(Console.ReadLine(), 999, 10000);
                Console.WriteLine("Enter the month");
                string month = Utility.IsString(Console.ReadLine());
                month.ToLower();
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

                if (flag == false)
                {
                    Console.WriteLine("The string you mentioned is not a month");

                    return;
                }

                int febdays = 28, i = 0;
                //// in leapyear feb has 29 days
                if (Utility.LeapYear(year) == true)
                {
                    febdays = 29;
                }

                int[] numdaysinmonth = { 31, febdays, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int day = 1;
                Utility.DayOfWeek(day, monthint + 1, year);
                //// creating a linkedlist to store calender
                LinkedList<Calender> cals = new LinkedList<Calender>();
                int counter = 0;
                string daycalulated = Utility.DayOfWeek(1, monthint + 1, year);
                int indexoffirst = 0;

                foreach (string e in days)
                {
                    if (e.Equals(daycalulated))
                    {
                        indexoffirst = i;
                    }

                    i++;
                }

                Console.WriteLine("the day calculated is {0}, index of first is {1}", daycalulated, indexoffirst);
                Calender c;
                for (counter = 1; counter <= 7; counter++)
                {
                    //// object o be stored in the linked list
                    c = new Calender();
                    c.SetWeekDay(days[counter - 1]);
                    for (day = 1; day <= numdaysinmonth[monthint]; day++)
                    {
                        daycalulated = Utility.DayOfWeek(day, monthint + 1, year);

                        if (daycalulated.Equals(days[counter - 1]))
                        {
                            c.AddDays(day);
                        }
                    }

                    cals.AddLast(c);
                }
                                
                i = 0;
                //// untill the first day of week is reached we'll store "\t" at first element
                foreach (Calender o in cals)
                {
                    if (i < indexoffirst)
                    {
                        o.AddSpace();
                    }
                    else
                    {
                        break;
                    }

                    i++;
                }
                //// Creating 2 stacks
                LinkedList<Calender> stack1 = new LinkedList<Calender>();
                LinkedList<Calender> stack2 = new LinkedList<Calender>();
                Calender ca;
                //// printing for each day of week
                for (i = 0; i < 7; i++)
                {
                    //// 1 stack has opening from top
                    ca = cals.First.Value;
                    stack1.AddFirst(ca);
                    //// 1 stack has opening from bottom
                    stack2.AddLast(ca);
                    cals.RemoveFirst();
                }

                Console.WriteLine("Printing stack 1");
                //// foreach object in stack1
                foreach (Calender o in stack1)
                {
                    Console.Write(o.ReturnDayofWeek() + "\t");
                    string[] temp = o.ReturnDays();
                    foreach (string s in temp)
                    {
                        Console.Write(s);
                    }

                    Console.WriteLine();
                }

                Console.WriteLine("Printing stack 2");

                foreach (Calender o in stack2)
                {
                    Console.Write(o.ReturnDayofWeek() + "\t");
                    //// Fetching the data from object of stack
                    string[] temp = o.ReturnDays();
                    foreach (string s in temp)
                    {
                        Console.Write(s);
                    }

                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process is stopped because " + e);
            }
        }
    }
}
