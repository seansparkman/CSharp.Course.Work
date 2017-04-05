using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work
{
    [TestFixture]
    public class Version5
    {
        [SetUp]
        public void SetUp()
        {
            Setup.Results.Add(TestContext.CurrentContext.Result);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/async
        /// </summary>
        /// <returns></returns>
        [Test]
        public async Task AsynchronousMethods()
        {
            // Assert.Ignore();

            await VersionFive.AsynchronousMethods.AsyncMethod();
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/concepts/caller-information
        /// </summary>
        [Test]
        public void CallerInfoAttribute()
        {
            // Assert.Ignore();

            var callerInfo = VersionFive.CallInfoAttributes.CallInfo();

            Assert.AreEqual("CallerInfoAttribute", callerInfo.CallerMemberName);
            Assert.Less(0, callerInfo.CallerLineNumber);
        }
    }
}
