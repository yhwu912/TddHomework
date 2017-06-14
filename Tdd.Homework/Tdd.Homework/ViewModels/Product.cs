using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd.Homework.ViewModels
{
    /// <summary>
    /// 商品資料
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 商品編號
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// 成本
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// 收益
        /// </summary>
        public int Revenue { get; set; }

        /// <summary>
        /// 售價
        /// </summary>
        public int SellPrice { get; set; }
    }
}
