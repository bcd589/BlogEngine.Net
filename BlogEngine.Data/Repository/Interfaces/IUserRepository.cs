using BlogEngine.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Data.Repository.Interfaces
{
    public interface IUserRepository : IRepository<User>
    {
        User GetByUrl(string url);
        User GetByLogin(int loginId);
    }
}
