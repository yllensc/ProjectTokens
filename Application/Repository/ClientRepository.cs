using Domine.Data;
using Domine.Entities;
using Domine.Interfaces;

namespace Application.Repository;
    public class ClientRepository: GenericRepository<Client>, IClient
    {
        
        protected readonly ProjectTokensDbContext _context;
        public ClientRepository(ProjectTokensDbContext context) : base(context)
        {
            _context = context;
        }
    }