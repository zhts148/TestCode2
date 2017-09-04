using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestCode2.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestCode2.Controllers
{
    [Route("api/[controller]/[action]")]
    public class UserController : Controller
    {
        [HttpGet] // Matches '/Products/List'
        public string GetUserList()
        {
            string s = "";
            List<UserModel> list = new List<UserModel>();
            UserModel um = new UserModel()
            {
                ID = 1,
                Name = "我是测试1"
            };
            UserModel um2 = new UserModel()
            {
                ID = 2,
                Name = "我是测试2"
            };
            UserModel um3 = new UserModel()
            {
                ID = 3,
                Name = "我是测试3"
            };
            UserModel um4 = new UserModel()
            {
                ID = 4,
                Name = "我是测试4"
            };
            UserModel um5 = new UserModel()
            {
                ID = 5,
                Name = "我是测试5"
            };
            UserModel um6 = new UserModel()
            {
                ID = 6,
                Name = "我是测试6"
            };
            list.Add(um);
            list.Add(um2);
            list.Add(um3);
            list.Add(um4);
            list.Add(um5);
            list.Add(um6);
            s = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            return s;
        }
        
    }
}
