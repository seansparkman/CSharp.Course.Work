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

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/partial-type
        /// </summary>
        [Test]
        public void PartialTypes()
        {
            // Assert.Ignore();

            var partialClass = new VersionTwo.PartialClass();

            Assert.AreEqual("Partial Class 2", partialClass.FirstClass());
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/delegates/index
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/statements-expressions-operators/anonymous-methods
        /// </summary>
        [Test]
        public void AnonymousMethods()
        {
            // Assert.Ignore();

            var anonymousMethods = new VersionTwo.AnonymousMethods();

            var didWork = false;
            anonymousMethods.Worked += delegate (object sender, EventArgs args) { didWork = true; };

            Assert.False(didWork);

            anonymousMethods.OnWorked(new EventArgs());
            Assert.True(didWork);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/concepts/iterators
        /// </summary>
        [Test]
        public void Iterators()
        {
            // Assert.Ignore();
            var iterator = new VersionTwo.Iterators();

            Assert.AreEqual(0, iterator.Iterations);
            foreach(var item in iterator.GetEnumerator())
            {
                if (iterator.Iterations == 1)
                {
                    Assert.AreEqual(3, item);
                }
                else if (iterator.Iterations == 2)
                {
                    Assert.AreEqual(5, item);
                }
                else if (iterator.Iterations == 3)
                {
                    Assert.AreEqual(7, item);
                }
            }
            Assert.AreEqual(4, iterator.Iterations);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/nullable-types/
        /// </summary>
        [Test]
        public void NullableTypes()
        {
            // Assert.Ignore();
            DateTime? nullableDateTime = null;
            Assert.False(nullableDateTime.HasValue);


            DateTime nonnullableDateTime = DateTime.UtcNow;
            Assert.AreNotEqual(nonnullableDateTime, nullableDateTime);

            nullableDateTime = nonnullableDateTime;
            Assert.True(nullableDateTime.HasValue);
            Assert.AreEqual(nonnullableDateTime, nullableDateTime);
            Assert.True(nonnullableDateTime == nullableDateTime);            
        }

        [Test]
        public void GetterSetterSeparateAccessibility()
        {
            // Assert.Ignore();
            var accessibility = new VersionTwo.GetterSetterSeparateAccessibility();
            accessibility.Value2 = 2;

            Assert.AreEqual(1, accessibility.Value1);
            Assert.AreEqual(2, accessibility.GetValue2());
        }

        [Test]
        public void MethodGroupConversions()
        {
            // Assert.Ignore();
            var methodGroup = new VersionTwo.MethodGroupConversions
            {
                Value = "original"
            };

            methodGroup.DoSomething(methodGroup.Work);

            Assert.AreEqual("original did work", methodGroup.Value);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/static-classes-and-static-class-members
        /// </summary>
        [Test]
        public void StaticClasses()
        {
            // Assert.Ignore();

            // uncomment this to see the compiler error
            // var staticClass = new VersionTwo.StaticClass();

            Assert.IsTrue(VersionTwo.StaticClass.GetSuccess());
        }
    }
}
