﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationTestCases;

namespace MSTestUserRegistration
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [TestCategory("FirstName")]
        [DataRow(new string[] { "Siva", "Komma", "Sai" }, true)]
        [DataRow(new string[] { "sai", "siva", "Hi" }, false)]
        public void FirstNameTestCase(string[] arr, bool expected)
        {
            UserRegistrationMSTesting userDetails = new UserRegistrationMSTesting();
            foreach (string s in arr)
            {
                bool actual = userDetails.FirstNameTestcase(s);
                Assert.AreEqual(actual, expected);
            }
        }
    }
}
