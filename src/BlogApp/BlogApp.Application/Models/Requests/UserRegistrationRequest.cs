using BlogApp.Domain.Common.Enums;

namespace BlogApp.Application.Models.Requests
{
    public class UserRegistrationRequest
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRole? Role { get; set; }
    }
}
