using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Common;
using AutoMapper;
namespace Service
{
    public class ServiceBase
    {
        public static Expression<Func<TSource, TResult>> GetMappedSelector<TSource, TResult>()
        {
            Expression<Func<TSource, TResult>> mapperExpression = AutoMapper.QueryableExtensions.Extensions.CreateMapExpression<TSource, TResult>(Mapper.Engine);
            //Expression<Func<UserDTO,T_User >> mappedSelector = selector.Compose(mapper);
            return mapperExpression;
        }
        public static Expression<Func<TEntity, bool>> GetMappedCondition<TEntity, TDTO>(Expression<Func<TDTO, bool>> condition)
        {
            Expression<Func<TEntity, TDTO>> mapper = AutoMapper.QueryableExtensions.Extensions.CreateMapExpression<TEntity, TDTO>(Mapper.Engine);
            Expression<Func<TEntity, bool>> mappedSelector = condition.Compose(mapper);
            return mappedSelector;
        }
    }
}
