using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharp.Course.Work.VersionThree;
using System.Linq.Expressions;

namespace CSharp.Course.Work
{
    [TestFixture]
    public class Version3
    {
        [SetUp]
        public void SetUp()
        {
            Setup.Results.Add(TestContext.CurrentContext.Result);
        }

        [Test]
        public void ImplicitlyTypedLocalVariables()
        {
            Assert.Ignore();

            int int1 = 1;
            var var1 = 1;

            // var is not a variant but implicitly typed
            // uncomplete to see compiler error
            // var1 = 1d;

            // TODO: Uncomment the following lines
            //Assert.AreEqual(int1, var1);
            //Assert.AreEqual(int1.GetType(), var1.GetType());
        }
        
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
        /// </summary>
        [Test]
        public void ObjectInitializers()
        {
            Assert.Ignore();

            // TODO: Initialize VersionThree.ObjectInitializer with the following properties and assign to var obj
            // StringProperty = "This is a string"
            // IntProperty = 42
            // ObjectProperty assign new VersionThree.ObjectInitializer2
            // Add property ObjectProperty of AnotherProperty = "Yes, another property"

            // TODO: Uncomment the following lines
            //Assert.AreEqual("This is a string", obj.StringProperty);
            //Assert.AreEqual(42, obj.IntProperty);
            //Assert.IsNotNull(obj.ObjectProperty);
            //Assert.AreEqual("Yes, another property", obj.ObjectProperty.AnotherProperty);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/object-and-collection-initializers
        /// </summary>
        [Test]
        public void CollectionInitializers()
        {
            Assert.Ignore();

            // TODO: Initialize listOfInt as List<int> with 1 - 10 values
            List<int> listOfInt = null;

            CollectionAssert.IsNotEmpty(listOfInt);
            Assert.IsTrue(listOfInt.Contains(1));
            Assert.IsTrue(listOfInt.Contains(5));
            Assert.IsTrue(listOfInt.Contains(10));
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/auto-implemented-properties
        /// </summary>
        [Test]
        public void AutoImplementedProperties()
        {
            Assert.Ignore();

            // TODO: Uncomment the following lines of code
            //var autoImplementedProperties = new VersionThree.AutoImplementedProperties
            //{
            //    IntProperty = 42,
            //    StringProperty = "This is a string"
            //};

            //Assert.AreEqual("This is a string", autoImplementedProperties.StringProperty);
            //Assert.AreEqual(42, autoImplementedProperties.IntProperty);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/anonymous-types
        /// </summary>
        [Test]
        public void AnonymousTypes()
        {
            Assert.Ignore();

            // TODO: Implement anonymous type with the following properties and assign to var obj
            // StringProperty = "This is a string"
            // IntProperty = 42
            // ObjectProperty assign new anonymous type
            // Add property ObjectProperty of AnotherProperty = "Yes, another property"
            
            // uncomment to show compiler error
            // obj.StringProperty = "This isn't a string";

            // TODO: Uncomment the following tests
            //Assert.AreEqual("This is a string", obj.StringProperty);
            //Assert.AreEqual(42, obj.IntProperty);
            //Assert.IsNotNull(obj.ObjectProperty);
            //Assert.AreEqual("Yes, another property", obj.ObjectProperty.AnotherProperty);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/extension-methods
        /// </summary>
        [Test]
        public void ExtensionMethods()
        {
            Assert.Ignore();

            var text = @"Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum.";
            
            // TODO: add using CSharp.Course.Work.VersionThree; to class file
            // TODO: Uncomment the following lines
            // Assert.AreEqual(91, text.WordCount());
        }

        delegate int del(List<int> listOfInts, int x);
        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/statements-expressions-operators/lambda-expressions
        /// </summary>
        [Test]
        public void LambdaExpressions()
        {
            Assert.Ignore();

            // TODO: Implement a lambda expression that returns the IndexOf x and
            // assign to del indexOf

            // TODO: Uncomment the following lines
            //var index = indexOf(new List<int> { 1, 2, 3 }, 2);

            //Assert.AreEqual(1, index);
        }

        delegate Task AsyncLambdaExpression(int i);
        [Test]
        public async Task AsyncLambdaExpressions()
        {
            Assert.Ignore();

            // TODO: uncomment the following lines
            //AsyncLambdaExpression asyncLambda = async (int i) => { await Task.Delay(1); };

            //await asyncLambda(1);

            Assert.Pass();
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/expression-trees-explained
        /// </summary>
        [Test]
        public void ExpressionTrees()
        {
            Assert.Ignore();

            // TODO: Uncomment the following lines
            //Expression<Func<int>> add = () => 1 + 2;
            //var func = add.Compile();
            //var results = func();

            //Assert.AreEqual(3, results);

            //Expression<Func<int, int, bool>> greaterThan = (x, y) => x > y;
            //var funcGreaterThan = greaterThan.Compile();

            //Assert.IsTrue(funcGreaterThan(2, 1));
            //Assert.IsFalse(funcGreaterThan(1, 2));
        }

        [Test]
        public void PartialMethods()
        {
            Assert.Ignore();

            var partialMethod = new PartialMethodClass();
            partialMethod.Load(42);

            Assert.AreEqual(42, partialMethod.Value);
        }

    }
}
