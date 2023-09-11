using Domine.Data;
using Domine.Entities;
using Domine.Interfaces;


namespace Application.Repository;
    public class HistorialTokensRepository: GenericRepository<HistorialRefreshToken>, IHistorialTokens
    {
        
        protected readonly ProjectTokensDbContext _context;
        public HistorialTokensRepository(ProjectTokensDbContext context) : base(context)
        {
            _context = context;
        }
    }