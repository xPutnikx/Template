﻿using TemplateTask;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace UnitTest
{
    
    
    /// <summary>
    ///This is a test class for DummyTemplateTest and is intended
    ///to contain all DummyTemplateTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DummyTemplateTest
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
        ///A test for DummyTemplate Constructor
        ///</summary>
        [TestMethod()]
        public void DummyTemplateConstructorTest()
        {
            DummyTemplate target = new DummyTemplate();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DummyTemplate Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemplateTask.exe")]
        public void DummyTemplateConstructorTest1()
        {
            string s = string.Empty; // TODO: Initialize to an appropriate value
            DummyTemplate_Accessor target = new DummyTemplate_Accessor(s);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Main
        ///</summary>
        [TestMethod()]
        [DeploymentItem("TemplateTask.exe")]
        public void MainTest()
        {
            string[] args = null; // TODO: Initialize to an appropriate value
            DummyTemplate_Accessor.Main(args);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Render
        ///</summary>
        [TestMethod()]
        public void RenderTest()
        {
            DummyTemplate target = new DummyTemplate(); // TODO: Initialize to an appropriate value
            StringBuilder output = null; // TODO: Initialize to an appropriate value
            target.Render(output);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
