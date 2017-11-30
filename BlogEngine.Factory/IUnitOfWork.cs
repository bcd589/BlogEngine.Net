using BlogEngine.Data.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogEngine.Factory
{
    public interface IUnitOfWork : IDisposable
    {
        IBlogRepository BlogRepository { get; }
        IBlogCatagoryRepository BlogCatagoryRepository { get; }
        IBlogTypeRepository BlogTypeRepository { get; }
        ICommentRepository CommentRepository { get; }
        ILoginRepository LoginRepository { get; }
        IPermissionRepository PermissionRepository { get; }
        IRoleRepository RoleRepository { get; }
        IUserRepository UserRepository { get; }

        int Complete();
    }
}
