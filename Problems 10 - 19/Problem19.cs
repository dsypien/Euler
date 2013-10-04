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
		// It felt a bit cheap to use DateTime for this problem, so instead I created
		// a date object and Month and Day enums for this problem
		struct Date
		{
			public int Year;
			public int Month;
			public Day Day;
		}

		enum Day
		{
			Monday = 0 ,
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

		private static Date _currentDate;

        static public int Run()
        {
			int numSundays = 0;

			_currentDate.Year = 1900;
			_currentDate.Month = 1;
			_currentDate.Day = Day.Monday;

			// Get to January 1, 1901
			while (_currentDate.Year < 1901)
			{
				AddMonth();
			}

			for (int year = 1901; year <= 2000; year++)
			{
				for (int month = 1; month <= 12; month++)
				{
					AddMonth();

					if (_currentDate.Day == Day.Sunday)
					{
						numSundays++;
					}
				}
			}

			return numSundays;
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

			_currentDate.Day = (Day) (((int)_currentDate.Day + numDaysInMonth) % 7) ;

			if (_currentDate.Month == (int)Month.December)
			{
				_currentDate.Year++;
				_currentDate.Month = (int) Month.January;
			}
			else
			{
				_currentDate.Month = (int)_currentDate.Month + 1;
			}
		}

		static private int GetNumDays()
		{
			switch (_currentDate.Month)
			{
				case (int)Month.April:
				case (int)Month.June:
				case (int)Month.September:
				case (int)Month.November:

					return 30;
					
				case (int)Month.February:

					if (IsLeapYear(_currentDate.Year))
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
