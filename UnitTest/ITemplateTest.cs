using TemplateTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace UnitTest
{
    
    
    /// <summary>
    ///This is a test class for ITemplateTest and is intended
    ///to contain all ITemplateTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ITemplateTest
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


        internal virtual ITemplate CreateITemplate()
        {
            // TODO: Instantiate an appropriate concrete class.
            ITemplate target = null;
            return target;
        }

        /// <summary>
        ///A test for Render
        ///</summary>
        [TestMethod()]
        public void RenderTest()
        {
            ITemplate target = CreateITemplate(); // TODO: Initialize to an appropriate value
            StringBuilder output = null; // TODO: Initialize to an appropriate value
            target.Render(output);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
