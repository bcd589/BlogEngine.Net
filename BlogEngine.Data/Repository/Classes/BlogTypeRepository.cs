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
    public class BlogTypeRepository : Repository<BlogType>, IBlogTypeRepository
    {

        public BlogType GetByUrl(string url)
        {
            BlogType blogType = Context.BlogTypes.Include(bt => bt.Blogs).SingleOrDefault(bt => bt.Url == url);
            return blogType;
        }
    }
}
