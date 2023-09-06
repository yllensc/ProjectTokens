using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domine.Entities;

namespace Domine.Interfaces
{
    public interface IUser : IGeneric<User>
    {
        Task<User> GetUserName(string userName);
    }
}