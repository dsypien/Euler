using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Euler
{
    /// <summary>
    /// Counting Sundays
    /// </summary>
    /// 
    /// You are given the following information, but you may prefer to do some research for yourself.
    /// 1 Jan 1900 was a Monday.
    /// Thirty days has September,
    /// April, June and November.
    /// All the rest have thirty-one,
    /// Saving February alone,
    /// Which has twenty-eight, rain or shine.
    /// And on leap years, twenty-nine.
    /// A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
    /// How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
    
    public static class Problem19
    {		
		struct Date
		{
			public int Year;
			public int Month;
			public Day Day;
		}

		enum Day
		{
			Monday = 1 ,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		};

		enum Month
		{
			January = 1,
			February,
			March,
			April,
			May,
			June,
			July,
			August,
			September,
			October,
			November,
			December
		}

		private static Date currentDate;

        public static void Run()
        {
			currentDate.Year = 1900;
			currentDate.Month = 1;
			currentDate.Day = Day.Monday;

			for (int year = 1900; year <= 2000; year++)
			{
				for (int month = 1; month <= 12; month++)
				{

				}
			}
        }

		// A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
		static private bool IsLeapYear(int year)
		{
			// Check if it is a century
			if ((year % 100) == 0)
			{
				return (year % 400) == 0;
			}

			return (year % 4) == 0;
		}
	
		/// <summary>
		/// Adds a month, Updates the currentDay
		/// </summary>
		/// <returns></returns>
		static private void AddMonth()
		{
			int numDaysInMonth = GetNumDays();			
		}

		static private int GetNumDays()
		{
			switch (currentDate.Month)
			{
				case (int)Month.April:
				case (int)Month.June:
				case (int)Month.September:
				case (int)Month.November:

					return 30;
					
				case (int)Month.February:

					if (IsLeapYear(currentDate.Year))
					{
						return 29;
					}
					else
					{
						return 28;
					}

				default:

					return 31;
			}
		}

    }
}
