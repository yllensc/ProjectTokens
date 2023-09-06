using Domine.Data;
using Domine.Entities;
using Domine.Interfaces;

namespace Application.Repository;
    public class RolRepository: GenericRepository<Rol>, IRol
    {
        
        protected readonly ProjectTokensDbContext _context;
        public RolRepository(ProjectTokensDbContext context) : base(context)
        {
            _context = context;
        }

        
    }