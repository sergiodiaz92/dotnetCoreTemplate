using BlogApp.Domain.Common;

namespace BlogApp.Domain.Entities
{
    public class Post : BaseDomainEntity
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Locked { get; set; }
        public ICollection<PostComment> Comments { get; set; }
    }
}