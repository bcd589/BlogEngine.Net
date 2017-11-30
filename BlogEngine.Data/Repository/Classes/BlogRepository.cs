using BlogEngine.Data.Repository.Interfaces;
using BlogEngine.Entity;
using System.Data.Entity;
using System.Linq;

namespace BlogEngine.Data.Repository.Classes
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(DbContext context) : base(context)
        {
        }

        public Blog GetBuyUrl(string url)
        {
            Blog blog = BlogEngineDb.Blogs.SingleOrDefault(b => b.Url == url) as Blog;
            return blog;
        }
    }
}
