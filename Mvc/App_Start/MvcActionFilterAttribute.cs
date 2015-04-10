using IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mvc.App_Start
{
    public  class MvcActionFilterAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        public bool IsCheck { get; set; }
        IUserService IUser;
        public MvcActionFilterAttribute(IUserService User)
        {
            IsCheck = true;
            IUser = User;
        }
        public MvcActionFilterAttribute()
        { }
        public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (IsCheck)
            {
                IUser.GetList();
            }
        }
    }
}