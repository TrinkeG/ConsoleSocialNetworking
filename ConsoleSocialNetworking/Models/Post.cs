using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using ConsoleSocialNetworking.Utilities;

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
           TimeFormatter formatter = new TimeFormatter();
            return $"{Message} ({formatter.formatTimeStamp(DatePosted)})";
        }
    }
}
