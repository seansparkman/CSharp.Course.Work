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

        [Test]
        public void NamedAndOptionalParameters()
        {
            Assert.Ignore();
        }

        [Test]
        public void GenericCovariance()
        {
            Assert.Ignore();
        }

        [Test]
        public void GenericContravariance()
        {
            Assert.Ignore();
        }

        [Test]
        public void EmbeddedInteropTypes()
        {
            Assert.Ignore();
        }
    }
}
