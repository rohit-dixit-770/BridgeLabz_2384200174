using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_4_Assignment_5and6_Testing;

namespace testUnit
{
    internal class DatabaseConnectionTest
    {
        private DatabaseConnection dbConnection;

        [SetUp]
        public void SetUp()
        {
            dbConnection = new DatabaseConnection();
            dbConnection.Connect();
        }

        [TearDown]
        public void TearDown()
        {
            dbConnection.Disconnect();
        }

        [Test]
        public void Test_Connection_Is_Established()
        {
            Assert.IsTrue(dbConnection.IsConnected);
        }

        [Test]
        public void Test_Connection_Is_Closed_After_TearDown()
        {
            TearDown();
            Assert.IsFalse(dbConnection.IsConnected);
        }
    }
}
