using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace InputOXinEmpty
{
    [TestFixture]
    class Test
    {
        [Test]

        public void TestInput() 
        {
            Assert.AreEqual('O', Input.Evaluate("A"));
            
        }
    }
}
