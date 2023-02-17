using BlogApp.Application.Contracts.Identity;
using Microsoft.AspNetCore.Http;

namespace BlogApp.Infrastructure.Identity
{
    public class CurrentUserService : ICurrentUserService
    {
        public string UserId { get; }
        public CurrentUserService(IHttpContextAccessor httpContextAccessor)
        {
            UserId = httpContextAccessor.HttpContext?.User?.Claims?.Single(u => u.Type == "id").Value;
        }
    }
}
