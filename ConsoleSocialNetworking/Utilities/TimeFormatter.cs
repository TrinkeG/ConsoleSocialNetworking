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
            if (test >= new TimeSpan(1, 0, 0, 0))
            {
                timestring = $"{GetUnitString(test.Days,"day")} ago";
            }
            else if (test >= new TimeSpan(1, 0, 0))
            {
                timestring = $"{GetUnitString(test.Hours, "hour")} {GetUnitString(time.Minute, "minute")} ago";
            }
            else if (test >= new TimeSpan( 0, 1, 0))
            {
                timestring = $"{GetUnitString(test.Minutes, "minute")} ago";
            }else if (test >= new TimeSpan(0, 0, 1))
            {
                timestring = $"{GetUnitString(test.Seconds, "second")} ago";
            }
            else
            {
                timestring = "just now";
            }

            return timestring;
        }

        private string GetUnitString(int value, string unit)
        {
            if (value == 0)
            {
                return "";
            }
            return value > 1 ? $"{value} {unit}s" : $"{value} {unit}";
        }
    }
}
