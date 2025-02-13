namespace CRUDWebAPI.Models
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserRegisterDto : UserDto
    {
        public string Role { get; set; }
    }
}