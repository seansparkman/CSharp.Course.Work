using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work
{
    [TestFixture]
    public class Version3
    {
        [Test]
        public void ImplicitlyTypedLocalVariables()
        {
            // Assert.Ignore();

            int int1 = 1;
            var var1 = 1;

            // var is not a variant but implicitly typed
            // uncomplete to see compiler error
            // var1 = 1d;

            Assert.AreEqual(int1, var1);
            Assert.AreEqual(int1.GetType(), var1.GetType());
        }

        [Test]
        public void ObjectAndCollectionInitializers()
        {
            Assert.Ignore();
        }

        [Test]
        public void AutoImplementedProperties()
        {
            Assert.Ignore();
        }

        [Test]
        public void AnonymousTypes()
        {
            Assert.Ignore();
        }

        [Test]
        public void ExtensionMethods()
        {
            Assert.Ignore();
        }

        [Test]
        public void QueryExpressions()
        {
            Assert.Ignore();
        }

        [Test]
        public void LambdaExpressions()
        {
            Assert.Ignore();
        }

        [Test]
        public void ExpressionTrees()
        {
            Assert.Ignore();
        }

        [Test]
        public void PartialMethods()
        {
            Assert.Ignore();
        }

    }
}
