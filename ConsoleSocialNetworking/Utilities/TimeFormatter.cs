using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocialNetworking.Utilities
{
    public class TimeFormatter
    {
        public string formatTimeStamp(DateTime time)
        {
            TimeSpan test = DateTime.Now.ToUniversalTime() - time;
            var minutesSince = test.Minutes;
            string timestring;
            if (minutesSince <= 0) timestring = "just now";
            else if (minutesSince == 1)
            {
                timestring = $"{minutesSince} minute ago";
            }
            else
            {
                timestring = $"{minutesSince} minutes ago";
            }

            return timestring;
        }
    }
}
