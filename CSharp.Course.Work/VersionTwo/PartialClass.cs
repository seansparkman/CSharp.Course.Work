using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Course.Work.VersionTwo
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/articles/csharp/language-reference/keywords/partial-type
    /// </summary>
    public partial class PartialClass
    {
        public string FirstClass()
        {
            // TODO: return SecondClass results and comment out exception
            throw new NotImplementedException();
            //return SecondClass();
        }
    }

    public partial class PartialClass
    {
        // TODO: implement method SecondClass and reutrn "Partial Class 2"
    }
}
