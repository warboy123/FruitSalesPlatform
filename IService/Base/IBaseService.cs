using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IService
{
    public interface IBaseService<T>where T:class
    {


        T Get(Expression<Func<T, bool>> exp);


        IEnumerable<T> GetList<T1>()where T1:class;


        IEnumerable<T> GetAll();
        
    }
}
