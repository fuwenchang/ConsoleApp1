using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Bayantu.Extensions.DomainDrivenDesign;

namespace Bayantu.Evos.Services.Match.Domain.SeedWork
{
    public class EnumerationExtend<TEntity> : Enumeration where TEntity : Enumeration
    {
        public EnumerationExtend(string code, string codeName) : base(code, codeName)
        {

        }

        /// <summary>
        /// 覆盖基类的方法，通过枚举值找到对应枚举
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static TEntity FromValue(string value)
        {
            return TryParse(item => item.Code == value);
        }

        /// <summary>
        /// 获取对应的枚举对象，如果没有则返回默认对象
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        private static TEntity TryParse(Func<TEntity, bool> predicate)
        {
            var allList = GetAll<TEntity>();
            var enumerable = allList as TEntity[] ?? allList.ToArray();
            TEntity obj = enumerable.FirstOrDefault(predicate);
            if (obj == null)
            {
                return enumerable.FirstOrDefault();
            }
            return obj;
        }

        /// <summary>
        /// 是否存在
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="code"></param>
        /// <returns></returns>
        public static bool IsExist(string code)
        {
            var allList = GetAll<TEntity>();
            if (allList != null && allList.Any(_ => _.Code == code))
            {
                return true;
            }
            return false;
        }

        public static IEnumerable<TEntity> GetAll()
        {
            return typeof(TEntity).GetFields(BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.Public).Select(f => f.GetValue(null)).Cast<TEntity>();
        }
    }

    public class EnumerationExtend : Enumeration
    {
        public EnumerationExtend(string code, string codeName) : base(code, codeName)
        {

        }
    }
}
