using coreforzhihu.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreforzhihu.Repository
{
    public interface IUserRepository
    {
        Task AddAsync(userInfo userinfo);
    }
}
