using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work
{
    [TestFixture]
    public class Version6
    {
        [SetUp]
        public void SetUp()
        {
            Setup.Results.Add(TestContext.CurrentContext.Result);
        }

        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void ExceptionFilters()
        {
            Assert.Ignore();

            try
            {
                throw new ArgumentException("Invalid argument", "args");
            }
            // TODO: add exception filter with when of condition ParamName equal to "args"
            // and Assert.Pass in that catch block
            catch(ArgumentException e)
            {
                Assert.Fail();
            }
        }

        [Test]
        public async Task AwaitInCatchFinallyBlocks()
        {
            Assert.Ignore();

            Func<Task> awaitMe = async () => await Task.Delay(1);
            try
            {
                throw new Exception();
            }
            catch(Exception ex)
            {
                // TODO: await the awaitMe method
            }
            finally
            {
                // TODO: await the awaitMe method
            }

        }

        [Test]
        public void AutoPropertyInitializers()
        {
            Assert.Ignore();

            var obj = new VersionSix.AutoPropertyInitializers();

            Assert.AreEqual("This is a string", obj.StringProperty);
            Assert.AreEqual(42, obj.IntProperty);
            Assert.IsNotNull(obj.ObjectProperty);
            Assert.AreEqual("Yes, another property", obj.ObjectProperty.AnotherProperty);
        }

        [Test]
        public void ExpressionBodiedMembers()
        {
            Assert.Ignore();

            var obj = new VersionSix.ExpressionBodiedMembers();

            Assert.AreEqual("This is a string", obj.GetString());
            Assert.AreEqual(42, obj.SquareFeet(6, 7));
        }

        [Test]
        public void NullPropagator()
        {
            Assert.Ignore();

            var obj = new VersionSix.NullPropagator();

            // TODO: replace . operator with ?. 
            Assert.IsNull(obj.StringProperty.Length);
            // TODO: add  ?? 0 after Length after replacing . operator with ?.
            Assert.AreEqual(0, obj.StringProperty.Length);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/interpolated-strings
        /// </summary>
        [Test]
        public void StringInterpolation()
        {
            Assert.Ignore();

            var obj = new { StringProperty = "This is a string", IntProperty = 42, ObjectProperty = new { AnotherProperty = "Yes, another property" } };

            // TODO: use string interpolation to generate a string from the obj to match the assert
            // and assign it to the results variable
            var results = default(string);

            Assert.AreEqual("First: This is a string, 42, Second: Yes, another property", results);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/nameof
        /// </summary>
        [Test]
        public void NameofOperator()
        {
            Assert.Ignore();

            var obj = new VersionSix.NameofOperator();

            Assert.AreEqual("StringProperty", obj.StringProperty);
            Assert.AreEqual("IntProperty", obj.IntProperty);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/programming-guide/classes-and-structs/how-to-initialize-a-dictionary-with-a-collection-initializer
        /// </summary>
        [Test]
        public void DictionaryInitializer()
        {
            Assert.Ignore();

            // TODO: initialize dictionary with the following
            // 1 as "One"
            // 2 as "Two"
            // 3 as "Three"
            var dictionary = new Dictionary<int, string>();

            Assert.AreEqual("One", dictionary[1]);
            Assert.AreEqual("Two", dictionary[2]);
            Assert.AreEqual("Three", dictionary[3]);
        }
    }
}
