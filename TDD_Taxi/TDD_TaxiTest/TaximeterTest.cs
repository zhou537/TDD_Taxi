using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDD_Taxi;

namespace TaxiTest
{
    [TestFixture]
    public class TaximeterTest
    {
        [Test]
        public void GetCostTest1_0()
        {
            //不大于2公里，只收起步价6元
            Taximeter taximeter = new Taximeter();
            Assert.AreEqual(6, taximeter.GetCost(1, 0));
        }

        [Test]
        public void GetCostTest3_0()
        {
            //超过2公里的部分，每公里收取0.8元
            Taximeter taximeter = new Taximeter();
            Assert.AreEqual(7, taximeter.GetCost(3, 0));
        }

        [Test]
        public void GetCostTest10_0()
        {
            //超过8公里的部分，每公里加收50%长途费
            Taximeter taximeter = new Taximeter();
            Assert.AreEqual(13, taximeter.GetCost(10, 0));
        }

        [Test]
        public void GetCostTest2_3()
        {
            //停车等待时加收每分钟0.25元
            Taximeter taximeter = new Taximeter();
            Assert.AreEqual(7, taximeter.GetCost(2, 3));
        }
    }
}
