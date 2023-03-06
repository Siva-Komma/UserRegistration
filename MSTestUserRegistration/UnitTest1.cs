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
        [TestMethod]
        [TestCategory("LastName")]
        [DataRow(new string[] { "Komma", "Karthik", "HelloWorld" }, true)]
        [DataRow(new string[] { "venky", "Hello World" }, false)]
        public void LastNameTestCases(string[] arr, bool expected)
        {
            UserRegistrationMSTesting userDetails = new UserRegistrationMSTesting();
            foreach (string s in arr)
            {
                bool actual = userDetails.LastNameTestcase(s);
                Assert.AreEqual(actual, expected);
            }
        }
        [TestMethod]
        [TestCategory("Email testcase")]
        [DataRow(new string[] { "abc.xyz@bl.co.in", "Sivakomma@gmail.com" }, true)]
        [DataRow(new string[] { "siva@.com", "Komma123gmail.com" }, false)]
        public void UserEanil(string[] arr, bool expected)
        {
            UserRegistrationMSTesting userDetails = new UserRegistrationMSTesting();
            foreach (string s in arr)
            {
                bool actual = userDetails.EmailValidation(s);
                Assert.AreEqual(actual, expected);
            }
        }
    }
}
