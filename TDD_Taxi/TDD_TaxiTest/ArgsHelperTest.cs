using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TDD_Taxi;

namespace TDD_TaxiTest
{
    [TestFixture]
    public class ArgsHelperTest
    {
        [Test]
        public void GetArgsTest()
        {
            ArgsHelper fileHelper = new ArgsHelper();
            Assert.AreEqual(new int[] { 1, 0 }, fileHelper.GetArgs("1公里,等待0分钟\n"));
        }
    }
}
