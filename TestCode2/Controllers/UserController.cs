using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestCode2.Model;

namespace TestCode2.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : Controller
    {
        [HttpGet]
        public string GetUserList()
        {
            string s = "";
            List<UserModel> list = new List<UserModel>();
            UserModel um = new UserModel()
            {
                ID = 1,
                Name = "aaa"
            };
            UserModel um2 = new UserModel()
            {
                ID = 2,
                Name = "bbb"
            };
            UserModel um3 = new UserModel()
            {
                ID = 3,
                Name = "ccc"
            };
            UserModel um4 = new UserModel()
            {
                ID = 4,
                Name = "ddd"
            };
            //UserModel um5 = new UserModel()
            //{
            //    ID = 5,
            //    Name = "eee"
            //};
            list.Add(um);
            list.Add(um2);
            list.Add(um3);
            list.Add(um4);
            //list.Add(um5);
            s = Newtonsoft.Json.JsonConvert.SerializeObject(list);
            return s;
        }
    }
}