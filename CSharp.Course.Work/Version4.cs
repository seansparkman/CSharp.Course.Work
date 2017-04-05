using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work
{
    [TestFixture]
    public class Version4
    {
        [SetUp]
        public void SetUp()
        {
            Setup.Results.Add(TestContext.CurrentContext.Result);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/types/walkthrough-creating-and-using-dynamic-objects
        /// </summary>
        [Test]
        public void DynamicBinding()
        {
            // Assert.Ignore();

            dynamic obj = new ExpandoObject();
            obj.StringProperty = "This is a string";
            obj.IntProperty = 42;
            obj.ObjectProperty = new ExpandoObject();
            obj.ObjectProperty.AnotherProperty = "Yes, another property";

            Assert.AreEqual("This is a string", obj.StringProperty);
            Assert.AreEqual(42, obj.IntProperty);
            Assert.IsNotNull(obj.ObjectProperty);
            Assert.AreEqual("Yes, another property", obj.ObjectProperty.AnotherProperty);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
        /// </summary>
        [Test]
        public void NamedParameters()
        {
            // Assert.Ignore();

            Assert.AreEqual(42, VersionFour.NamedAndOptionalParameters.SquareFeet(6, 7));
            Assert.AreEqual(42, VersionFour.NamedAndOptionalParameters.SquareFeet(height: 6, width: 7));
            Assert.AreEqual(42, VersionFour.NamedAndOptionalParameters.SquareFeet(width: 7, height: 6));
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/named-and-optional-arguments
        /// </summary>
        [Test]
        public void OptionalParameters()
        {
            // Assert.Ignore();

            var spams = VersionFour.NamedAndOptionalParameters.Repeat("Spam", 30);

            Assert.AreEqual(29 + 30 * 4, spams.Length);

            spams = VersionFour.NamedAndOptionalParameters.Repeat("Spam");

            Assert.AreEqual(1 + 2 * 4, spams.Length);
        }
    }
}
