using Domine.Data;
using Domine.Entities;
using Domine.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Application.Repository;
    public class UserRepository: GenericRepository<User>, IUser
    {
        
        protected readonly ProjectTokensDbContext _context;
        public UserRepository(ProjectTokensDbContext context) : base(context)
        {
            _context = context;
        }

    public async Task<User> GetUserName(string username)
    {
        return await _context.Users
                            .Include(u=>u.Roles)
                            .FirstOrDefaultAsync(u=>u.UserName.ToLower()==username.ToLower());
    }
}