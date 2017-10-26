using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using coreforzhihu.DAL.Entities;
using coreforzhihu.DAL;

namespace coreforzhihu.Repository
{
    public class UserRepository:IUserRepository
    {
        private coreforzhihuContext context;
        public UserRepository(coreforzhihuContext _context)
        {
            context = _context;
        }
        /// <summary>
        /// 添加用户信息 
        /// </summary>
        /// <param name="userinfo"></param>
        /// <returns></returns>
        public Task AddAsync(userInfo userinfo)
        {
            context.users.Add(userinfo);
            return context.SaveChangesAsync();
        }
    }
}
