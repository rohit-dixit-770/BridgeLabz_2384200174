using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaFriendConnections
{
    class SocialMediaSystem
    {
        private UserNode head;

        public SocialMediaSystem()
        {
            head = null;
        }

        // Add a new user to the system
        public void AddUser(int userID, string name, int age)
        {
            UserNode newNode = new UserNode(userID, name, age);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                UserNode current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            Console.WriteLine($"User {name} (ID: {userID}) added to the system.");
        }

        // Add a friend connection between two users
        public void AddFriendConnection(int userID1, int userID2)
        {
            UserNode user1 = FindUserByID(userID1);
            UserNode user2 = FindUserByID(userID2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            if (!user1.FriendIDs.Contains(userID2))
            {
                user1.FriendIDs.Add(userID2);
                user2.FriendIDs.Add(userID1);
                Console.WriteLine($"Friend connection added between User {user1.Name} (ID: {userID1}) and User {user2.Name} (ID: {userID2}).");
            }
            else
            {
                Console.WriteLine("Friend connection already exists.");
            }
        }

        // Remove a friend connection between two users
        public void RemoveFriendConnection(int userID1, int userID2)
        {
            UserNode user1 = FindUserByID(userID1);
            UserNode user2 = FindUserByID(userID2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            if (user1.FriendIDs.Contains(userID2))
            {
                user1.FriendIDs.Remove(userID2);
                user2.FriendIDs.Remove(userID1);
                Console.WriteLine($"Friend connection removed between User {user1.Name} (ID: {userID1}) and User {user2.Name} (ID: {userID2}).");
            }
            else
            {
                Console.WriteLine("Friend connection does not exist.");
            }
        }

        // Find mutual friends between two users
        public void FindMutualFriends(int userID1, int userID2)
        {
            UserNode user1 = FindUserByID(userID1);
            UserNode user2 = FindUserByID(userID2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            List<int> mutualFriends = new List<int>();
            foreach (int friendID in user1.FriendIDs)
            {
                if (user2.FriendIDs.Contains(friendID))
                {
                    mutualFriends.Add(friendID);
                }
            }

            if (mutualFriends.Count > 0)
            {
                Console.WriteLine($"Mutual friends between User {user1.Name} (ID: {userID1}) and User {user2.Name} (ID: {userID2}):");
                foreach (int friendID in mutualFriends)
                {
                    UserNode friend = FindUserByID(friendID);
                    Console.WriteLine($"- {friend.Name} (ID: {friendID})");
                }
            }
            else
            {
                Console.WriteLine("No mutual friends found.");
            }
        }

        // Display all friends of a specific user
        public void DisplayFriends(int userID)
        {
            UserNode user = FindUserByID(userID);
            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            if (user.FriendIDs.Count > 0)
            {
                Console.WriteLine($"Friends of User {user.Name} (ID: {userID}):");
                foreach (int friendID in user.FriendIDs)
                {
                    UserNode friend = FindUserByID(friendID);
                    Console.WriteLine($"- {friend.Name} (ID: {friendID})");
                }
            }
            else
            {
                Console.WriteLine("User has no friends.");
            }
        }

        // Search for a user by Name or User ID
        public void SearchUser(string name = null, int? userID = null)
        {
            if (name == null && userID == null)
            {
                Console.WriteLine("Please provide a name or user ID to search.");
                return;
            }

            UserNode current = head;
            bool found = false;
            while (current != null)
            {
                if ((name != null && current.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) ||
                    (userID != null && current.UserID == userID))
                {
                    Console.WriteLine($"User found: ID: {current.UserID}, Name: {current.Name}, Age: {current.Age}");
                    found = true;
                }
                current = current.Next;
            }

            if (!found)
            {
                Console.WriteLine("User not found.");
            }
        }

        // Count the number of friends for each user
        public void CountFriends()
        {
            UserNode current = head;
            while (current != null)
            {
                Console.WriteLine($"User {current.Name} (ID: {current.UserID}) has {current.FriendIDs.Count} friends.");
                current = current.Next;
            }
        }

        // Helper method to find a user by User ID
        private UserNode FindUserByID(int userID)
        {
            UserNode current = head;
            while (current != null)
            {
                if (current.UserID == userID)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
    }

}
