using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Bank
{
    /// <summary>
    /// A test class for ...
    /// </summary>
    [TestFixture]
    public class AccountTest
    {
        Account source;
        Account destination;

        [SetUp]
        public void Init()
        {
            source = new Account();
            source.Deposit(200m);

            destination = new Account();
            destination.Deposit(150m);
        }

        [Test]
        public void TransferFunds()
        {
            // Step 1 - Arrange
            //(Now in [Setup])
            
            // Step 2 - Act
            source.TransferFunds(destination, 100m);

            // Step 3 - Assert  
            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
        }

        [Test]
        [ExpectedException(typeof(InsufficientFundsException))]
        public void TransferWithInsufficientFunds()
        {
            source.TransferFunds(destination, 300m);
        }

        [Test]
        // [Ignore("Decide how to implement transaction management")]
        public void TransferWithInsufficientFundsAtomicity()
        { 
            try
            {
                source.TransferFunds(destination, 300m);
            }
            catch (InsufficientFundsException)
            { 
            }

            Assert.AreEqual(200m, source.Balance);
            Assert.AreEqual(150m, destination.Balance);
        }
    }
}
