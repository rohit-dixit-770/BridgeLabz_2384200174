namespace RepositoryLayer.Service
{
    public class UserRegistrationRL : IUserRegistrationRL
    {
        public bool RegistrationRL(string username, string password)
        {
            return username == "root" && password == "root";
        }
    }
}
