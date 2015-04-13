using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DTO;
namespace Mvc
{
    public class HomeModel
    {
        public IList<UserDTO> UserList { get; set; }
    }
}