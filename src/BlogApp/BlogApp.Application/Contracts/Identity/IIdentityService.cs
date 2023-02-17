using BlogApp.Application.Models.Identity;
using BlogApp.Domain.Common.Enums;

namespace BlogApp.Application.Contracts.Identity
{
    public interface IIdentityService
    {
        Task<AuthenticationResult> LoginAsync(string email, string password);
        Task<AuthenticationResult> RegisterAsync(string email, string password, UserRole? role);
        Task<bool> DeleteUserAsync(string userId);
        Task<string> GetUserNameAsync(string userId);
    }
}
