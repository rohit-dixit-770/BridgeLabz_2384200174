namespace ModelLayer.DTO
{
    public class LoginDTO
    {
        public string username { get; set; }  
        public string password { get; set; } 

        public override string ToString()
        {
            return $"Username = {username}, Password = {password}";  
        }
    }
}
