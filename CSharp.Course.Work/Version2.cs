using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work
{
    [TestFixture]
    public class Version2
    {
        [SetUp]
        public void SetUp()
        {
            Setup.Results.Add(TestContext.CurrentContext.Result);
        }


        /// <summary>
        /// <see href="https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/generics/generic-methods">More here</see>
        /// </summary>
        [Test]
        public void GenericMethod()
        {
            //Assert.Ignore();

            var a = VersionTwo.GenericMethod.Result<VersionTwo.GenericMethodClassA>();
            var b = VersionTwo.GenericMethod.Result<VersionTwo.GenericMethodClassB>();

            Assert.AreEqual("A", a.Result());
            Assert.AreEqual("B", b.Result());
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/generics/generic-classes
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/generics/generic-interfaces
        /// </summary>
        [Test]
        public async Task GenericType()
        {
            //Assert.Ignore();

            var handler = new VersionTwo.GenericHandlerAsync<string>();
            var result = await handler.HandleAsync(new VersionTwo.Request
            {
                Page = 1,
                PageSize = 20
            });

            Assert.AreEqual(1, result.Page);
            Assert.AreEqual(20, result.PageSize);
            Assert.IsTrue(result.Results is List<string>);
        }

        [Test]
        public void PartialTypes()
        {
            Assert.Ignore();
        }

        [Test]
        public void AnonymousMethods()
        {
            Assert.Ignore();
        }

        [Test]
        public void Iterators()
        {
            Assert.Ignore();
        }

        [Test]
        public void NullableTypes()
        {
            Assert.Ignore();
        }

        [Test]
        public void GetterSetterSeparateAccessibility()
        {
            Assert.Ignore();
        }

        [Test]
        public void MethodGroupConversions()
        {
            Assert.Ignore();
        }

        [Test]
        public void StaticClasses()
        {
            Assert.Ignore();
        }
    }
}
