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
        
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
        /// </summary>
        [Test]
        public void ObjectInitializers()
        {
            // Assert.Ignore();

            var obj = new VersionThree.ObjectInitializer
            {
                StringProperty = "This is a string",
                IntProperty = 42,
                ObjectProperty = new VersionThree.ObjectInitializer2
                {
                    AnotherProperty = "Yes, another property"
                }
            };

            Assert.AreEqual("This is a string", obj.StringProperty);
            Assert.AreEqual(42, obj.IntProperty);
            Assert.IsNotNull(obj.ObjectProperty);
            Assert.AreEqual("Yes, another property", obj.ObjectProperty.AnotherProperty);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        /// </summary>
        [Test]
        public void CollectionInitializers()
        {
            // Assert.Ignore();

            List<int> listOfInt = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            CollectionAssert.IsNotEmpty(listOfInt);
            Assert.IsTrue(listOfInt.Contains(1));
            Assert.IsTrue(listOfInt.Contains(5));
            Assert.IsTrue(listOfInt.Contains(10));
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
