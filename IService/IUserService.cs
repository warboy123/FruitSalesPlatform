using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DTO;
namespace IService
{
    public interface IUserService 
    {
        bool Add(UserDTO user);
        IEnumerable<UserDTO> GetList();
        void Update(UserDTO user);
        //bool Remove(Func<T_User,bool>condition);
    }
}