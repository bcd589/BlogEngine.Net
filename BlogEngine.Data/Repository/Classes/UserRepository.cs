using BlogEngine.Data.Repository.Interfaces;
using BlogEngine.Entity;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BlogEngine.Data.Repository.Classes
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        
        public User GetByUrl(string url)
        {
            User user = Context.Users.Include(u => u.Blogs).SingleOrDefault(u => u.Url == url);

            return user;
        }

        public User GetByLogin(int loginId)
        {
            User user = Context.Users.Include(u => u.Blogs).Where(u => u.LoginId == loginId).SingleOrDefault();
            return user;
        }
    }
}
