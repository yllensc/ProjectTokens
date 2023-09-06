using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domine.Interfaces
{
    public interface IUnitOfWork
    {
        IUser Users { get; }
        IRol Roles { get; }
        Task<int> SaveAsync();
    }
}