using System;
using BlogEngine.Data.Repository.Interfaces;
using BlogEngine.Data;
using BlogEngine.Data.Repository.Classes;

namespace BlogEngine.Factory
{
    

    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogEngineDb _context;


        public IBlogRepository BlogRepository { get { return this.BlogRepository ?? new BlogRepository(_context); } }
        public IBlogCatagoryRepository BlogCatagoryRepository { get { return this.BlogCatagoryRepository ?? new BlogCatagoryRepository(_context); } }
        public IBlogTypeRepository BlogTypeRepository { get { return this.BlogTypeRepository ?? new BlogTypeRepository(_context); } }
        public ICommentRepository CommentRepository { get { return this.CommentRepository ?? new CommentRepository(_context); } }
        public ILoginRepository LoginRepository { get { return this.LoginRepository ?? new LoginRepository(_context); } }
        public IPermissionRepository PermissionRepository { get { return this.PermissionRepository ?? new PermissionRepository(_context); } }
        public IRoleRepository RoleRepository { get { return this.RoleRepository ?? new RoleRepository(_context); } }
        public IUserRepository UserRepository { get { return this.UserRepository ?? new UserRepository(_context); } }

        public UnitOfWork(BlogEngineDb context)
        {
            _context = context;
        }


        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
