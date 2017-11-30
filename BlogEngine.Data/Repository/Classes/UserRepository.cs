using BlogEngine.Data.Repository.Interfaces;
using BlogEngine.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BlogEngine.Data.Repository.Classes
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(DbContext context) : base(context)
        {
        }
        

        public User GetByUrl(string url)
        {
            User user = BlogEngineDb.Users.Include(u => u.Blogs).SingleOrDefault(u => u.Url == url);

            return user;
        }
    }
}
