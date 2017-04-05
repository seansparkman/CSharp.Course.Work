using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work
{
    [TestFixture]
    public class Version7
    {
        [SetUp]
        public void SetUp()
        {
            Setup.Results.Add(TestContext.CurrentContext.Result);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/whats-new/csharp-7#local-functions
        /// </summary>
        [Test]
        public async Task LocalFunctions()
        {
            // Assert.Ignore();
            
            Assert.AreEqual(42, VersionSeven.LocalFunctions.SquareFeet(6, 7));
            Assert.AreEqual(42, await VersionSeven.LocalFunctions.DoSomething());
        }

        [Test]
        public void TypeSwitch()
        {
            // Assert.Ignore();

            var listOfObjs = new List<VersionSeven.TypeSwitchA>
            {
                new VersionSeven.TypeSwitchA(),
                new VersionSeven.TypeSwitchB(),
                new VersionSeven.TypeSwitchC(),
            };
            var listOfAnswers = new List<string>();

            foreach(var item in listOfObjs)
            {
                switch(item)
                {
                    case VersionSeven.TypeSwitchC c:
                        listOfAnswers.Add("C");
                        break;
                    case VersionSeven.TypeSwitchB b:
                        listOfAnswers.Add("B");
                        break;
                    case VersionSeven.TypeSwitchA a:
                        listOfAnswers.Add("A");
                        break;

                    // uncomment to see the compiler error

                    //case VersionSeven.TypeSwitchB b:
                    //    listOfAnswers.Add("B");
                    //    break;
                }
            }

            Assert.AreEqual("A", listOfAnswers[0]);
            Assert.AreEqual("B", listOfAnswers[1]);
            Assert.AreEqual("C", listOfAnswers[2]);
        }

        [Test]
        public void RefReturns()
        {
            Assert.Ignore();
        }

        [Test]
        public void NamedTuples()
        {
            Assert.Ignore();
        }

        [Test]
        public void OutVar()
        {
            Assert.Ignore();
        }

        [Test]
        public void ArbitraryAsyncReturns()
        {
            Assert.Ignore();
        }

        [Test]
        public void ExpressionBodiedGettersAndSetters()
        {
            Assert.Ignore();
        }

        [Test]
        public void ExpressionBodiedConstructorsAndFinalizers()
        {
            Assert.Ignore();
        }
    }
}
