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
            Assert.Ignore();
        }

        [Test]
        public void DefaultValuesForGetterOnlyProperties()
        {
            Assert.Ignore();
        }

        [Test]
        public void ExpressionBodiedMembers()
        {
            Assert.Ignore();
        }

        [Test]
        public void NullPropagator()
        {
            Assert.Ignore();
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
