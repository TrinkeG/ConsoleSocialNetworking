using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocialNetworking
{
    public class User
    {
        private readonly string _userName;
        public List<Post> Posts = new List<Post>();
        public List<User> FollowedUsers = new List<User>();
 
        public User(string userName)
        {
            _userName = userName;
        }

        public void AddPost(string postmessage)
        {
            var post = new Post(postmessage, _userName);
            Posts.Add(post);
        }

        public void AddFollows(User user)
        {
            if(!FollowedUsers.Contains(user))
                FollowedUsers.Add(user);
        }

        public string GetUserName()
        {
            return _userName;
        }

        public override bool Equals(object obj)
        {
            var user = (User) obj;
            return user != null && user.GetUserName().Equals(_userName);
        }
    }
}
