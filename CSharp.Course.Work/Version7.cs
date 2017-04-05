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
            Assert.Ignore();
            
            Assert.AreEqual(42, VersionSeven.LocalFunctions.SquareFeet(6, 7));
            Assert.AreEqual(42, await VersionSeven.LocalFunctions.DoSomething());
        }

        [Test]
        public void TypeSwitch()
        {
            Assert.Ignore();

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
                    // TODO: Implement cases as follows
                    // first case of VersionSeven.TypeSwitchC
                    //    add "C" to listOfAnswers
                    // second case of VersionSeven.TypeSwitchB
                    //    add "B" to listOfAnswers
                    // last case of VersionSeven.TypeSwitchA
                    //    add "A" to listOfAnswers

                    // uncomment to see the compiler error after implementing cases
                    //case VersionSeven.TypeSwitchB b:
                    //    listOfAnswers.Add("B");
                    //    break;
                }
            }

            Assert.AreEqual("A", listOfAnswers[0]);
            Assert.AreEqual("B", listOfAnswers[1]);
            Assert.AreEqual("C", listOfAnswers[2]);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/whats-new/csharp-7#ref-locals-and-returns
        /// </summary>
        [Test]
        public void RefReturns()
        {
            Assert.Ignore();
            // TODO: Uncomment the following lines
            //char[] results = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();

            //Assert.AreEqual('D', results[3]);
            
            //ref var d = ref VersionSeven.RefReturns.GetRef(results, 3);
            //d = 'd';

            //Assert.AreEqual('d', results[3]);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/whats-new/csharp-7#tuples
        /// </summary>
        [Test]
        public void NamedTuples()
        {
            Assert.Ignore();

            // TODO: Uncomment the following lines
            //(int x, int y) p = VersionSeven.NamedTuples.GetPoint();

            //Assert.AreEqual(7, p.x);
            //Assert.AreEqual(42, p.y);
        }

        /// <summary>
        /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/whats-new/csharp-7#out-variables
        /// </summary>
        [Test]
        public void OutVar()
        {
            Assert.Ignore();

            // TODO: Replace the if condition with int.TryParse and try parsing "42"
            // Use the out var with int result
            //if (/*replace me*/)
            //{
            //    Assert.AreEqual(42, result);
            //}
            //else
            //{
            //    Assert.Fail();
            //}
        }

        [Test]
        public void ExpressionBodiedGettersAndSetters()
        {
            Assert.Ignore();

            var obj = new VersionSeven.ExpressionBodied("This is a string");

            Assert.AreEqual("This is a string", obj.Value);

            obj.Value = "This is not a string";

            Assert.AreEqual("This is not a string", obj.Value);
        }

        [Test]
        public void ExpressionBodiedConstructors()
        {
            Assert.Ignore();

            var obj = new VersionSeven.ExpressionBodied("This is a string");

            Assert.AreEqual("This is a string", obj.Value);
        }
    }
}
