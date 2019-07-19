using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WesForum.Models.Post;

namespace WesForum.Models.Forum
{
    public class ForumTopicModel
    {
        public ForumListingModel Forum { get; set; }
        public IEnumerable<PostListingModel> Posts { get; set; }
    }
}
