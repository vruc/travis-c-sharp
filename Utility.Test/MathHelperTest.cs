using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using MyUtiliy;

namespace Utility.Test
{
    [TestFixture]
    public class MathHelperTest
    {
        [Test]
        [TestCase(10,20)]
        public void Add_Test_1(int x, int y)
        {
            Assert.AreEqual(MathHelper.Add(x, y), x + y);
        }
    }
}
