using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using XCare.DMS.Entity;
using XCare.DMS.Uploading.Data.Mock;

namespace XCare.DMS.Test
{
    [TestClass]
    public class MockTest
    {
        [TestMethod]
        public void TestFakeBryzxx()
        {
            var properties = typeof (YdhlYpyf).GetProperties(BindingFlags.Instance | BindingFlags.Public);
            var sb = new StringBuilder();
            foreach (var property in properties)
            {
                sb.AppendFormat("{0}=message.Ypyf.{1},", property.Name.ToUpper(), property.Name);
            }
            Console.WriteLine(sb.ToString().Trim(','));
        }

        [TestMethod]
        public void TestFakeBrzd()
        {
            //var properties = typeof (YdhlBrzd).GetProperties(BindingFlags.Instance | BindingFlags.Public);
            //var sb1 = new StringBuilder();
            //var sb2 = new StringBuilder();
            //foreach (var property in properties)
            //{
            //    sb1.Append(property.Name.ToUpper()).Append(",");
            //    sb2.AppendFormat("@{0},", property.Name.ToUpper());
            //}
            //Console.WriteLine(sb1.ToString().TrimEnd(','));
            //Console.WriteLine(sb2.ToString().TrimEnd(','));
        }

        [TestMethod]
        public void TestFakeJcbg()
        {
        }

        [TestMethod]
        public void TestFakeJybg()
        {
        }

        [TestMethod]
        public void TestFakeTwd()
        {
            var twds = YdhlTwdMock.Mock(long.MinValue);
            Console.WriteLine(twds);
        }

        [TestMethod]
        public void TestFakeJbxx()
        {
            var jbxxes = YdhlJbxxMock.Mock(20);
            Console.WriteLine(JsonConvert.SerializeObject(jbxxes));
        }
    }

    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Score { get; set; }
        public int Grade { get; set; }
        public bool Side { get; set; }
        public List<Book> Books { get; set; }
    }

    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}