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


        [Test]
        public void GenericMethod()
        {
            Assert.Ignore();
        }

        [Test]
        public void GenericClass()
        {
            Assert.Ignore();
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
