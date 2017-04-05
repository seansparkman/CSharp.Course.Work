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
            return SecondClass();
        }
    }

    public partial class PartialClass
    {
        public string SecondClass()
        {
            return "Partial Class 2";
        }
    }
}
