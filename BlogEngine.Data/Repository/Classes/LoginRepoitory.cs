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

        public Login GetLoginByUsernameAndPassword(string username, string password)
        {
            Login login = Context.Logins
                .SingleOrDefault(l => l.Username == username && l.Password == password);

            return login;
        }

        public ICollection<Blog> GetBlogByLogin(string url)
        {
            List<Blog> blogs = new List<Blog>();

            User user = Context.Users.SingleOrDefault(u => u.Login.Username == url);

            blogs = Context.Blogs.Where(b => b.User == user).ToList();

            return blogs;
        }
    }
}
