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

        [Test]
        public void CallerInfoAttribute()
        {
            Assert.Ignore();
        }
    }
}
