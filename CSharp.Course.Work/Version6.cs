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
            // Assert.Ignore();

            try
            {
                throw new ArgumentException("Invalid argument", "args");
            }
            catch(ArgumentException e) when (e.ParamName == "args")
            {
                Assert.Pass();
            }
            catch(ArgumentException e) when (e.ParamName != "args")
            {
                Assert.Fail();
            }
        }

        [Test]
        public async Task AwaitInCatchFinallyBlocks()
        {
            // Assert.Ignore();

            Func<Task> awaitMe = async () => await Task.Delay(1);
            try
            {
                throw new Exception();
            }
            catch(Exception ex)
            {
                await awaitMe();
            }
            finally
            {
                await awaitMe();
            }

        }

        [Test]
        public void AutoPropertyInitializers()
        {
            // Assert.Ignore();

            var obj = new VersionSix.AutoPropertyInitializers();

            Assert.AreEqual("This is a string", obj.StringProperty);
            Assert.AreEqual(42, obj.IntProperty);
            Assert.IsNotNull(obj.ObjectProperty);
            Assert.AreEqual("Yes, another property", obj.ObjectProperty.AnotherProperty);
        }

        [Test]
        public void ExpressionBodiedMembers()
        {
            // Assert.Ignore();

            var obj = new VersionSix.ExpressionBodiedMembers();

            Assert.AreEqual("This is a string", obj.GetString());
            Assert.AreEqual(42, obj.SquareFeet(6, 7));
        }

        [Test]
        public void NullPropagator()
        {
            // Assert.Ignore();

            var obj = new VersionSix.NullPropagator();

            Assert.IsNull(obj?.StringProperty?.Length);
            Assert.AreEqual(0, obj?.StringProperty?.Length);
        }

        [Test]
        public void StringInterpolation()
        {
            Assert.Ignore();
        }

        [Test]
        public void NameofOperator()
        {
            Assert.Ignore();
        }

        [Test]
        public void DictionaryInitializer()
        {
            Assert.Ignore();
        }
    }
}
