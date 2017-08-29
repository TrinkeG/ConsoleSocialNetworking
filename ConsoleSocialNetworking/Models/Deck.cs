using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSocialNetworking.Models
{
    public class Deck
    {
        private readonly Dictionary<string, User> _users = new Dictionary<string, User>();
        public void AddFollows(string follower, string subject)
        {
            var followerUser = GetCreateUser(follower);
            var subjectUser = GetCreateUser(subject);
            followerUser.AddFollows(subjectUser);
        }

        public User GetCreateUser(string userName)
        {
            if (_users.ContainsKey(userName))
                return _users[userName];
            var newUser = new User(userName);
            _users.Add(userName, newUser);
            return newUser;
        }

        public List<Post> Wall(string userName)
        {
            var posts = new List<Post>();
            var user = GetCreateUser(userName);
            foreach (var followedUser in user.FollowedUsers)
            {
                posts.AddRange(followedUser.Posts);
            }
            return posts;
        }

        public List<Post> Read(string userName)
        {
            var user = GetCreateUser(userName);
            return user.Posts;
        }

        public void AddPost(string userName, string postMessage)
        {
            var user = GetCreateUser(userName);
            user.AddPost(postMessage);
        }
    }
}
