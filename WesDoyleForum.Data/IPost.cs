﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WesForum.Data.Models;

namespace WesForum.Data
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);

        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
    }
}
