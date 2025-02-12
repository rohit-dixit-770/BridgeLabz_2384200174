using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaFriendConnections
{
    class UserNode
    {
        public int UserID;
        public string Name;
        public int Age;
        public List<int> FriendIDs;
        public UserNode Next;

        public UserNode(int userID, string name, int age)
        {
            UserID = userID;
            Name = name;
            Age = age;
            FriendIDs = new List<int>();
            Next = null;
        }
    }

}
