using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocialNetworking
{
    public class Post
    {
        public string UserName { get; }
        public DateTime DatePosted { get; set; }

        public string Message { get;}
        

        public Post( string message, string username)
        {
            UserName = username;
            Message = message;
            DatePosted = DateTime.Now.ToUniversalTime();

        }
        
        public string GetMessageString()
        {
            TimeSpan test = DateTime.Now.ToUniversalTime() - DatePosted;
            var minutesSince = test.Minutes;
            string time;
            if (minutesSince <= 0) time = "just now";
            else if (minutesSince == 1)
            {
                time = $"{minutesSince} minute ago";
            }
            else
            {
                time = $"{minutesSince} minutes ago";
            }
            return $"{Message} ({time})";
        }
    }
}
