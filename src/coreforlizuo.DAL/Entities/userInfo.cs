using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreforzhihu.DAL.Entities
{
    /// <summary>
    /// 用户实体类
    /// </summary>
    public class userInfo
    {

        public int userID { get; set; }

        public string userPicture { get; set; }

        public string userName { get; set; }

        public string userSex { get; set; }

        public string userAge { get; set; }

    }
}
