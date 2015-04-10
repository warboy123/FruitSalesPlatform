using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IService;
using Entities;
using DTO;
using Mvc.App_Start;
namespace Mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        IUserService IUser;
        public HomeController(IUserService User)
        {
            IUser = User;
        }
        [MvcActionFilterAttribute(IsCheck = false)]
        public ActionResult Index()
        {
            IList<UserDTO> userList= IUser.GetList().ToList();
            if (!userList.Any())
            {
                IUser.Add(new UserDTO { UserName = "张三"});
            }
            else
            {
                IUser.Update(userList.First());
            }
            return View();
        }
        
    }
}
