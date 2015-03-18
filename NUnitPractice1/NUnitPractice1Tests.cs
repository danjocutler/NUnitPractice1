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
        #region Setup and Tear down
        /// <summary>
        /// This runs only once at the beginning of all tests and is used for all tests in the 
        /// class.
        /// </summary>
        [TestFixtureSetUp]
        public void InitialSetup()
        {

        }

        /// <summary>
        /// This runs only once at the end of all tests and is used for all tests in the class.
        /// </summary>
        [TestFixtureTearDown]
        public void FinalTearDown()
        {

        }

        /// <summary>
        /// This setup funcitons runs before each test method
        /// </summary>
        [SetUp]
        public void SetupForEachTest()
        {
        }

        /// <summary>
        /// This setup funcitons runs after each test method
        /// </summary>
        [TearDown]
        public void TearDownForEachTest()
        {
        }
        #endregion

        [Test]
        public void TransferFunds()
        {
            // Step 1 - Arrange
            Account source = new Account();
            source.Deposit(200m);

            // Step 2 - Act
            Account destination = new Account();
            destination.Deposit(150m);

            source.TransferFunds(destination, 100m);

            // Step 3 - Assert  
            Assert.AreEqual(250m, destination.Balance);
            Assert.AreEqual(100m, source.Balance);
        }
    }
}
