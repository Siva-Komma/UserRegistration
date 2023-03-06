using System;
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
        [TestMethod]
        [TestCategory("Mobile testcase")]
        [DataRow(new string[] { "91 9381656750" }, true)]
        [DataRow(new string[] { "919381656750", "91 0938165675", "81 938165675" }, false)]
        public void UserPhoneNumber(string[] arr, bool expected)
        {
            UserRegistrationMSTesting userDetails = new UserRegistrationMSTesting();
            foreach (string s in arr)
            {
                bool actual = userDetails.MobileValidation(s);
                Assert.AreEqual(actual, expected);
            }
        }
        [TestMethod]
        [TestCategory("Password Rule1 testcase")]
        [DataRow(new string[] { "Siv@329612", "siva@123" }, true)]
        [DataRow(new string[] { "Siva@12", "siva123" }, false)]
        public void PasswordRule1(string[] arr, bool expected)
        {
            UserRegistrationMSTesting userDetails = new UserRegistrationMSTesting();
            foreach (string s in arr)
            {
                bool actual = userDetails.PasswordMinimumlength(s);
                Assert.AreEqual(actual, expected);
            }
        }
    }

}

