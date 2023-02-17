using BlogApp.Domain.Common;

namespace BlogApp.Domain.Entities
{
    public class PostComment : BaseDomainEntity
    {
        public string Body { get; set; }
        public int PostId { get; set; }
        public virtual Post Post { get; set; }
    }
}
