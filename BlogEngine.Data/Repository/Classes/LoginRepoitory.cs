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
    public class LoginRepository : Repository<Login>, ILoginRepository
    {
        public LoginRepository(DbContext context) : base(context)
        {
        }

        public Login GetLoginByUsernameAndPassword(string username, string password)
        {
            Login login = BlogEngineDb.Logins
                .SingleOrDefault(l => l.Username == username && l.Password == password);

            return login;
        }

        public ICollection<Blog> GetBlogByLogin(string url)
        {
            List<Blog> blogs = new List<Blog>();

            User user = BlogEngineDb.Users.SingleOrDefault(u => u.Login.Username == url);

            blogs = BlogEngineDb.Blogs.Where(b => b.User == user).ToList();

            return blogs;
        }
    }
}
