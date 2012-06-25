using TemplateTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTest
{
    
    
    /// <summary>
    ///This is a test class for RegularDBTest and is intended
    ///to contain all RegularDBTest Unit Tests
    ///</summary>
    [TestClass()]
    public class RegularDBTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for RegularDB Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemplateTask.exe")]
        public void RegularDBConstructorTest()
        {
            RegularDB_Accessor target = new RegularDB_Accessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for createArray
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemplateTask.exe")]
        public void createArrayTest()
        {
            RegularDB_Accessor target = new RegularDB_Accessor(); // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = target.createArray();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for getInstance
        ///</summary>
        [TestMethod()]
        public void getInstanceTest()
        {
            RegularDB expected = null; // TODO: Initialize to an appropriate value
            RegularDB actual;
            actual = RegularDB.getInstance();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
