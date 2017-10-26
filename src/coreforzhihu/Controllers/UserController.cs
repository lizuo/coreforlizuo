using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using coreforzhihu.DAL.Entities;
using coreforzhihu.Repository;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace coreforzhihu.Controllers
{
    public class UserController : Controller
    {

        private IUserRepository _iuserRepository;

        public UserController(IUserRepository iuserReposistory)
        {
            _iuserRepository = iuserReposistory;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddUser()
        {
            userInfo userinfo = new userInfo
            {
                userID = 1,
                userAge = "20",
                userName = "小明",
                userPicture = "asda",
                userSex = "0"

            };
            await _iuserRepository.AddAsync(userinfo);
            
            return Ok();
        }
    }
}
