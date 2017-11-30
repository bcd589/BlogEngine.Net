using BlogEngine.Data.Repository.Interfaces;
using BlogEngine.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Data.Repository.Classes
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public ICollection<Comment> GetCommentsByBlog(Blog blog)
        {
            List<Comment> comments = Context.Comments.Include(c => c.Blog == blog).ToList();
            return comments ?? null;
        }

        public ICollection<Comment> GetCommentsByBlog(int blogId)
        {
            List<Comment> comments = Context.Comments.Include(c => c.BlogId == blogId).ToList();
            return comments ?? null;
        }
    }
}
