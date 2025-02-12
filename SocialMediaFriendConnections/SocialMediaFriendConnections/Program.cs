namespace SocialMediaFriendConnections
{
    class Program
    {
        static void Main(string[] args)
        {
            SocialMediaSystem system = new SocialMediaSystem();

            // Add users
            system.AddUser(1, "Anil", 25);
            system.AddUser(2, "Boby", 30);
            system.AddUser(3, "Chotu", 22);
            system.AddUser(4, "Dav", 28);

            // Add friend connections
            system.AddFriendConnection(1, 2);
            system.AddFriendConnection(1, 3);
            system.AddFriendConnection(2, 4);
            system.AddFriendConnection(3, 4);

            // Display friends of a user
            system.DisplayFriends(1);

            // Find mutual friends
            system.FindMutualFriends(1, 4);

            // Remove a friend connection
            system.RemoveFriendConnection(1, 3);

            // Search for a user by name or ID
            system.SearchUser(name: "Boby");
            system.SearchUser(userID: 3);

            // Count the number of friends for each user
            system.CountFriends();
            Console.ReadKey();
        }
    }

}