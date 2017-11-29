using BlogEngine.Data.Repository.Interfaces;
using BlogEngine.Entity;
using System.Data.Entity;
using System.Linq;

namespace BlogEngine.Data.Repository.Classes
{
    public class BlogCatagoryRepository : Repository<BlogCatagory>, IBlogCatagoryRepository
    {
        public BlogCatagoryRepository(DbContext context) : base(context)
        {
        }

        public BlogCatagory GetBuyUrl(string url)
        {
            BlogCatagory blogCatagory = BlogEngineDb.BlogCatagories.Include(bc => bc.Blogs)
                .SingleOrDefault(bc => bc.Url == url);
            return blogCatagory;
        }
    }
}
