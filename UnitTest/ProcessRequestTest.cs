using TemplateTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace UnitTest
{
    
    
    /// <summary>
    ///This is a test class for ProcessRequestTest and is intended
    ///to contain all ProcessRequestTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProcessRequestTest
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
        ///A test for ProcessRequest Constructor
        ///</summary>
        [TestMethod()]
        public void ProcessRequestConstructorTest()
        {
            ProcessRequest target = new ProcessRequest();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for equals
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemplateTask.exe")]
        public void equalsTest()
        {
            ProcessRequest_Accessor target = new ProcessRequest_Accessor(); // TODO: Initialize to an appropriate value
            target.equals();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for request
        ///</summary>
        [TestMethod()]
        public void requestTest()
        {
            ProcessRequest target = new ProcessRequest(); // TODO: Initialize to an appropriate value
            string s = string.Empty; // TODO: Initialize to an appropriate value
            target.request(s);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for response
        ///</summary>
        [TestMethod()]
        public void responseTest()
        {
            ProcessRequest target = new ProcessRequest(); // TODO: Initialize to an appropriate value
            List<Match> expected = null; // TODO: Initialize to an appropriate value
            List<Match> actual;
            actual = target.response();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
