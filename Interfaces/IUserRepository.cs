using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameBaseSite.Models;

namespace GameBaseSite.Interfaces
{
    public interface IUserRepository : IGenericRepository<UserModel>
    {
        Task<IEnumerable<UserModel>> GetUsersById(int id);
    }
}
