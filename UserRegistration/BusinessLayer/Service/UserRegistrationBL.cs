using RepositoryLayer.Service;

namespace BusinessLayer.Service
{
    public class UserRegistrationBL : IUserRegistrationBL
    {
        private readonly IUserRegistrationRL _userRegistrationRL;

        public UserRegistrationBL(IUserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public bool CheckUserPass(string username, string password) 
        {
            return _userRegistrationRL.RegistrationRL(username, password);
        }

        public string RegistrationBL(string username, string password)
        {
           
            return CheckUserPass(username , password) ? "Login Successful" : "Invalid username and password";
        }
    }
}
