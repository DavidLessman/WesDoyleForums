using System.Collections.Generic;
using WesForum.Models.Reply;

namespace WesForum.Models.Post
{
    public class NewPostModel
    {
        public string ForumName { get; set; }
        public int ForumId { get; set; }
        public string AuthorName { get; set; }
        public string ForumImageUrl { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        
        public IEnumerable<PostReplyModel> Replies { get; set; }
    }
}
