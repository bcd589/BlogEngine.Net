using BlogEngine.Data.Repository.Interfaces;
using BlogEngine.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BlogEngine.Data.Repository.Classes
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {

        public Blog GetBuyUrl(string url)
        {
            Blog blog = Context.Blogs.SingleOrDefault(b => b.Url == url) as Blog;
            return blog;
        }

        public IList<Blog> GetAllWithDependency()
        {
            var blogs = Context.Blogs.Include(b => b.BlogCatagory).Include(b => b.BlogType).Include(b => b.Comments).ToList();
            return blogs;
        }
    }
}
