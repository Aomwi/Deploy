using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace ConsoleApplication1
{ 
    [TestFixture]
    class Test
    {
        [Test]

        public void TestUnit()
        {
            Assert.AreEqual('b', Program.Evaluate(60));
        }
    }

    [TestFixture]
    public class AccountTest
    {
        [Test]
        public void TransferFunds()
        {
            Account source = new Account();
            source.Deposit(200.00F);
            Account destination = new Account();
            destination.Deposit(150.00F);

            source.TransferFunds(destination, 100.00F);
            Assert.AreEqual(250.00F, destination.Balance);
            Assert.AreEqual(100.00F, source.Balance);

        }
    }
    //git add temp/
    //git status
    //git comit -m "new temporary file"
    //git push


}
