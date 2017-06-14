using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd.Homework
{
    public static class Extension
    {
        /// <summary>
        /// 擴充方法分群加總
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ls"></param>
        /// <param name="groupLength">幾筆資料為一群組</param>
        /// <param name="lambda">欲計算的欄位</param>
        /// <returns></returns>
        public static IEnumerable<int> GroupSum<T>(this IEnumerable<T> ls, int groupLength, Func<T, int> lambda)
        {
            if (groupLength <= 0)
                throw new ArgumentException("每組個數不得小於等於0。");

            if (ls.Any() == false)
                throw new ArgumentException("輸入的物件集合長度必須大於0。");

            var temp = Math.Ceiling(ls.Count() / (double)groupLength);

            for(var i = 0; i < temp; i++)           
                yield return ls.Skip(i * groupLength).Take(groupLength).Sum(lambda);                     
        }
    }
}
