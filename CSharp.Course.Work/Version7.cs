using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work
{
    [TestFixture]
    public class Version7
    {
        [SetUp]
        public void SetUp()
        {
            Setup.Results.Add(TestContext.CurrentContext.Result);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/whats-new/csharp-7#local-functions
        /// </summary>
        [Test]
        public async Task LocalFunctions()
        {
            // Assert.Ignore();
            
            Assert.AreEqual(42, VersionSeven.LocalFunctions.SquareFeet(6, 7));
            Assert.AreEqual(42, await VersionSeven.LocalFunctions.DoSomething());
        }

        [Test]
        public void TypeSwitch()
        {
            Assert.Ignore();
        }

        [Test]
        public void RefReturns()
        {
            Assert.Ignore();
        }

        [Test]
        public void NamedTuples()
        {
            Assert.Ignore();
        }

        [Test]
        public void OutVar()
        {
            Assert.Ignore();
        }

        [Test]
        public void ArbitraryAsyncReturns()
        {
            Assert.Ignore();
        }

        [Test]
        public void ExpressionBodiedGettersAndSetters()
        {
            Assert.Ignore();
        }

        [Test]
        public void ExpressionBodiedConstructorsAndFinalizers()
        {
            Assert.Ignore();
        }
    }
}
