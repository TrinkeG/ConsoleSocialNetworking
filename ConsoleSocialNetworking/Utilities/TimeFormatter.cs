using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocialNetworking.Utilities
{
    public class TimeFormatter
    {
        public string FormatTimeStamp(DateTime time)
        {
            TimeSpan test = DateTime.Now.ToUniversalTime() - time;
            string timestring;
            //days format # day(s) ago
            if (test >= new TimeSpan(1, 0, 0, 0))
            {
                timestring = $"{GetUnitString(test.Days,"day")} ago";
            }
            //hours format # hour(s) minute(s) ago
            else if (test >= new TimeSpan(1, 0, 0))
            {
                timestring = $"{GetUnitString(test.Hours, "hour")}"+$" {GetUnitString(test.Minutes, "minute")}".TrimEnd() + " ago";
            }
            //minutes format # minute(s) ago
            else if (test >= new TimeSpan( 0, 1, 0))
            {
                timestring = $"{GetUnitString(test.Minutes, "minute")} ago";
            }
            //seconds format # second(s) ago
            else if (test >= new TimeSpan(0, 0, 1))
            {
                timestring = $"{GetUnitString(test.Seconds, "second")} ago";
            }
            else
            {
                timestring = "just now";
            }

            return timestring;
        }

        /// <summary>
        /// takes a number value and a unit and decides what format the string should be in
        /// </summary>
        /// <param name="value">number of the given units</param>
        /// <param name="unit">type of unit</param>
        /// <returns>formatted unit string</returns>
        private static string GetUnitString(int value, string unit)
        {
            if (value == 0)
            {
                return "";
            }
            return value > 1 ? $"{value} {unit}s" : $"{value} {unit}";
        }
    }
}
