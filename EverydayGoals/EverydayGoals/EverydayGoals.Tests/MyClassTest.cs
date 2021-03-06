// <copyright file="MyClassTest.cs">joe</copyright>
using System;
using EverydayGoals;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EverydayGoals.Tests
{
    /// <summary>This class contains parameterized unit tests for MyClass</summary>
    [PexClass(typeof(Account))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class MyClassTest
    {
        /// <summary>Test stub for testme()</summary>
        [PexMethod]
        public string testmeTest([PexAssumeUnderTest]Account target)
        {
            string result = target.testme();
            return result;
            // TODO: add assertions to method MyClassTest.testmeTest(MyClass)
        }
    }
}
