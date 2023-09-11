using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domine.Interfaces
{
    public interface IUnitOfWork
    {
        IUser Users { get; }
        IRol GetRoles();
        IClient Clients {get; }
        IHistorialTokens HistorialTokens {get; }
        Task<int> SaveAsync();
    }
}