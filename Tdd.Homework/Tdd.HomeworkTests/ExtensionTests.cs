using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tdd.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tdd.Homework.ViewModels;
using FluentAssertions;

namespace Tdd.Homework.Tests
{
    [TestClass()]
    public class ExtensionTests
    {
        [TestMethod()]
        public void GroupSumTest_SumCost_GroupIn3()
        {
            //Arrange
            var products = this.GenerateProduct();

            //Act
            var actual = products.GroupSum(3, c => c.Cost).ToList();
            var expect = new List<int>() { 6, 15, 24, 21 };

            //Assert
            CollectionAssert.AreEqual(expect, actual);            
        }

        [TestMethod()]
        public void GroupSumTest_SumRevenue_GroupIn4()
        {
            //Arrange
            var products = this.GenerateProduct();

            //Act
            var actual = products.GroupSum(4, c => c.Revenue).ToList();
            var expect = new List<int>() { 50, 66, 60 };

            //Assert
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod()]        
        public void GroupSumTest_群組個數Exception()
        {
            //Arrange
            var products = this.GenerateProduct();

            //Act
            Action actual = () => products.GroupSum(0, c => c.Revenue).ToList();
            actual.ShouldThrow<ArgumentException>();            
        }

        [TestMethod()]
        public void GroupSumTest_集合個數Exception()
        {
            //Arrange
            var products = new List<Product>();

            //Act
            Action actual = () => products.GroupSum(3, c => c.Revenue).ToList();
            actual.ShouldThrow<ArgumentException>();
        }        

        /// <summary>
        /// 產生假資料
        /// </summary>
        /// <returns></returns>
        private List<Product> GenerateProduct()
        {
            var ls = new List<Product>();
            ls.Add(new Product()
            {
                Id = "1",
                Cost = 1,
                Revenue = 11,
                SellPrice = 21
            });

            ls.Add(new Product()
            {
                Id = "2",
                Cost = 2,
                Revenue = 12,
                SellPrice = 22
            });

            ls.Add(new Product()
            {
                Id = "3",
                Cost = 3,
                Revenue = 13,
                SellPrice = 23
            });

            ls.Add(new Product()
            {
                Id = "4",
                Cost = 4,
                Revenue = 14,
                SellPrice = 24
            });

            ls.Add(new Product()
            {
                Id = "5",
                Cost = 5,
                Revenue = 15,
                SellPrice = 25
            });

            ls.Add(new Product()
            {
                Id = "6",
                Cost = 6,
                Revenue = 16,
                SellPrice = 26
            });

            ls.Add(new Product()
            {
                Id = "7",
                Cost = 7,
                Revenue = 17,
                SellPrice = 27
            });

            ls.Add(new Product()
            {
                Id = "8",
                Cost = 8,
                Revenue = 18,
                SellPrice = 28
            });

            ls.Add(new Product()
            {
                Id = "9",
                Cost = 9,
                Revenue = 19,
                SellPrice = 29
            });

            ls.Add(new Product()
            {
                Id = "10",
                Cost = 10,
                Revenue = 20,
                SellPrice = 30
            });

            ls.Add(new Product()
            {
                Id = "11",
                Cost = 11,
                Revenue = 21,
                SellPrice = 31
            });

            return ls;
        }
    }
}